using WinDroid.Adb.Models;

namespace WinDroid.Adb.Services;

/// <summary>
/// Locates an ADB executable by checking an optional custom path and then the
/// directories listed in the system <c>PATH</c> environment variable.
/// </summary>
/// <remarks>
/// This type only determines whether an ADB executable exists on disk. It does
/// not launch ADB and does not verify that a located file is a genuine ADB
/// binary. The system <c>PATH</c> is read on every call so that environment
/// changes during the application lifetime are honoured.
/// </remarks>
public sealed class AdbPathResolver
{
    // The active application target is Windows, where the executable is named
    // "adb.exe". The plain "adb" name is also checked so the portable library
    // behaves sensibly on non-Windows hosts. "adb.exe" is checked first so
    // resolution is deterministic when both names exist in the same directory.
    private static readonly string[] ExecutableNames = ["adb.exe", "adb"];

    /// <summary>
    /// Attempts to locate an ADB executable.
    /// </summary>
    /// <param name="customAdbPath">
    /// Optional path to an ADB executable, typically supplied from
    /// <c>AdbSettings.CustomAdbPath</c>. <see langword="null"/>, empty, or
    /// whitespace values are ignored and resolution falls back to the system
    /// <c>PATH</c>.
    /// </param>
    /// <returns>
    /// A successful <see cref="AdbPathResult"/> containing the resolved path, or
    /// a failed result whose <see cref="AdbPathResult.ErrorMessage"/> explains
    /// why ADB could not be found. A missing ADB is an expected outcome and is
    /// reported through the result rather than by throwing.
    /// </returns>
    public AdbPathResult Resolve(string? customAdbPath = null)
    {
        string? normalizedCustomPath = NormalizeToken(customAdbPath);
        bool customPathSupplied = normalizedCustomPath is not null;

        if (customPathSupplied && File.Exists(normalizedCustomPath))
        {
            string? resolved = GetFullPathSafe(normalizedCustomPath!);
            if (resolved is not null)
            {
                return AdbPathResult.Success(resolved);
            }

            // The file exists but its path could not be normalized to an
            // absolute path, so fall through to the system PATH search.
        }

        string? pathMatch = SearchSystemPath();
        if (pathMatch is not null)
        {
            return AdbPathResult.Success(pathMatch);
        }

        return AdbPathResult.Failure(BuildNotFoundMessage(customPathSupplied));
    }

    /// <summary>
    /// Searches the directories listed in the system <c>PATH</c> for a known ADB
    /// executable name, returning the first match as an absolute path.
    /// </summary>
    private static string? SearchSystemPath()
    {
        string? pathVariable = Environment.GetEnvironmentVariable("PATH");
        if (string.IsNullOrEmpty(pathVariable))
        {
            return null;
        }

        var visitedDirectories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (string rawEntry in pathVariable.Split(Path.PathSeparator))
        {
            string? directory = NormalizeToken(rawEntry);
            if (directory is null || !visitedDirectories.Add(directory))
            {
                // Blank or duplicate entry; skip without touching the filesystem.
                continue;
            }

            string? match = FindExecutableInDirectory(directory);
            if (match is not null)
            {
                return match;
            }
        }

        return null;
    }

    /// <summary>
    /// Returns the absolute path to the first known ADB executable found in the
    /// given directory, or <see langword="null"/> if none is present or the
    /// entry cannot be inspected.
    /// </summary>
    private static string? FindExecutableInDirectory(string directory)
    {
        foreach (string executableName in ExecutableNames)
        {
            string candidate = Path.Combine(directory, executableName);

            // File.Exists is exception-free and returns false for malformed or
            // inaccessible paths, so unusable PATH entries are skipped safely.
            if (File.Exists(candidate))
            {
                string? resolved = GetFullPathSafe(candidate);
                if (resolved is not null)
                {
                    return resolved;
                }

                // Exists but cannot be normalized to an absolute path; skip it.
            }
        }

        return null;
    }

    /// <summary>
    /// Trims surrounding whitespace and a single pair of matching surrounding
    /// quotation marks, returning <see langword="null"/> when nothing usable
    /// remains.
    /// </summary>
    private static string? NormalizeToken(string? value)
    {
        if (string.IsNullOrWhiteSpace(value))
        {
            return null;
        }

        string trimmed = value.Trim();

        if (trimmed.Length >= 2 && trimmed[0] == '"' && trimmed[^1] == '"')
        {
            trimmed = trimmed[1..^1].Trim();
        }

        return string.IsNullOrEmpty(trimmed) ? null : trimmed;
    }

    /// <summary>
    /// Produces an absolute, normalized path, returning <see langword="null"/>
    /// if the path cannot be normalized.
    /// </summary>
    private static string? GetFullPathSafe(string path)
    {
        try
        {
            return Path.GetFullPath(path);
        }
        catch (Exception ex) when (
            ex is ArgumentException
                or PathTooLongException
                or NotSupportedException
                or System.Security.SecurityException)
        {
            return null;
        }
    }

    private static string BuildNotFoundMessage(bool customPathSupplied) =>
        customPathSupplied
            ? "ADB could not be found. The supplied custom path did not point to a " +
              "valid ADB executable file, and no ADB executable was found through " +
              "the system PATH."
            : "ADB could not be found through the system PATH.";
}

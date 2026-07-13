namespace WinDroid.Adb.Models;

/// <summary>
/// Represents the outcome of attempting to locate an ADB executable.
/// </summary>
/// <remarks>
/// A successful result carries a non-empty <see cref="Path"/> and a
/// <see langword="null"/> <see cref="ErrorMessage"/>. A failed result carries a
/// <see langword="null"/> <see cref="Path"/> and a non-empty
/// <see cref="ErrorMessage"/>. Use <see cref="Success"/> and <see cref="Failure"/>
/// to construct values that honour these invariants.
/// </remarks>
public sealed class AdbPathResult
{
    /// <summary>
    /// Gets a value indicating whether an ADB executable was located.
    /// </summary>
    public bool Found { get; init; }

    /// <summary>
    /// Gets the resolved absolute path to the ADB executable when
    /// <see cref="Found"/> is <see langword="true"/>; otherwise
    /// <see langword="null"/>.
    /// </summary>
    public string? Path { get; init; }

    /// <summary>
    /// Gets a concise, user-safe explanation of why resolution failed when
    /// <see cref="Found"/> is <see langword="false"/>; otherwise
    /// <see langword="null"/>.
    /// </summary>
    public string? ErrorMessage { get; init; }

    /// <summary>
    /// Creates a successful result for the given resolved executable path.
    /// </summary>
    /// <param name="path">The resolved absolute path to the ADB executable.</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="path"/> is <see langword="null"/>, empty, or whitespace.
    /// </exception>
    public static AdbPathResult Success(string path)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(path);

        return new AdbPathResult
        {
            Found = true,
            Path = path,
            ErrorMessage = null,
        };
    }

    /// <summary>
    /// Creates a failed result with the given user-safe error message.
    /// </summary>
    /// <param name="errorMessage">A concise explanation of the failure.</param>
    /// <exception cref="ArgumentException">
    /// <paramref name="errorMessage"/> is <see langword="null"/>, empty, or whitespace.
    /// </exception>
    public static AdbPathResult Failure(string errorMessage)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(errorMessage);

        return new AdbPathResult
        {
            Found = false,
            Path = null,
            ErrorMessage = errorMessage,
        };
    }
}

# Security Policy

WinDroid Runtime is an early-stage open-source project involving Windows desktop software, Android Debug Bridge integration, APK management, process execution, and future runtime and virtualization research.

Security reports are taken seriously.

This document explains how to report suspected vulnerabilities, which project areas are currently in scope, and how security-related disclosures will be handled.

> [!IMPORTANT]
> WinDroid Runtime is currently under active development and is not production-ready.
>
> Do not use current development builds in sensitive, privileged, or production environments unless you fully understand the risks.

---

## Supported Versions

WinDroid Runtime has not yet published a stable production release.

Security support currently applies to:

| Version or branch | Security support |
|---|---|
| Latest `main` branch | Supported |
| Latest `dev` branch | Best effort |
| Active development branches | Best effort |
| Older commits | Not normally supported |
| Unofficial builds or forks | Not supported by this project |
| Third-party repackaged releases | Not supported |

Once public releases begin, this table will be updated to identify which release versions continue to receive security fixes.

---

## Reporting a Vulnerability

Do not report security vulnerabilities through:

- public GitHub issues
- public GitHub Discussions
- pull-request comments
- social media
- public chat servers
- screenshots containing secrets
- public proof-of-concept repositories

Use a private maintainer communication channel.

Preferred reporting method:

```text
Security contact: novasystemslab@gmail.com
Subject: [SECURITY] WinDroid Runtime vulnerability report
```

When GitHub private vulnerability reporting is available and enabled for this repository, it may also be used.

If the report contains credentials, private keys, personal information, sensitive logs, or exploit material, do not include more information than is necessary to identify the issue.

---

## Information to Include

A useful security report should contain:

- a clear title
- the affected component
- the affected branch, commit, or version
- the operating-system version
- reproduction steps
- expected behaviour
- observed behaviour
- potential security impact
- required privileges
- whether user interaction is required
- whether the issue is remotely exploitable
- relevant logs with sensitive data removed
- proof-of-concept details where safe
- suggested mitigations, if known

Where relevant, identify the affected project area:

- WinDroid Studio
- WinDroid Core
- WinDroid ADB
- WinDroid Engine
- installer or packaging
- update mechanism
- configuration storage
- logging
- dependency
- documentation
- build or release infrastructure

Do not include:

- real user credentials
- live access tokens
- private signing keys
- personal documents
- third-party confidential data
- destructive payloads
- malware
- unnecessary personal information

---

## Security Scope

The following areas are considered security-sensitive.

### ADB Command Execution

Reports are in scope when they involve:

- command injection
- unsafe argument construction
- shell interpolation
- execution of unintended commands
- unsafe custom ADB paths
- execution of an untrusted ADB binary
- privilege-boundary confusion
- insecure process creation
- uncontrolled environment-variable use
- sensitive command output exposure
- improper handling of connected devices

ADB commands must be executed through controlled process boundaries and structured arguments rather than unsafe shell-concatenated command strings.

---

### APK Handling

Reports are in scope when they involve:

- arbitrary code execution caused by APK parsing
- unsafe file-path handling
- directory traversal
- unsafe temporary-file creation
- automatic execution of untrusted files
- insecure APK metadata extraction
- signature or identity misrepresentation
- installing an APK on the wrong target
- bypassing required user confirmation
- leakage of APK contents or metadata
- malicious filename handling
- unsafe archive extraction

WinDroid Runtime must treat APK files as untrusted input.

Selecting an APK must not imply that it is safe, authentic, licensed, or malware-free.

---

### File-System Access

Reports are in scope when they involve:

- arbitrary file overwrite
- arbitrary file deletion
- path traversal
- insecure temporary directories
- unsafe symbolic-link handling
- writing outside approved directories
- exposing sensitive user files
- insecure permission handling
- unsafe import or export behaviour

Future file push, pull, backup, import, export, and shared-folder features must use explicit destination validation and user confirmation.

---

### Configuration and Secrets

Reports are in scope when they involve:

- credentials stored in plaintext
- access tokens committed to the repository
- secrets included in logs
- insecure configuration permissions
- unsafe custom binary paths
- sensitive environment-variable exposure
- insecure recovery information
- accidental upload of local configuration
- secret leakage through diagnostics or crash reports

The project should not require or store unnecessary credentials.

No secrets should be committed to source control.

---

### Logging and Diagnostics

Reports are in scope when logs or diagnostic reports expose:

- usernames
- home-directory paths
- device identifiers
- serial numbers
- IP addresses
- application lists
- package names where sensitive
- command history
- access tokens
- credentials
- private file paths
- personal information
- ADB output containing sensitive device data

Logs must be treated as potentially sensitive.

Diagnostic exports should minimize data and clearly tell users what will be included.

---

### Device and Runtime Isolation

Future runtime and virtualization issues are in scope when they involve:

- guest-to-host escape
- host-to-guest boundary failure
- unauthorized host-file access
- unsafe shared folders
- clipboard leakage
- cross-application data exposure
- network isolation failure
- privilege escalation
- insecure inter-process communication
- unauthorized device access
- sandbox bypass
- runtime image tampering
- unverified boot components

Claims of isolation or sandboxing must not be made until they are implemented and tested.

---

### Windows Integration

Reports are in scope when they involve:

- privilege escalation
- unsafe elevation prompts
- insecure service installation
- insecure registry modification
- unsafe scheduled tasks
- startup persistence without consent
- insecure URI handlers
- unsafe file associations
- unquoted executable paths
- DLL search-order issues
- insecure update mechanisms
- misuse of Windows application capabilities

WinDroid Runtime should use the least privilege necessary.

Administrative privileges must not be requested unless a feature genuinely requires them.

---

### Dependencies and Supply Chain

Reports are in scope when they involve:

- vulnerable dependencies
- dependency confusion
- malicious packages
- compromised build tools
- unpinned or unverified release dependencies
- unsafe download behaviour
- missing integrity verification
- compromised GitHub Actions
- exposed workflow secrets
- insecure release artifacts
- tampered third-party binaries
- untrusted ADB distributions
- unexpected telemetry in dependencies

Dependencies should be obtained from trusted sources and reviewed for licence, maintenance, and security status.

---

### Update and Release Security

Future update mechanisms must protect against:

- unsigned updates
- update-channel hijacking
- downgrade attacks
- insecure transport
- tampered packages
- execution before integrity verification
- release-signing key exposure
- misleading publisher information

Until a secure update system exists, the project must not claim to provide automatic secure updates.

---

## Out-of-Scope Reports

The following are normally outside the project’s security scope:

- vulnerabilities in Microsoft Windows itself
- vulnerabilities in Android itself
- vulnerabilities in AOSP not introduced by WinDroid Runtime
- vulnerabilities in Google Play Services
- vulnerabilities in Amazon Appstore
- vulnerabilities in third-party APKs
- vulnerabilities in user-supplied Android images
- vulnerabilities in unofficial forks
- vulnerabilities in modified or repackaged builds
- unsupported operating systems
- unsupported hardware configurations
- social-engineering attacks unrelated to the project
- denial-of-service reports requiring unrealistic local resource exhaustion
- theoretical issues without a credible impact or reproduction path
- missing security headers on sites that do not process sensitive data
- reports based only on automated scanner output without validation

A third-party vulnerability may still be relevant if WinDroid Runtime introduces, worsens, or fails to mitigate the risk in a way users would not reasonably expect.

---

## Unsafe or Prohibited Testing

Do not perform security testing that:

- accesses another person’s system without permission
- damages data
- disrupts services
- distributes malware
- steals credentials
- bypasses payment or licence systems
- attacks unrelated third parties
- uploads confidential information
- creates persistence without consent
- targets production systems not owned by you
- violates applicable law
- violates a third party’s terms or authorization boundaries

Testing should be performed only on systems, devices, images, applications, and accounts that you own or are explicitly authorized to test.

---

## Responsible Disclosure

Reporters are asked to allow maintainers a reasonable opportunity to:

- confirm the issue
- understand the impact
- develop a fix
- test the fix
- review affected releases
- notify users where appropriate
- coordinate disclosure

Do not publish technical details that would place users at immediate risk before a fix or mitigation is available.

The project will attempt to coordinate disclosure timing with the reporter.

No guarantee of a particular disclosure date can be made for complex, disputed, third-party, or architectural issues.

---

## Expected Response Process

After receiving a report, maintainers will aim to:

1. acknowledge receipt
2. review the report for completeness
3. reproduce or validate the issue
4. determine severity and affected components
5. identify temporary mitigations
6. prepare and review a fix
7. test for regressions
8. publish an advisory or release where appropriate
9. credit the reporter when requested and appropriate

Target response times are goals rather than guarantees:

| Stage | Target |
|---|---|
| Initial acknowledgement | Within 5 business days |
| Initial assessment | Within 10 business days |
| Status update for confirmed issues | At least every 14 days |
| Fix timeline | Depends on severity and complexity |

Response time may be longer during the project’s early development phase.

---

## Severity Considerations

Severity will be evaluated based on factors such as:

- confidentiality impact
- integrity impact
- availability impact
- required privileges
- required user interaction
- attack complexity
- exploit reliability
- affected users
- default configuration
- whether the issue crosses a security boundary
- whether the issue exposes the Windows host
- whether the issue exposes Android guest data
- whether the issue can affect connected physical devices

Examples of potentially high-severity issues include:

- arbitrary code execution on the Windows host
- guest-to-host escape
- unauthorized administrative execution
- silent installation of an unintended APK
- execution of an attacker-controlled binary
- arbitrary host-file overwrite
- exposure of credentials or signing keys
- insecure automatic updates
- command injection through user-controlled input

---

## Security Fixes

Security fixes should normally:

- be developed privately when early disclosure creates meaningful risk
- include regression tests where practical
- avoid introducing unrelated changes
- document affected versions
- include mitigation guidance
- be reviewed before release
- avoid publishing exploit details before users can update

Once a fix is available, maintainers may:

- publish a security advisory
- release a patched version
- update affected branches
- revoke compromised credentials
- rotate signing or access keys
- remove unsafe releases
- update documentation
- notify downstream users or maintainers

---

## Security in Pull Requests

Contributors must not knowingly introduce:

- unsafe shell command construction
- hard-coded secrets
- insecure temporary files
- silent telemetry
- unnecessary elevation
- unvalidated external paths
- automatic execution of downloaded files
- unverified binary downloads
- insecure deserialization
- broad file-system permissions
- security-sensitive behaviour without user confirmation

Security-sensitive pull requests should explain:

- the trust boundary
- attacker-controlled inputs
- required privileges
- validation performed
- failure behaviour
- logging behaviour
- tests added
- security trade-offs

Large security-sensitive changes may require an architecture decision record before implementation.

---

## Secret Handling

Never commit:

- passwords
- access tokens
- API keys
- private keys
- signing certificates
- recovery codes
- personal credentials
- production connection strings
- webhook secrets
- cloud credentials
- private package tokens

If a secret is accidentally committed:

1. treat it as compromised
2. revoke or rotate it immediately
3. notify the maintainers privately
4. remove it from current source
5. review repository history and logs
6. assess whether additional cleanup is required

Deleting the visible line from a later commit does not make an exposed secret safe.

---

## Security of AI-Assisted Contributions

AI-assisted code must receive the same security review as manually written code.

Contributors remain responsible for:

- validating generated code
- testing failure cases
- checking for command injection
- checking for insecure file handling
- checking for invented APIs
- checking for hard-coded secrets
- checking dependency suggestions
- verifying licensing and provenance
- removing confidential prompt content
- ensuring meaningful human review

AI-generated code must not be merged solely because it compiles.

---

## Privacy

Security reports may contain sensitive information.

Maintainers should:

- limit access to reports
- avoid forwarding sensitive data unnecessarily
- redact secrets from public advisories
- avoid storing personal information longer than necessary
- not disclose reporter identity without permission
- use secure communication where practical

Reporters should remove unnecessary personal data before submitting logs or screenshots.

---

## Researcher Credit

The project may publicly credit reporters who:

- submit a valid security issue
- follow responsible-disclosure practices
- do not place users at unnecessary risk
- provide permission to be credited

Credit may include:

- name
- handle
- organization
- advisory acknowledgement

Anonymous reporting and anonymous credit requests will be respected where practical.

---

## Safe-Harbour Intent

The project supports good-faith security research conducted within the boundaries of this policy.

Good-faith research means activity intended to:

- identify and report vulnerabilities
- avoid harm
- respect privacy
- minimize data access
- avoid persistence
- avoid service disruption
- give maintainers reasonable time to respond
- comply with applicable law and authorization

This statement expresses project policy and intent. It is not legal advice and cannot authorize testing against systems, software, accounts, or services owned by third parties.

---

## Third-Party Vulnerabilities

When a report affects a third-party dependency or platform, maintainers may:

- confirm whether WinDroid Runtime is affected
- notify the upstream project
- apply a temporary mitigation
- update or remove the dependency
- delay public disclosure to coordinate with upstream
- document that no project-specific fix is available

Reporters should avoid publicly disclosing an unpatched upstream vulnerability through the WinDroid Runtime repository.

---

## Security Contact Changes

The security contact may change as Nova Systems Lab develops.

The current contact listed in this file should always be treated as authoritative for this repository.

Changes to the security-reporting process must be reviewed through a pull request.

---

## Related Documents

This security policy should be read together with:

- [`README.md`](README.md)
- [`LICENSE`](LICENSE)
- [`CONTRIBUTING.md`](CONTRIBUTING.md)
- [`docs/legal-notes.md`](docs/legal-notes.md)
- `NOTICE`, when added
- project architecture documentation
- dependency and release documentation

---

## Final Principle

When security behaviour is uncertain, prefer the safer design.

Do not silently execute, elevate, download, install, expose, transmit, or modify anything that a user would reasonably expect to control.
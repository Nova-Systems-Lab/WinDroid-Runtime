# Legal, Licensing, and Trademark Boundaries

This document defines the legal, licensing, branding, contribution, and distribution boundaries for the WinDroid Runtime project.

It applies to maintainers, contributors, documentation authors, release managers, designers, testers, and anyone representing the project publicly.

> [!IMPORTANT]
> This document is an internal project policy and risk-management guide. It is not legal advice and does not replace review by a qualified lawyer.
>
> Maintainers should seek qualified legal advice before commercial distribution, bundling third-party system images, incorporating proprietary software, entering licensing agreements, making compatibility-certification claims, or distributing components whose legal status is unclear.

---

## 1. Project Independence

WinDroid Runtime is an independent open-source project.

It is not:

- affiliated with Microsoft
- endorsed, sponsored, or approved by Microsoft
- affiliated with Google
- endorsed, sponsored, or approved by Google
- affiliated with Amazon
- endorsed, sponsored, or approved by Amazon
- an official or unofficial continuation of Windows Subsystem for Android
- a fork of Windows Subsystem for Android
- a redistribution of Windows Subsystem for Android
- an official Android product
- an Android-certified product
- an official Android Open Source Project
- an official Nova Systems Lab legal entity product unless and until such an entity is formally established

The project may refer to third-party products when reasonably necessary to describe:

- compatibility
- interoperability
- supported development workflows
- historical context
- technical research
- build requirements
- operating-system requirements

Such references must be truthful, limited to what is necessary, and must not imply partnership, endorsement, certification, ownership, sponsorship, or official status.

---

## 2. Independent Implementation Requirement

WinDroid Runtime must be developed as an original and independently implemented project.

Contributors must not submit, upload, reproduce, or incorporate:

- Microsoft WSA binaries
- files extracted from a WSA installation
- decompiled or reconstructed WSA source code
- proprietary Windows components
- confidential Microsoft documentation
- leaked Microsoft source code
- internal SDKs obtained without authorization
- copied implementations from closed-source Android emulators
- proprietary Android runtime components
- proprietary device firmware without redistribution permission
- code copied from commercial products
- confidential employer or client material
- code obtained in breach of a contract, licence, access restriction, or terms of service
- code generated from unlawfully obtained source material
- assets or implementations whose origin cannot be reasonably explained

Technical behaviour may be studied through:

- publicly documented APIs
- publicly available standards
- official development documentation
- legitimate testing and observation
- properly licensed open-source projects
- independently written experiments
- black-box interoperability testing where lawful
- independently designed compatibility research
- clean-room methods where appropriate and lawful

A contributor must be able to explain the lawful and properly licensed origin of any substantial code, binary, image, document, dataset, model, or asset submitted to the project.

Maintainers may reject any contribution where origin, authorship, permission, or licensing cannot be established with reasonable confidence.

---

## 3. Microsoft and Windows Boundaries

The following are Microsoft product names, trademarks, service marks, or other brand identifiers and should be used only in accordance with Microsoft’s published guidelines:

- Microsoft
- Windows
- Windows 10
- Windows 11
- Windows Subsystem for Android
- WSA
- Hyper-V
- Windows Hypervisor Platform
- WinUI
- Windows App SDK
- Visual Studio
- .NET
- Microsoft Store

These names may be used in accurate factual statements such as:

- “Designed for Windows 11”
- “Built with WinUI 3”
- “Built using the Windows App SDK”
- “Researching Windows Hypervisor Platform support”
- “Compatible with supported Windows environments”
- “Not affiliated with Microsoft”
- “Inspired by the gap left after the discontinuation of Windows Subsystem for Android”

Any factual reference should:

- be accurate
- be no more prominent than the WinDroid Runtime name
- be limited to what is necessary
- clearly describe the actual relationship
- avoid suggesting certification unless certification has actually been obtained
- avoid implying that Microsoft produced, maintains, or supports the project

Microsoft names and identifiers must not be used in ways that suggest:

- Microsoft created the project
- Microsoft sponsors or recommends the project
- WinDroid Runtime is an official successor to WSA
- WinDroid Runtime is part of Windows
- the project contains Microsoft technology that it does not contain
- the project is certified by Microsoft
- the project is an official Microsoft application
- the project has access to Microsoft source code or internal systems

The project must not use, without documented permission:

- Microsoft logos
- Windows logos
- WSA application icons
- Microsoft product icons
- Microsoft badges
- Microsoft-owned illustrations
- Microsoft product artwork
- copied Microsoft interface assets
- Microsoft branding as part of the WinDroid logo
- Microsoft logos as application icons
- packaging that imitates an official Microsoft product
- screenshots designed to imply that WinDroid is a Microsoft product

Screenshots containing Microsoft products or interfaces may be used only where lawful and reasonably necessary for:

- documentation
- compatibility explanation
- troubleshooting
- technical comparison
- development instructions

Such screenshots must not imply ownership, endorsement, certification, or official affiliation and should avoid unnecessary display of Microsoft logos, artwork, icons, or proprietary visual assets.

---

## 4. Windows API and Platform Usage

WinDroid Runtime may use officially documented Windows APIs, frameworks, development tools, and platform services subject to their applicable licences and terms.

Use of a Microsoft API, framework, SDK, package, or development tool does not by itself mean that Microsoft:

- endorses the project
- certifies the project
- sponsors the project
- accepts responsibility for the project
- grants permission to use Microsoft branding

Any Microsoft package, SDK, runtime, redistributable, or binary included in a release must be reviewed for:

- redistribution permission
- licence requirements
- version restrictions
- attribution requirements
- packaging requirements
- end-user licence terms
- platform restrictions

---

## 5. Android, AOSP, and Google Boundaries

Android Open Source Project components and proprietary Google software must be treated as separate categories.

The availability of AOSP source code does not grant permission to distribute proprietary Google applications, services, branding, certification materials, or device-specific packages.

WinDroid Runtime must not bundle, redistribute, represent as included, or automatically obtain without appropriate permission:

- Google Play Store
- Google Play Services
- Google Mobile Services
- Google Services Framework
- proprietary Google applications
- Google account integration components
- Google certification files
- device-specific Google application packages
- proprietary Google APIs or libraries without an appropriate licence
- Google-controlled security keys or credentials
- device certification identifiers
- proprietary vendor packages obtained from devices without redistribution permission

The project may support or research:

- user-supplied APK installation
- ADB-based package management
- open-source Android applications
- open-source application repositories
- independently obtained Android images
- lawfully distributable Android images
- AOSP-based development and research
- Generic System Image research where licensing permits
- compatibility with applications that do not require proprietary Google services
- optional user-directed integrations that do not redistribute restricted components

Any future Google Play or Google Mobile Services integration must require:

- documented authorization
- applicable licensing
- required certification
- compatibility review
- security review
- legal review
- written maintainer approval

The following terms may be used factually where relevant:

- Android
- Android Debug Bridge
- ADB
- Android Open Source Project
- AOSP
- Google Play
- Google Mobile Services

They must not be used to imply that WinDroid Runtime is:

- an official Android product
- certified by Google
- endorsed by Google
- supplied with Google Play
- guaranteed to support every Android application
- compliant with Android compatibility requirements unless formally verified
- licensed to redistribute proprietary Google software

Use of the Android name, robot, wordmark, Google Play badge, or related branding must follow Google’s current published brand guidelines.

Factual compatibility statements do not authorize use of Google-controlled logos, badges, wordmarks, certification marks, or marketing artwork.

---

## 6. AOSP Component Licensing

AOSP is not governed by one single licence across every component.

Before incorporating AOSP code, maintainers must review the licence of each component individually.

AOSP-related components may include code under:

- Apache License 2.0
- GNU General Public License
- GNU Lesser General Public License
- BSD licences
- MIT-style licences
- other open-source licences
- component-specific notices or exceptions

The project must preserve all obligations that apply to incorporated components, including where relevant:

- source-code availability
- licence-text distribution
- modification notices
- attribution notices
- copyright notices
- NOTICE files
- reciprocal licensing requirements
- installation information
- written offers
- build instructions

Code must not be described simply as “AOSP licensed” without identifying the actual licence governing the relevant component.

---

## 7. Linux Kernel and Copyleft Components

Any Linux kernel, kernel module, driver, or GPL-licensed component considered for use must be reviewed separately from Apache-licensed project code.

The project must not assume that the Apache License 2.0 automatically governs incorporated GPL, LGPL, or other copyleft components.

Before distribution, maintainers must determine:

- whether the component is modified or unmodified
- whether the component is linked, combined, or distributed separately
- whether source code must be made available
- whether corresponding source obligations apply
- whether scripts or build instructions must be supplied
- whether licence notices must accompany binaries
- whether the intended combination is licence-compatible

Copyleft obligations must not be avoided through misleading packaging or documentation.

Where legal or licensing compatibility is uncertain, the component must not be included in a public release until reviewed.

---

## 8. Amazon Boundaries

WinDroid Runtime is not affiliated with Amazon and is not a continuation of Amazon Appstore integration previously associated with WSA.

The project must not:

- bundle Amazon Appstore components without permission
- use Amazon branding as part of its identity
- imply that Amazon supports the project
- redistribute proprietary Amazon applications
- use Amazon logos without permission
- claim official Amazon Appstore compatibility without verification
- use Amazon credentials, APIs, or services outside their applicable terms

Factual references to Amazon or Amazon Appstore may be made when discussing:

- compatibility
- technical history
- previous Android-on-Windows systems
- application availability
- documented integration behaviour

---

## 9. WinDroid Branding

WinDroid Runtime branding must remain visually and verbally distinct from Microsoft, Google, Android, Amazon, emulator vendors, and other existing products.

Current internal project names include:

- WinDroid Runtime
- WinDroid Studio
- WinDroid Core
- WinDroid ADB
- WinDroid Engine

Project branding should:

- use original logos and artwork
- avoid copying Windows or Android visual identities
- avoid official-looking Microsoft or Google product presentation
- clearly state the project’s independent status
- remain consistent across repositories, applications, documentation, websites, and releases
- remain subordinate to any future approved Nova Systems Lab branding policy

Before adopting new names, logos, domains, package identifiers, publisher names, or public-facing product identities, maintainers should perform a reasonable naming and trademark-conflict review.

No contributor may independently register project-related:

- trademarks
- domains
- social-media accounts
- package names
- application-store listings
- organization accounts
- donation accounts
- publisher identities

on behalf of WinDroid Runtime or Nova Systems Lab without explicit maintainer approval.

Registration of a name, domain, account, or package identifier does not automatically transfer ownership to the project.

---

## 10. Nova Systems Lab Status

Nova Systems Lab currently functions as the GitHub organization and public project umbrella under which WinDroid Runtime is developed.

Unless separately registered as a legal entity, Nova Systems Lab must not be represented as:

- a registered company
- an incorporated nonprofit
- a legal foundation
- a formal employer
- a party capable of independently owning rights merely by being a GitHub organization

Copyright remains with the individual or legal entity that created the relevant contribution unless rights are formally assigned.

Project notices may use wording such as:

```text
Copyright 2026 Samrat Banerjee and Nova Systems Lab contributors
```

This wording does not by itself transfer contributor copyright to Nova Systems Lab.

Any future transfer of copyright, trademarks, domains, or other assets to a registered legal entity must be documented separately.

---

## 11. Repository Licence

Unless otherwise stated, original code and documentation in this repository are licensed under the Apache License 2.0.

Contributions intentionally submitted for inclusion in the repository are expected to be provided under the Apache License 2.0 unless:

- the contributor clearly states otherwise before submission
- the contribution is rejected
- a separate written agreement has been approved by the maintainers

The Apache License 2.0 grants specified copyright and patent permissions under its terms.

It does not grant general permission to use a licensor’s:

- trade names
- trademarks
- service marks
- product names

except for reasonable and customary descriptive use and required notice reproduction.

Every contributor must ensure that they have the right to submit their contribution.

Contributors must not remove or improperly alter:

- copyright notices
- licence notices
- attribution notices
- patent notices
- required `NOTICE` content
- third-party licence files
- source-identification information
- modification notices required by an upstream licence

Where required by an incorporated dependency or source file, modifications must be identified appropriately.

---

## 12. Copyright Ownership

The repository licence governs permission to use contributions but does not automatically transfer ownership of copyright.

Unless a separate written assignment exists:

- each contributor retains copyright in their original contribution
- each contribution is licensed under the repository licence
- maintainers retain copyright in their original work
- Nova Systems Lab does not automatically own contributor copyright
- accepting a pull request does not by itself transfer ownership

The project should not claim exclusive ownership over work created by independent contributors unless there is a valid written assignment.

Copyright notices should be accurate and should not erase previous or third-party copyright holders.

---

## 13. Apache License Compliance

When redistributing Apache-licensed work or derivative works, the project must review and satisfy applicable requirements, including:

- providing a copy of the Apache License 2.0
- marking modified files where required
- retaining applicable copyright notices
- retaining applicable patent notices
- retaining applicable trademark notices
- retaining applicable attribution notices
- reproducing required `NOTICE` content where applicable
- not using the licence to claim trademark authorization

A `NOTICE` file should be created when:

- required by an incorporated work
- attribution notices need to be distributed
- the project has release-level notices that should accompany binaries

A `NOTICE` file must not be used to add restrictions that modify the Apache License.

---

## 14. Third-Party Dependencies

Every new dependency must be reviewed before it is added.

The review should consider:

- dependency name
- version
- source
- licence name and version
- whether commercial and non-commercial use are allowed
- whether modification is allowed
- whether redistribution is allowed
- attribution requirements
- source-disclosure requirements
- patent clauses
- trademark restrictions
- binary redistribution terms
- platform restrictions
- field-of-use restrictions
- compatibility with Apache License 2.0
- maintenance status
- security status
- whether the dependency is genuinely necessary
- whether a standard-library or platform alternative exists

Dependencies must not be added solely because they are:

- publicly downloadable
- available from a package manager
- free of charge
- visible on GitHub
- included in another application
- technically convenient

Public availability does not automatically mean redistribution is permitted.

Where practical, pull requests adding dependencies should include:

```text
Dependency:
Version:
Source:
Licence:
Purpose:
Redistribution requirements:
Relevant notices:
Alternatives considered:
Security or maintenance concerns:
```

Dependencies with unclear, custom, non-commercial, research-only, source-available, or restrictive licences require explicit maintainer review.

---

## 15. Binary Components

Binary-only components require heightened review.

Before adding or distributing a binary, maintainers must determine:

- who owns it
- where it came from
- whether redistribution is allowed
- whether modification is allowed
- whether reverse engineering is restricted
- whether the binary is architecture-specific
- whether it includes additional bundled software
- whether it collects data
- whether it contacts third-party services
- whether it requires separate end-user terms
- whether source-code obligations apply
- whether checksums and provenance can be recorded

Unknown, leaked, extracted, repackaged, or unverifiable binaries must not be distributed.

---

## 16. Android Images and System Images

WinDroid Runtime must not assume that an Android image may be redistributed merely because it can be downloaded or booted.

Each image must be reviewed for:

- source
- publisher
- component licences
- vendor components
- proprietary applications
- firmware
- drivers
- codec licences
- Google components
- device-specific packages
- redistribution terms
- modification rights
- export restrictions
- required notices

The project should prefer:

- images built from properly licensed source
- reproducible build processes
- clear component manifests
- documented provenance
- user-supplied images where redistribution is not permitted
- download instructions pointing users to lawful official sources

The project must not host or mirror images whose redistribution rights are unclear.

---

## 17. APK and Application Distribution

WinDroid Runtime may provide tools that allow users to install APK files they lawfully possess.

The project must not:

- host pirated APK files
- provide links intended to bypass paid distribution
- distribute modified proprietary applications without permission
- distribute cracked applications
- bypass licence checks
- bypass digital-rights-management systems
- impersonate application stores
- bundle applications without redistribution rights
- encourage violation of application licences

Support for APK installation does not mean the project verifies the legality, safety, authenticity, or licence status of every APK selected by a user.

Documentation should encourage users to obtain applications from lawful and trustworthy sources.

---

## 18. Reverse Engineering and Interoperability Research

Reverse-engineering and interoperability rights vary by jurisdiction, contract, licence, and applicable law.

No contributor should assume that conduct permitted in one country is automatically permitted elsewhere.

Any reverse-engineering-related work must avoid:

- leaked source code
- stolen credentials
- unauthorized access
- circumvention of access controls
- circumvention of technological protection measures
- violation of confidentiality obligations
- use of employer-confidential information
- copying protected implementation expression
- distribution of proprietary extracted material

Where interoperability research is necessary, contributors should prefer:

- public documentation
- standards
- observable behaviour
- independent test programs
- protocol traces created lawfully
- independently written implementations
- documented research methodology
- clean separation between researchers and implementers where appropriate

Uncertain work should be discussed privately with maintainers before publication or submission.

---

## 19. Security Research and Restricted Material

The repository must not be used to publish or distribute:

- stolen credentials
- private signing keys
- leaked certificates
- production access tokens
- exploit chains targeting active users
- malware
- credential-stealing tools
- proprietary keys
- confidential vulnerability reports
- bypasses that create unjustified user risk
- restricted third-party security material

Legitimate defensive security research may be accepted where it is:

- relevant to the project
- responsibly disclosed
- lawful
- safely documented
- limited to necessary technical detail
- reviewed by maintainers

Security vulnerabilities in WinDroid Runtime should be reported according to `SECURITY.md`.

---

## 20. Contributor Certification

By submitting a contribution, a contributor represents that:

- they created the contribution or have the right to submit it
- the contribution may be distributed under the repository licence
- the contribution does not knowingly contain unlawfully copied material
- required third-party notices have been preserved
- dependencies and borrowed material have been disclosed
- confidential employer or client material has not been included
- generated content has been reviewed
- the contribution does not knowingly violate another project’s licence
- they have not intentionally concealed the origin of substantial material

Maintainers may request:

- source links
- licence files
- attribution information
- design notes
- dependency justification
- provenance explanations
- proof of permission
- replacement of questionable material

Refusal or inability to provide reasonable provenance information may result in rejection or removal.

---

## 21. Developer Certificate of Origin

The project may adopt the Developer Certificate of Origin for contributor sign-off.

Where enabled, contributors may be required to sign commits using:

```text
Signed-off-by: Name <email@example.com>
```

Use of sign-off indicates that the contributor certifies their right to submit the contribution under the project’s licence and contribution process.

Commit sign-off is not a substitute for licence review, provenance review, or legal advice.

---

## 22. AI-Assisted Contributions

AI-assisted code, documentation, tests, images, or designs must be reviewed as carefully as human-written material.

Contributors using AI assistance remain responsible for:

- correctness
- security
- originality
- licence compliance
- attribution
- provenance
- confidential-information handling
- third-party rights
- compliance with repository policy

AI-generated material must not be submitted when:

- it reproduces identifiable third-party code without permission
- its origin cannot be reasonably assessed
- it contains confidential information
- it introduces copied branding or artwork
- it creates false legal or compatibility claims
- it includes insecure or unreviewed code
- it is submitted without meaningful human review

AI assistance must not be used as a justification for ignoring licensing or attribution concerns.

---

## 23. Documentation and Public Claims

Documentation, release notes, websites, social posts, videos, and interviews must not make unsupported claims.

The project must not claim:

- universal Android application compatibility
- Google certification
- Microsoft certification
- official successor status
- production readiness before verification
- security guarantees that have not been established
- legal permission to distribute third-party components without evidence
- performance results without reproducible testing
- compliance with standards that have not been formally tested

Compatibility claims should be qualified and evidence-based.

Preferred language includes:

- “experimental”
- “planned”
- “under research”
- “tested with”
- “currently supports”
- “not yet implemented”
- “compatibility may vary”

Avoid absolute statements such as:

- “works with every Android app”
- “fully secure”
- “officially compatible”
- “drop-in WSA replacement”
- “guaranteed safe”
- “legally approved”

---

## 24. Compatibility Testing

Compatibility testing must use software and images obtained lawfully.

Test results should record:

- application name
- application version
- source
- WinDroid version
- Windows version
- runtime backend
- test date
- observed result
- known limitations

A compatibility result does not grant permission to redistribute the tested application.

Application names and logos should not be used in project marketing beyond reasonable factual identification without appropriate permission.

---

## 25. Privacy and Telemetry

Any future telemetry, diagnostics, crash reporting, or analytics feature must be reviewed for:

- user consent
- data minimization
- transparency
- retention
- security
- third-party processors
- regional legal requirements
- opt-out or opt-in design
- documentation
- sensitive-data handling

The project must not silently collect:

- installed application lists
- file paths
- personal identifiers
- account information
- device identifiers
- user documents
- precise usage history
- ADB contents
- logs containing sensitive information

Telemetry must not be introduced through a dependency without disclosure and review.

---

## 26. Project Assets and Media

All project logos, icons, screenshots, diagrams, fonts, sounds, videos, and promotional assets must have documented provenance.

Assets must be:

- original
- properly licensed
- public domain
- used with written permission
- generated under terms permitting project use

The project must not use:

- Microsoft logos
- Windows logos
- Android logos outside permitted guidelines
- Google logos
- Amazon logos
- copied emulator icons
- copyrighted artwork without permission
- commercial fonts without appropriate rights
- stock media without appropriate licensing

Asset source files and licence information should be retained where practical.

---

## 27. Domains, Accounts, and Package Identifiers

Project domains, organization accounts, code-signing identities, package identifiers, and application-store accounts are project infrastructure.

They must not be created, transferred, sold, or closed without maintainer approval.

Access should follow:

- least privilege
- multi-factor authentication
- documented recovery methods
- secure credential storage
- separation of personal and project credentials where practical
- transfer planning for future organizational changes

Contributors must not claim personal ownership over project identity merely because they created an account on the project’s behalf.

Formal ownership and transfer arrangements should be documented separately.

---

## 28. Commercial Distribution

Commercial use may be permitted by the applicable open-source licences, but commercial distribution introduces additional obligations and risks.

Before a commercial release, maintainers should review:

- third-party licences
- consumer-law obligations
- warranties and disclaimers
- privacy obligations
- export-control issues
- tax and payment requirements
- code-signing requirements
- app-store terms
- trademark clearance
- patent risks
- support commitments
- system-image redistribution
- proprietary codec or firmware inclusion

No contributor may enter a commercial, sponsorship, licensing, or distribution agreement on behalf of WinDroid Runtime or Nova Systems Lab without explicit authority.

---

## 29. Release Review

Before publishing a binary release, maintainers should verify:

- source provenance
- dependency licences
- binary redistribution rights
- required licence files
- required notices
- third-party attributions
- modification notices
- system-image rights
- application bundling rights
- trademark presentation
- release claims
- privacy behaviour
- telemetry behaviour
- security-sensitive components
- code-signing identity
- reproducibility where practical

A release should not proceed while a material legal, licensing, provenance, trademark, or security concern remains unresolved.

---

## 30. Handling Uncertainty

Where a contributor or maintainer is uncertain about:

- licensing
- copyright
- patents
- trademarks
- redistribution
- reverse engineering
- proprietary components
- binary provenance
- application distribution
- system-image distribution
- confidential information
- AI-generated material

they must stop and request review before merging, publishing, or distributing the material.

The project should prefer exclusion over uncertain distribution.

Temporary removal of disputed material does not imply wrongdoing. It is a precautionary project-management action.

---

## 31. Enforcement

Maintainers may:

- reject contributions
- request revisions
- request provenance information
- remove files
- remove releases
- disable downloads
- revert commits
- suspend contributor access
- lock discussions
- report suspected infringement
- contact upstream owners
- request formal legal review

where material appears inconsistent with this policy.

Repeated or intentional violations may result in removal from the project.

---

## 32. Maintainer Responsibilities

Maintainers are responsible for:

- applying this policy consistently
- recording dependency decisions
- preserving licence and attribution files
- reviewing release contents
- avoiding unsupported public claims
- responding to legitimate rights-holder concerns
- documenting exceptions
- protecting project credentials
- reviewing branding changes
- separating project policy from legal advice
- obtaining professional advice when risk is significant

Maintainer approval does not guarantee that material is legally risk-free.

---

## 33. Current Distribution Policy

During the early development and research phases, WinDroid Runtime should distribute only:

- original project source code
- original project documentation
- original project artwork
- properly licensed dependencies
- build outputs whose components are approved for redistribution

The project should not currently distribute:

- complete Android system images
- Google applications or services
- WSA-derived files
- proprietary vendor firmware
- proprietary application stores
- copied commercial-emulator components
- device-specific proprietary packages
- third-party APK collections

This policy may be revised after technical, licensing, and legal review.

---

## 34. Related Repository Documents

This policy should be read together with:

- [`README.md`](../README.md)
- [`LICENSE`](../LICENSE)
- [`CONTRIBUTING.md`](../CONTRIBUTING.md)
- [`SECURITY.md`](../SECURITY.md)
- `NOTICE`, when added
- third-party licence and attribution files
- dependency documentation
- release checklists

Where a conflict exists between this policy and an applicable third-party licence, the applicable licence must be reviewed and followed.

This policy does not override statutory law, contractual obligations, or third-party licence terms.

---

## 35. Policy Changes

This document may be updated as:

- the architecture evolves
- runtime components are selected
- dependencies are added
- distribution methods change
- the project begins publishing binaries
- legal or trademark guidance changes
- Nova Systems Lab’s organizational status changes
- professional legal advice is obtained

Material changes should be reviewed through a pull request.

The pull request should explain:

- what changed
- why it changed
- which project areas are affected
- whether existing releases or assets require review

---

## 36. Contact and Escalation

Questions about this policy should be raised through an appropriate project discussion or maintainer communication channel.

Potential security vulnerabilities should follow `SECURITY.md` rather than being posted publicly.

Potential copyright, trademark, licence, or redistribution concerns should include:

- the affected file or release
- the relevant rights holder
- the source of the material
- the applicable licence or policy
- the requested corrective action

Sensitive claims or confidential evidence should not be posted publicly.

---

## Summary

WinDroid Runtime must remain:

- independently implemented
- openly licensed
- clearly branded
- transparent about compatibility
- careful with third-party material
- separate from Microsoft, Google, Amazon, and WSA
- conservative about proprietary binaries and system images
- accountable for the provenance of code and assets

When ownership, licensing, redistribution, branding, or provenance is unclear, do not merge or distribute the material until it has been reviewed.
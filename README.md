# WinDroid Runtime

![Status](https://img.shields.io/badge/status-planning-blue)
![Platform](https://img.shields.io/badge/platform-Windows%2011-blue)
![Language](https://img.shields.io/badge/language-C%23-purple)
![License](https://img.shields.io/badge/license-Apache%202.0-green)

**WinDroid Runtime** is an independent Android-compatible runtime and toolkit for Windows.

The long-term goal of this project is to build a modern platform that allows Android applications to run, integrate, and feel natural on Windows. The project is being designed from scratch, starting with developer tooling, APK management, ADB integration, and runtime research before moving toward experimental Android runtime and desktop integration research.

> **Project Status:** Early planning and research phase.  
> This repository currently contains the project vision, roadmap, and architecture planning. Production-ready runtime code has not been implemented yet.
> This project is not currently usable as an Android runtime. It is a planning-stage repository for a long-term open-source systems project.

---

## Vision

Windows previously had official Android app support through Windows Subsystem for Android. After its discontinuation, there is a gap for users, developers, and students who want a clean Android-on-Windows experience without relying only on traditional emulators.

WinDroid Runtime aims to explore that space by building an independent, open-source Android-compatible runtime and toolkit for Windows.

The goal is not to reuse or modify Microsoft WSA. The goal is to build an original system from the ground up.

---

## Core Goals

- Build an independent Android-compatible runtime for Windows.
- Provide a native Windows control application for managing the runtime.
- Support APK installation, uninstallation, launching, and debugging.
- Integrate ADB-based developer tools.
- Research Android image booting and runtime backends.
- Explore native-feeling Windows integration for Android apps.
- Build a safe, transparent, and open-source project structure.
- Avoid dependency on proprietary WSA binaries or branding.

---

## Planned Components

### WinDroid Studio

The native Windows control application for managing WinDroid Runtime.

Planned features:

- Runtime dashboard
- ADB detection
- Connected device/runtime detection
- APK installation
- Installed app list
- App launch/uninstall controls
- Log viewer
- Runtime settings
- Developer tools

### WinDroid Core

Shared project logic used across the runtime and control application.

Planned responsibilities:

- Configuration management
- Runtime state tracking
- App metadata handling
- Logging
- Error handling
- Shared models and services

### WinDroid ADB Layer

A dedicated service layer for interacting with Android Debug Bridge.

Planned features:

- Detect ADB installation
- Start/stop ADB server
- List connected devices
- Install APK files
- Uninstall packages
- Launch apps
- Capture logs
- Run shell commands

### WinDroid Engine

The long-term experimental runtime backend.

Research areas:

- Android x86/x86_64 images
- AOSP / Generic System Images
- Virtualization on Windows
- QEMU / Hyper-V / Windows Hypervisor Platform research
- Android boot process
- Graphics, input, audio, networking, and file bridges

---

## Development Roadmap

### Phase 0 — Planning and Research

- [x] Choose project name
- [x] Define project scope
- [x] Add license
- [x] Create initial README
- [ ] Write architecture notes
- [ ] Create contribution guidelines
- [ ] Document legal/trademark boundaries

### Phase 1 — Native Windows Control App

- [ ] Create WinUI 3 / .NET project structure
- [ ] Build initial dashboard UI
- [ ] Add project settings page
- [ ] Add logging system
- [ ] Add basic runtime status panel

### Phase 2 — ADB Integration

- [ ] Detect ADB installation
- [ ] Allow custom ADB path
- [ ] Run `adb devices`
- [ ] Parse connected devices/emulators
- [ ] Display device information in the UI
- [ ] Start and stop ADB server

### Phase 3 — APK Management

- [ ] Select APK file from Windows
- [ ] Install APK to selected target
- [ ] List installed packages
- [ ] Launch installed apps
- [ ] Uninstall apps
- [ ] Clear app data
- [ ] Show install/log output clearly

### Phase 4 — Developer Tools

- [ ] Add logcat viewer
- [ ] Add screenshot capture
- [ ] Add file push/pull tools
- [ ] Add basic shell command interface
- [ ] Add exportable diagnostic reports

### Phase 5 — Runtime Backend Research

- [ ] Research AOSP x86/x86_64 boot options
- [ ] Research QEMU and Windows Hypervisor Platform
- [ ] Boot a minimal Android-compatible image
- [ ] Connect to the runtime through ADB
- [ ] Install and launch a test APK inside the runtime

### Phase 6 — Windows Integration Research

- [ ] Explore app window forwarding
- [ ] Research input bridge
- [ ] Research clipboard sharing
- [ ] Research file sharing
- [ ] Research notification bridge
- [ ] Research Start Menu and shortcut integration

### Phase 7 — Long-Term Runtime Goals

- [ ] Independent runtime backend
- [ ] Per-app windows
- [ ] Shared folder controls
- [ ] Audio support
- [ ] Networking support
- [ ] GPU acceleration research
- [ ] Compatibility database
- [ ] Installer and public beta

---

## Proposed Repository Structure

```text
WinDroid-Runtime/
├── src/
│   ├── WinDroid.Studio/      # Native Windows control app
│   ├── WinDroid.Core/        # Shared logic and models
│   ├── WinDroid.Adb/         # ADB integration layer
│   └── WinDroid.Engine/      # Experimental runtime backend
│
├── docs/
│   ├── architecture.md
│   ├── roadmap.md
│   ├── research-log.md
│   └── legal-notes.md
│
├── assets/
│   └── branding/
│
├── README.md
├── LICENSE
├── CONTRIBUTING.md
├── SECURITY.md
└── .gitignore
```

## Technology Stack

The planned first-stage stack:

- **Language:** C#
- **Framework:** .NET
- **Desktop UI:** WinUI 3 / Windows App SDK
- **Platform:** Windows 11
- **Tooling:** Android Debug Bridge
- **Version Control:** Git and GitHub

Long-term research may involve:

- C++
- Rust
- AOSP
- QEMU
- Hyper-V
- Windows Hypervisor Platform
- VirtIO
- Graphics/input/audio bridge systems

## What This Project Is

WinDroid Runtime is:

- An independent open-source project
- A Windows-focused Android compatibility/runtime research project
- A developer toolkit for Android-on-Windows workflows
- A long-term attempt to explore native-feeling Android app support on Windows

## What This Project Is Not

WinDroid Runtime is not:

- A fork of Microsoft WSA
- An official or unofficial continuation of Microsoft WSA
- A Microsoft product
- A Google product
- An Amazon product
- A repackaged emulator
- A redistribution of proprietary WSA binaries
- A project that bundles Google Play Store or Google Play Services without proper permission

## Legal and Trademark Notice

WinDroid Runtime is not affiliated with, endorsed by, sponsored by, or connected to Microsoft, Google, Amazon, or any related organization.

Windows, Android, Google Play, Amazon Appstore, Microsoft, Google, Amazon, and related names, logos, and trademarks are the property of their respective owners.

This project does not use Microsoft WSA binaries, Microsoft branding, Google Play binaries, or proprietary app store components.

## App Store and Google Play Notice

The project may support APK sideloading and open-source app distribution methods in future versions.

Official Google Play Store or Google Mobile Services integration is not included and will not be bundled unless proper legal permission, licensing, or certification requirements are satisfied.

## Contributing

This project is currently in the early planning and research stage.

Contributors, mentors, and developers interested in the following areas are welcome:

- C# / .NET development
- WinUI 3 desktop application development
- Android Debug Bridge tooling
- Android internals
- AOSP
- Virtualization
- Hyper-V / Windows Hypervisor Platform
- QEMU
- Graphics and input systems
- Open-source project architecture
- Security and sandboxing

Contribution guidelines will be added as the project structure becomes more stable.

## Current First Milestone

The first practical milestone is to build WinDroid Studio v0.1, a native Windows application that can:

- Detect ADB
- List connected Android devices or emulators
- Display device information
- Install APK files
- Launch installed apps
- View basic logs

This milestone will create the foundation for deeper runtime work later.

## License

This project is licensed under the Apache License 2.0.

See the LICENSE file for details.

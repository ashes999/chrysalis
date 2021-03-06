# Chrysalis ![logo](icon.png)
![build status](https://travis-ci.org/ashes999/chrysalis.svg)

Chrysalis allows you to write professional-grade Windows installers using plain C# code.

- **Familiar:** Chrysalis exposes an installer API in C#. Write C# classes to encapsulate your logic, and use Windows Forms components to build your GUI.
- **Batteries Loaded:** Chrysalis comes with built-in classes for common commands and dialogs.
- **Makes Installer Easy:** Chrysalis supports transactional installations and silent/unattended installations.
- **Testable:** All your code is plain C# code. You can write unit and integration tests to your heart's desire.

# Forms

- **WelcomeForm:** shows a "welcome to the installer wizard" form with next/cancel buttons.

# Config

Chrysalis includes a static, global `Config` class which lets you specify global configuration (such as the default form width/height).


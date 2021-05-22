#define MyAppURL "https://github.com/Cudihood/ContactsApp.git"
#define MyAppExeName "ContactsApp.exe"
#define MyAppName "ContactsApp"
#define MyAppVersion "1.0.0"
[Setup]
AppId={{ABA4722C-5B9F-4619-854C-69F81C737D3E}
AppName = {#MyAppName}
AppVersion={#MyAppVersion}
AppPublisherURL = {#MyAppURL}
AppSupportURL = {#MyAppURL}
AppUpdatesURL = {#MyAppURL}
DefaultDirName = {pf}{#MyAppName}
SetupIconFile = "..\..\icon\notebookwithcontacts.ico"
DisableProgramGroupPage = yes
OutputBaseFilename = ContactAppSetup
Compression = lzma
SolidCompression = yes
OutputDir = "Installers"

[languages]
Name: "en"; MessagesFile: "compiler:Default.isl"
Name: "russian"; MessagesFile: "compiler:Languages\Russian.isl"

[Tasks]
Name: "desktopicon"; Description: "{cm:CreateDesktopIcon}"; GroupDescription: "{cm:AdditionalIcons}"; Flags: unchecked

[Files]
Source: "Release\ContactsApp.dll"; DestDir: "{app}"
Source: "Release\Newtonsoft.Json.dll"; DestDir: "{app}"
Source: "Release\ContactsAppUI.exe"; DestDir: "{app}"

[Icons]
Name: "{commonprograms}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"
Name: "{commondesktop}\{#MyAppName}"; Filename: "{app}\{#MyAppExeName}"; Tasks: desktopicon;
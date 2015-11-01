;--------------------------------

; The name of the installer
Name "KeeSecurityCheck"

; The file to write
OutFile "publish\Install-KeeSecurityCheck.exe"

; The default installation directory
InstallDir "$PROGRAMFILES\KeePass Password Safe 2"


; Request application privileges for Windows Vista
RequestExecutionLevel admin

;--------------------------------

LicenseData "GPL2.txt"

; Pages
Page license 
Page directory
Page instfiles

UninstPage uninstConfirm
UninstPage instfiles

;--------------------------------

; The stuff to install
Section "KeeSecurityCheck (required)"

  SectionIn RO
  
  ; Set output path to the installation directory.
  SetOutPath $INSTDIR
  
  ; Put file there
  File "KeeSecurityCheck\bin\Release\KeeSecurityCheck.dll"
  
  
  ; Write the uninstall keys for Windows
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\KeeSecurityCheck" "DisplayName" "Security Check Plugin for KeePass 2"
  WriteRegStr HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\KeeSecurityCheck" "UninstallString" '"$INSTDIR\uninstallKeeSecurityCheck.exe"'
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\KeeSecurityCheck" "NoModify" 1
  WriteRegDWORD HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\KeeSecurityCheck" "NoRepair" 1
  WriteUninstaller "uninstallKeeSecurityCheck.exe"
  
SectionEnd

;--------------------------------

; Uninstaller

Section "Uninstall"
  
  ; Remove registry keys
  DeleteRegKey HKLM "Software\Microsoft\Windows\CurrentVersion\Uninstall\KeeSecurityCheck"

  ; Remove files and uninstaller
  Delete $INSTDIR\KeeSecurityCheck.dll
  Delete $INSTDIR\uninstallKeeSecurityCheck.exe


SectionEnd

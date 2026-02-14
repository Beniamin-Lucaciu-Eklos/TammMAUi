@ECHO OFF

PowerShell -NoExit -NoProfile -NoLogo -ExecutionPolicy unrestricted -Command "& '%~dp0TDevOps.Install.ps1' %*; exit $LASTEXITCODE"

exit /b %ERRORLEVEL%
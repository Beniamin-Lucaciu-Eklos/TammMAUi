@ECHO OFF
SETLOCAL

if [%1] == [] (
    SET command="Invoke-Expression \"Import-Module TDevOpsLibrary; Invoke-DevOpsMenu\"; exit $LASTEXITCODE"
) else (
    SET command="Invoke-Expression \"Import-Module TDevOpsLibrary; Invoke-DevOps %*\"; exit $LASTEXITCODE"
)

PowerShell -NoProfile -NoLogo -ExecutionPolicy unrestricted -Command %command% 

ENDLOCAL
exit /b %ERRORLEVEL%
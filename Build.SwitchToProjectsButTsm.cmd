@ECHO OFF
SETLOCAL

SET profileArg="-ProfileName AllProjectsButTsm"
SET configArg="-ConfigurationJsonFile '%~dp0TDevOps.Config.json'"
SET tasksArg="-Tasks Clean, SwitchReferences, Restore"
set buildArgs=%tasksArg% %profileArg% %configArg% %*

call Build.cmd %buildArgs%

ENDLOCAL
pause
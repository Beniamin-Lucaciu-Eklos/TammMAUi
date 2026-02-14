@ECHO OFF
SETLOCAL

SET profileArg="-ProfileName DefaultProjects"
SET configArg="-ConfigurationJsonFile '%~dp0TDevOps.Config.json'"
SET tasksArg="-Tasks Clean"
set buildArgs=%tasksArg% %profileArg% %configArg%

call Build.cmd %buildArgs%

@echo off
@echo Deleting all Bin and Obj folders…
for /d /r . %%d in (bin,obj) do @if exist “%%d” rd /s/q “%%d”
@echo BIN and OBJ folders successfully deleted :) Close the window.

ENDLOCAL
pause > nul
function Restart ($AllParameters, $Admin) {
    
    $AllParametersAsString = [string]::Empty

    ForEach ($Parameter in $AllParameters.GetEnumerator()) {
        $ParameterKey = $Parameter.Key
        $ParameterValue = $Parameter.Value
        $ParameterValueType = $ParameterValue.GetType().Name

        If ($ParameterValueType -Eq "SwitchParameter") {
            $AllParametersAsString += " -$ParameterKey"
        }
        else {
            $AllParametersAsString += " -$ParameterKey $ParameterValue"
        }
    }

    $arguments = "-File `"" + $PSCommandPath + "`" -NoExit " + $AllParametersAsString

    If ($Admin -Eq $True) {
        Start-Process PowerShell -Verb Runas -ArgumentList $arguments
    }
    Else {        
        Start-Process PowerShell -ArgumentList $arguments
    }
}

function RestartAsAdministratorIfNeeded() {
    $ranAsAdministrator = ([Security.Principal.WindowsPrincipal] [Security.Principal.WindowsIdentity]::GetCurrent()).IsInRole([Security.Principal.WindowsBuiltInRole]::Administrator);

    if (-not $ranAsAdministrator) {
        Restart $PsBoundParameters -Admin $True;
        return $true
    }

    return $false
}

function EnsureNugetRepository() {
    $sourceLocation = "https://nuget.terranovasoftware.eu/nuget/"

    $repository = Get-PSRepository | Where-Object { $_.SourceLocation -eq $sourceLocation }

    if ($null -eq $repository) {
        $scriptSourceLocation = "https://nuget.twsfi.local/nuget"
        $publishLocation = "https://nuget.twsfi.local/nuget"
    
        Register-PSRepository -Name $repositoryName -SourceLocation $sourceLocation -ScriptSourceLocation $scriptSourceLocation -PublishLocation $publishLocation -PackageManagementProvider NuGet -InstallationPolicy Trusted
        if (!$?) {
            throw "Cannot register $sourceLocation"
        }
    }
}

function InstallOrUpdateModule() {

    $installedVersion = (Get-Module -ListAvailable $moduleName) | Sort-Object Version -Descending  | Select-Object Version -First 1

    if ($null -eq $installedVersion) {
        Find-Module -Name $moduleName -Repository $repositoryName | Install-Module -Scope CurrentUser

        if ($null -eq (Get-Module -ListAvailable $moduleName)) {
            throw "Cannot install $moduleName from $repositoryName"
        }

        return
    }

    $lastAvailableVersion = Find-Module -Name $moduleName | Sort-Object Version -Descending | Select-Object Version -First 1

    if ($lastAvailableVersion.Version -gt $installedVersion.Version) {
        Get-InstalledModule -Name $moduleName | Uninstall-Module
        Find-Module -Name $moduleName -Repository $repositoryName | Install-Module -Scope CurrentUser
        if (!$?) {
            throw "Cannot update $moduleName from $repositoryName"
        }
    }
}

$moduleName = "TDevOpsLibrary"

Write-Verbose "Checking $moduleName installation..." -Verbose

# if (RestartAsAdministratorIfNeeded) {
#     exit
# }

$repositoryName = "TerranovaNuGetRepository"

EnsureNugetRepository
if (!$?) {
    throw $Error[0].Exception
}

InstallOrUpdateModule
if (!$?) {
    throw $Error[0].Exception
}

Write-Verbose "Installation done" -Verbose
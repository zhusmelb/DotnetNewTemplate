$ScriptPath = Split-Path -Path $MyInvocation.MyCommand.Path
$NuGetExePath = Join-Path -Path $ScriptPath "nuget.exe"

Invoke-WebRequest -Uri https://dist.nuget.org/win-x86-commandline/v4.8.1/nuget.exe -OutFile $NuGetExePath

& $NuGetExePath pack ./src/ZhusTemplate.nuspec

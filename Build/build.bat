@echo Off

set slnDir=Saturn72.UnitTesting.Framework
set srcDir=src
set slnName=%srcDir%\Saturn72.UnitTesting.Framework.sln
set prjName=%src%\%slnDir%\Saturn72.UnitTesting.Framework.csproj
  
set config=%1
if "%config%" == "" (
   set config=Release
)

set version=
if not "%PackageVersion%" == "" (
   set version=-Version %PackageVersion%
)

REM Restore nuget packages
echo restore nuget packages to %cd%\%srcDir%\packages directory
call %NuGet% restore -OutputDirectory %cd%\packages -NonInteractive

REM Build
echo Start building %slnName%
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" %slnName% /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

REM Package
mkdir Build
echo Packging %prjName% project to Build directory
call %NuGet% pack %prjName% -symbols -o Build -p Configuration=%config% %version%
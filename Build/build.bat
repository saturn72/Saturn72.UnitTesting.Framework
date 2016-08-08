@echo Off

set srcDir=src
set slnName=%srcDir%\Saturn72.UnitTesting.Framework.sln
set prjDir=%src%\Saturn72.UnitTesting.Framework
set prjName=%prjDir%\Saturn72.UnitTesting.Framework.csproj
  
set config=%1
if "%config%" == "" (
   set config=Release
)

set version=
if not "%PackageVersion%" == "" (
   set version=-Version %PackageVersion%
)

REM Restore nuget packages
set %pkgDir%=%cd%\%srcDir%\packages
echo restore nuget packages to %pkgDir% directory
call %NuGet% restore %slnName% -OutputDirectory %pkgDir% -NonInteractive

REM Build
echo Start building %slnName%
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" %slnName% /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

REM Package
mkdir Build
echo Packging %prjName% project to Build directory
call %NuGet% pack %prjName% -symbols -o Build -p Configuration=%config% %version%
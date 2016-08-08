@echo Off

set slnDir=Saturn72.UnitTesting.Framework
set slnName=%slnDir%\Saturn72.UnitTesting.Framework.sln
set prjName=%slnDir%\Saturn72.UnitTesting.Framework.csproj
 
set config=%1
if "%config%" == "" (
   set config=Release
)

set version=
if not "%PackageVersion%" == "" (
   set version=-Version %PackageVersion%
)

REM Restore nuget packages
%NuGet% restore -OutputDirectory %cd%\packages -NonInteractive

REM Build
echo Start building %slnName%
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" %slnName% /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

REM Package
mkdir Build
echo Packging %prjName% project to Build directory
call %nuget% pack %prjName% -symbols -o Build -p Configuration=%config% %version%
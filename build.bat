@echo Off

set slnDir = "Saturn72.UnitTesting.Framework"
set slnName = "Saturn72.UnitTesting.Framework.sln"
set prjName = "Saturn72.UnitTesting.Framework.csproj"

set config=%1
if "%config%" == "" (
   set config=Release
)

set version=
if not "%PackageVersion%" == "" (
   set version=-Version %PackageVersion%
)

REM Build
"%programfiles(x86)%\MSBuild\14.0\Bin\MSBuild.exe" %sknName% /p:Configuration="%config%" /m /v:M /fl /flp:LogFile=msbuild.log;Verbosity=Normal /nr:false

REM Package
mkdir Build
call %nuget% pack "%slnDir%\%prjName%" -symbols -o Build -p Configuration=%config% %version%
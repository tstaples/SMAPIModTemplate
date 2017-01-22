echo off
setlocal

:: set GacutilPath=C:\Program Files (x86)\Microsoft SDKs\Windows\v7.0A\Bin\gacutil.exe
:: set WizardDLL=C:\Users\Tyler\Documents\project templates\SMAPI Mod Template manual\SMAPIModTemplate\ModTemplateInstallWizard\bin\Debug\ModTemplateInstallWizard.dll
::echo Installing wizard dll into global assembly cache
::"%GacutilPath%" /i "%WizardDLL"

set TestProjectPath=C:\Users\Tyler\Documents\Visual Studio 2015\Projects\TylerMod
if exist "%TestProjectPath%" (
	echo Removing test project dir: %TestProjectPath%
	rmdir /s /q "%TestProjectPath%"
)

set TemplateFilesPath=C:\Users\Tyler\Documents\GitHub\SMAPIModTemplate\GeneratedTemplateFiles
set TemplateOutputPath=C:\Users\Tyler\Documents\Visual Studio 2015\Templates\ProjectTemplates\SMAPIModTemplate.zip

if exist "%TemplateOutputPath%" (
	echo Removing old template zip from %TemplateOutputPath%
	del /q "%TemplateOutputPath%"
)

winrar a -afzip -r -ep1 "%TemplateOutputPath%" "%TemplateFilesPath%\*"
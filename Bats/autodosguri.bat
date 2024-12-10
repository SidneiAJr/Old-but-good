@echo off
:MENU
cls
echo *************************************
echo *     MENU DE OPÇÕES DO NOTEPAD    *
echo *************************************
echo.
echo 1. Abrir o Notepad
echo 2. Abrir Firefox
echo 3. Abrir ferramenta de captura
echo 4. Abrir painel de controle
echo 5. Sair
echo.
set /p opcao=Escolha uma opcao (1, 2 ou 3): 

if "%opcao%"=="1" goto abrir_notepad
if "%opcao%"=="2" goto abrir_firefox
if "%opcao%"=="3" goto abrir_ferrawindowscapture
if "%opcao%" =="4" goto abrir_control
if "%opcao%"=="5" exit

:abrir_notepad
start notepad.exe
goto MENU
:abrir_firefox
start firefox.exe
goto MENU
:abrir_ferrawindowscapture
start SnippingTool.exe
goto MENU
:abrir_control
start control
goto MENU



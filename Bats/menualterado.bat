@echo off
:MENU
cls
echo *************************************
echo ===============MENU==================
echo *************************************
echo.
color 4f
echo 1. Abrir o Notepad
echo 2. Abrir Firefox
echo 3. Abrir ferramenta de captura
echo 4. Abrir painel de controle
echo 5. Abrir explorer do windows
echo 6. Abrir gerenciador de tarefas
echo 7. Sair 
set /p opcao=Escolha uma opcao:

if "%opcao%"=="1" goto abrir_notepad
if "%opcao%"=="2" goto abrir_firefox
if "%opcao%"=="3" goto abrir_ferrawindowscapture
if "%opcao%" =="4" goto abrir_control
if "%opcao%" =="5" goto abrir_explorer
if "%opcao%" =="6" goto abrir_gerenciador
if "%opcao%"=="7" exit


:abrir_notepad
start notepad.exe
echo abrindo Bloco de notas Aguarde!
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
:abrir_explorer
start explorer.exe
goto MENU
:abrir_gerenciador
start taskmgr.exe
goto MENU

@echo off
:MENU
cls
echo *************************************
echo *     MENU DE OPÇÕES DO NOTEPAD    *
echo *************************************
echo.
echo 1. Abrir o Notepad vazio
echo 2. Abrir o Notepad com um arquivo específico
echo 3. Sair
echo.
set /p opcao=Escolha uma opcao (1, 2 ou 3): 

if "%opcao%"=="1" goto ABRIR_NOTEPAD_VAZIO
if "%opcao%"=="2" goto ABRIR_NOTEPAD_ARQUIVO
if "%opcao%"=="3" exit

:ABRIR_NOTEPAD_VAZIO
start notepad.exe
goto MENU

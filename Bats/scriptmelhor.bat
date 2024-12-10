@echo off
title Menu Interativo

:MENU
cls
echo ===========================
echo       MENU PRINCIPAL
echo ===========================
echo 1. Abrir Notepad
echo 2. Sair
echo ===========================
set /p option=Escolha uma opcao (1-4):

if "%option%"=="1" goto abrirnotepad
if "%option%"=="2" goto abrirnavegador
if "%option%"=="3" goto 
if "%option%"=="4" exit

goto MENU

:abrirnotepad
start notepad.exe
pause
goto MENU
:abrirnavegador
start firefox.exe
pause
goto MENU

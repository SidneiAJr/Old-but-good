#!/bin/bash

# Função para exibir o menu
mostrar_menu() {
    clear
    echo "===================================="
    echo "       MENU DE OPÇÕES"
    echo "===================================="
    echo "1) Instalar HTOP"
    echo "2) Instalar VIM"
    echo "3) Mostrar espaço livre em disco"
    echo "4) Sair"
    echo "===================================="
    echo -n "Escolha uma opção [1-4]: "
}

# Função 1: Exibir data e hora
Instalar HTOP() {
    echo "Instalar HTOP"
    sudo apt install htop -y
    pause
}

# Função 2: Listar arquivos no diretório atual
Instalar VIM() {
    echo "Instalar Vim"
    sudo apt install vim -y
    pause
}

# Função 3: Mostrar espaço livre em disco
mostrar_espaco_disco() {
    echo "Espaço livre no disco:"
    df -h
    pause
}
Limpeza de disco(){
     echo "Limpeza de Disco"
     sudo apt autoremove -y
     pause
}
Atualização com APT-Upgrade(){
   echo "Atualizar Sistema operacional"
   sudo apt update -y
   pause
}
Atualização com APT-Update(){
   echo "Atualizar Sistema operacional"
   sudo apt upgrade -y
   pause
}
Atualização de Distro(){
   echo "Atualizar Distro"
   sudo apt dist-update -y
   pause
}
# Função para pausar a execução e voltar ao menu
pause() {
    read -p "Pressione [Enter] para continuar..."
}

# Loop principal
while true; do
    mostrar_menu
    read opcao
    case $opcao in
        1) Instalar HTOP ;;
        2) Instalar VIM ;;
        3) mostrar_espaco_disco ;;
        4)Limpeza de disco;;
        5)Atualização com APT-Upgrade;;
        6)Atualização com APT-Update;;
        7)Atualização de Distro;;
        8) echo "Saindo..."; exit 0 ;;
        *) echo "Opção inválida. Tente novamente."; pause ;;
    esac
done

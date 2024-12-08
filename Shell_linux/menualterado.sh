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
    echo "4) Limpeza com Autoremove"
    echo "5) Atualização com Update"
    echo "6) Atualização com Upgrade"
    echo "7) Atualização de distro com dist-upgrade"
    echo "8) Sair"
    echo "===================================="
    echo -n "Escolha uma opção [1-8]: "
}

# Função 1: Exibir data e hora
instalar_htop() {
    echo "Instalar HTOP"
    sudo apt install htop -y
    pause
}

# Função 2: Listar arquivos no diretório atual
instalar_vim() {
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
limpeza_de_disco(){
     echo "Limpeza de Disco"
     sudo apt autoremove -y
     pause
}
atualização_com_apt(){
    echo "Atualizar Sistema operacional"
    sudo apt update -y
    pause
}
limpa_distro(){
    echo "Limpa Sistema"
    sudo apt clean -y
    pause
}
chama_firefox(){
    echo "Chama O firefox"
    firefox
    pause
}
verifica_os(){
    echo "Roda o Neofetch"
    neofetch
    pause
}
verifica_os(){
    echo "Roda o Neofetch"
    neofetch
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
        1) instalar_htop ;;
        2) instalar_vim ;;
        3) mostrar_espaco_disco ;;
        4) limpeza_de_disco;;
        5) atualização_com_apt;;
        7) atualizacao_distro;;
        8) limpa_distro;;
        9) chama_firefox;;
        10)verifica_os;;
        11) echo "Saindo..."; exit 0 ;;
        *) echo "Opção inválida. Tente novamente."; pause ;;
    esac
done

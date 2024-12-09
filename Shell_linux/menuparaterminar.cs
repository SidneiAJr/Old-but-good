#!/bin/bash

# Função para exibir o menu
mostrar_menu() {
    clear
    echo "************************************"
    echo "++++++Menu De Automatização++++++++++"
    echo "===================================="
    echo "1) Verificar Atualizações"
    echo "2) Listar arquivos no diretório atual"
    echo "3) Mostrar espaço livre em disco"
    echo "4) Sair"
    echo "===================================="
    echo -n "Escolha uma opção [1-4]: "
}

# Função 1: Exibir data e hora
verifica_atualiza() {
    echo "Verifica Atualização com Apt-Upgrade & Apt Update"
    sudo apt upgrade & sudo apt update
    pause
}

# Função 3: Mostrar espaço livre em disco
mostrar_espaco_disco() {
    echo "Espaço livre no disco:"
    df -h
    pause
}
# Roda comando Neofetch
verifica_Os_neofetch(){
    echo "Roda neofetch"
    neofetch
}
abrehtop(){
    echo" o htop"
    htop
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
        1) verifica_atualiza ;;
        2) mostrar_espaco_disco ;;
        3) verifica_Os_neofetch ;;
        4) echo "Saindo..."; exit 0 ;;
        *) echo "Opção inválida. Tente novamente."; pause ;;
    esac
done

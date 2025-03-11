#!/bin/bash
mostrar_menu(){
clear
echo " #   #    #     ######     ##     ##   ##  #####    #######  ##   ##  #######   #####     ## #"
echo " #   #    #      ##  ##   ####    ##   ##   ## ##    ##   #  ### ###   ##   #  ##   ##   #### #"
echo " #  ##  ##    ##  ##  ##  ##   ##   ##   ##  ##   ## #    #######   ## #    #        ##  ## #"
echo " #  ##  ##    #####   ##  ##   ##   ##   ##  ##   ####    #######   ####     #####   ##  ## #"
echo " #  ##  ##    ## ##   ######   ##   ##   ##  ##   ## #    ## # ##   ## #         ##  ###### #"
echo " #   ####     ##  ##  ##  ##   ##   ##   ## ##    ##   #  ##   ##   ##   #  ##   ##  ##  ## #"
echo " #    ##     #### ##  ##  ##    #####   #####    #######  ##   ##  #######   #####   ##  ## #"


echo "1-Atualizar Linux"
echo "2-Limpar Linux"
echo "3-Atualizar Distro"
}
atualizar_1(){
 echo "Realizando ATUALIZAÇÃO"
 sudo apt update -y
}
atualizar_2(){
 echo "Realizando Limpeza......"
 sudo apt autoremove -y
}
atualizar_3(){
  echo "Atualização da Distro"
  sudo apt dist-upgrade -y
}
while true; do
mostrar_menu
read opcao
case $opcao in
1)atualizar_1;;
2)atualizar_2;;
3)atualizar_3;;
4)echo "Saindo.."; exit 0;;
*)echo "Malandro?"
esac
done

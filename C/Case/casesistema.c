#include <stdio.h>
#include <stdlib.h>
int main () {
  printf("Menu de Compras!\n");
   int valorIni=0.0;
   float valorCred=0.0;
   float valorCrediario=0.0;    
   
   printf("Digite uma opção");
   scanf("%f",&valorIni);
  
   
   switch(valorIni){
            case 1:
            valorIni*0.01;
            printf("O Valor no Debito será:");
            break; 
            case 2:
            valorIni*0.20;
            printf("O Valor no Credito será:");
            break;
            case 3:
            valorIni*0.40;
            printf("O Valor no Crediario");
            break; 
            default:
            printf("Opção Invalida!");
            break;
   }
   
  
   
   
   
   
}

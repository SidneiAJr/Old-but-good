#include <stdio.h>
#include <stdlib.h>
int main () {
   printf("Case em C!\n ");
   int n1=0.0;
 
   
   printf("Digite um mes em numero:");
   scanf("%d",&n1);
   
   switch(n1){
            case 1:
            printf("O mes é Janeiro");
            break;
            case 2:
             printf("O mes é Fev");
            break;
            case 3:
             printf("O mes é Março");
            break;
             case 4:
            printf("O mes é Abril");
            break;
             case 5:
            printf("O mes é Maio");
            break;
             case 6:
            printf("O mes é Jun");
            break;
             case 7:
            printf("O mes é Jul");
            break;
             case 8:
            printf("O mes é Ago");
            break;
             case 9:
            printf("O mes é Set");
            break;
             case 10:
            printf("O mes é Out");
            break;
             case 11:
            printf("O mes é Nov");
            break;
             case 12:
            printf("O mes é Dez");
            break;
            default:
            printf("Mes Invalido");
            break;
   }
   
   
   
   
   
   
}

#include <stdio.h>
#include <stdlib.h>
#include <math.h>
int main () {
   printf("Case em C!\n ");
   int n1=0.0;


   printf("Digite um mes em numero:");
   scanf("%d",&n1);

   void calc()
   {
       float rend,res,valorini;
       printf("===Bem vindo a calculadora\n===");
       printf("Digite o valor do rendimento:");
       scanf("%f",&rend);
       printf("Digite o valor o inicial da aplicacao:");
       scanf("%f",&valorini);
       res = (rend*100)/valorini;
       printf("%fO Valor Inicial",res);
   }
   void calc_rf()
   {
       double valorInicial, valorFuturo, juros,jurosdiv,tempo;
       printf("===Bem vindo a calculadora===\n");
       printf("Digite o valor que deseja Investir:\n");
       scanf("%lf",&valorInicial);
       printf("Digite o tempo que deseja investir:\n");
       scanf("%lf",&tempo);
       printf("Digite o juros do cupom:\n");
       scanf("%lf",&juros);
       jurosdiv = juros/100;
       valorFuturo = valorInicial * pow(1 + jurosdiv, tempo);
       printf("O Valor total sera: %.2lf\n", valorFuturo);
   }

   switch(n1){
            case 1:
            calc();
            break;
            case 2:
            calc_rf();
            break;
            default:
            printf("Opcao Invalida");
            break;
   }






}

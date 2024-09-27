#include <stdio.h>
#include <stdlib.h>
int main () {
   
   double pago=0.0;
   int quantparcela=0.0;
   int res=0.0;
   float jus=0.0;
   
   printf("Quantidade de Parcelas");
   scanf("%d\n",&quantparcela);
   printf("Valor pago:");
   scanf("%d",&pago);
   
   res=pago*quantparcela;
   printf("%d\n O valor pago será",res);
   jus=res*1.45;
   printf("%f O Valor no crediario será:",jus);
   
   
}

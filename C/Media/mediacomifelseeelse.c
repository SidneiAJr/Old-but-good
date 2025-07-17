#include <stdio.h>
#include <stdlib.h>
int main () {
   printf("Programa pra media de aluno em C/:\n ");
   float n1=0.0;
   float n2=0.0;
   float n3=0.0;
   float media=0.0;
   
   printf("Digite a primeira nota:");
   scanf("%f",&n1);
   printf("Digite a segunda nota:");
   scanf("%f",&n2);
   printf("Digite a terceira nota:");
   scanf("%f",&n3);
   
   media=(n1+n2+n3)/3;
   printf("%f Sua media é\n",media);
   
   if(media>5){
       printf("Aluno Aprovado");
   }else if(media<4){
   printf("Aluno em Recuperação");
   }else{
    printf("Aluno reprovado");   
   }
   
   
   
   
}

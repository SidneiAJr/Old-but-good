#include <stdio.h>
#include <stdlib.h>
int main () {
   printf("Programa pra media de aluno em C");
   float v1=0.0;
   float v2=0.0;
   float v3=0.0;
   float resultado=0.0;
   float resultado2=0.0;
   float resultado3=0.0;
   float resultado4=0.0;
   float resultado5=0.0;
   float resultado6=0.0;
   float resultado7=0.0;
   float resultado8=0.0;
   float resultado9=0.0;
   
   
   printf("Digite a primeira nota");
   scanf("%f\n",&v1);
   printf("Digite a segunda nota");
   scanf("%f\n",&v2);
   printf("Digite a terceira nota");
   scanf("%f\n",&v3);
   
   resultado=v1+v2+v3;
   resultado2=v1+v2;
   resultado3=v3+v2/v1;
   resultado4=v1-v3/v2;
   resultado5=v3*v2;
   resultado6=resultado5+200;
   resultado7=resultado+100;
   resultado8=resultado+200;
   resultado9=resultado+300;
   
   if(resultado==5){
      printf("%f E:",resultado7);
   }else
   printf("%f E",resultado7);
   
   printf("%f Sua media é",resultado);
   printf("%f Sua media é",resultado2);
   printf("%f Sua media é",resultado3);
   printf("%f Sua media é",resultado4);
   printf("%f Sua media é",resultado5);
   printf("%f Sua media é",resultado6);
   printf("%f Sua media é",resultado7);
   printf("%f Sua media é",resultado7);
   printf("%f Sua media é",resultado7);
   printf("%f Sua media é",resultado8);
   printf("%f Sua media é",resultado9);
  
   
   
   
}

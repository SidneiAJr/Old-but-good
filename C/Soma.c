#include <stdio.h>
double teste();

int main(){
    int n1 = 5;
    int n2 = 5;
    int n3 = 5;
    int soma = n1+n2+n3;
    printf("Soma será: %d \n",soma);
    double res = teste();
    printf("Soma será: %f \n",res);
    return 0;
}

double teste(){
    double n4 = 5.5;
    double n5 = 5.5;
    double n6 = 5.5;
    double n7 = 5.5;
    double somadou = n4+n5+n6+n7;
    return somadou;
}

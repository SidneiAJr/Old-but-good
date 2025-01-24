// Online C compiler to run C program online
#include <stdio.h>

int main() {
    // Write C code here
    printf("Digite um numero");
    int n1;
    scanf("%i",&n1);
    
    printf("A tabuada do numero %i é:\n",n1);
    for(int i=0; i<=10; i++){
        printf("%i x %i = %i\n", n1,i,n1*i);
    }

    
}

#include <iostream>

using namespace std;
int main(){
    int nota1;
    int nota2;
    int nota3;
    int resultado;
    
    cout <<"Digite a Nota 1:";
    cin >> nota1;
    cout <<"Digite a Nota 2:";
    cin >> nota2;
    cout <<"Digite a nota 3:";
    cin >> nota3;
    resultado=(nota1+nota2+nota3)/3;
    cout << "Resultado E: " <<   resultado;
    if(resultado>5){
        cout << "Aluno Aprovado!!";
    }else{
        cout << "Aluno Reprovado!!";
    }
    return 0;

   
    
    }

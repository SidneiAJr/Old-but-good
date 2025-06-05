#include <iostream>
using namespace std;
void medianota();
void conversoridade();
void test();

int main() {
    int op;
    cout << "Digite uma opção: \n";
    cout << "1 - Calcular média: \n";
    cout << "2 - Calcular idade: \n";
    cout << "3 - Operações Matematicas: \n";
    cin >> op;  // Corrigindo a captura de entrada
    switch(op){
        case 1:
        medianota();
        break;
        case 2:
        conversoridade();
        break;
        case 3:
        test();
        break;
        default:
        cout <<"Insira uma opção correta!!";
        break;
    }
    return 0;
}
void medianota(){
    double n1,n2,n3;
    cout <<"Digite a Nota 1:";
    cin >> n1;
    cout <<"Digite a Nota 1:";
    cin >> n2;
    cout <<"Digite a Nota 1:";
    cin >> n3;
    double resultado=(n1+n2+n3)/3;
    cout << "O resultado da média é: " << resultado << endl;
}
void conversoridade(){
    int idadehumano,idadetotal;
    int idadedog = 7;
    cout <<"Digite a idade Humana";
    cin >> idadehumano;
    idadetotal = idadehumano*idadedog;
    cout << "A idade do dog será " << idadetotal;
}
void test(){
    double soma,mult,divisao,subtra,num1,num2;
    cout <<"Insira um numero: ";
    cin >> num1;
    cout <<"Insira um numero: ";
    cin >> num2;
    soma = num1+num2;
    mult = num1*num2;
    divisao= num1/num2;
    subtra = num1-num2;
    cout << "Soma: " << soma << endl;
    cout << "Multiplicação: " << mult << endl;
    cout << "Divisão:  " << divisao << endl;
    cout << "Subtração:  " << subtra << endl;
}

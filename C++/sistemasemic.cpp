#include <iostream>
using namespace std;
void medianota();

int main() {
    int op;
    cout << "Digite uma opção: \n";
    cout << "1 - Calcular média \n";
    cout << "2 - Calcular idade \n";
    cin >> op;  // Corrigindo a captura de entrada
    switch(op){
        case 1:
        medianota();
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
    cout << "O resultado da média é: " << resultado << endl;
    double resultado=(n1+n2+n3)/3;
}

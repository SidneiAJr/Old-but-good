#include <iostream>
using namespace std;
void medianota();
void conversoridade();

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
        case 2:
        conversoridade();
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

#include <iostream>
#include <vector>

int main() {
    // Criando vetores
    std::vector<int> matriz1 = {1, 2, 3, 4, 5};
    std::vector<int> matriz2 = {1, 2, 3, 4, 5};
    std::vector<int> matrizSoma(5);  // Vetor de resultado, com 5 elementos

    // Somando as matrizes
    for (int i = 0; i < matriz1.size(); i++) {
        matrizSoma[i] = matriz1[i] + matriz2[i];
    }

    // Exibindo o resultado
    std::cout << "Resultado da soma das matrizes: ";
    for (int i = 0; i < matrizSoma.size(); i++) {
        std::cout << matrizSoma[i] << " ";
    }

    return 0;
}

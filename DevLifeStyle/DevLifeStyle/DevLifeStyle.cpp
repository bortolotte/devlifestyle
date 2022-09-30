// isto é um comentário de uma linha

#include <iostream>
using namespace std;

/* este é um comentário
 de muitas
 linhas
*/

int main() // função principal
{
    // entry point
    int numero1;    // declaração de variável do tipo inteiro (integer)
    int numero2;
    int resultado;
    string nome1;    // declaração de variável do tipo text (string)
    cout << "Programa de soma de 2 numeros.\n\n";

    cout << "Informe seu nome: ";
    cin >> nome1;

    cout << "Digite o primeiro numero: ";
    cin >> numero1;
    
    cout << "Digite o segundo numero: ";
    cin >> numero2;

    resultado = numero1 + numero2;   // atribuição
    // operadores aritméticos + - / *
    cout << "O resultado da soma eh: " << resultado << "\n";

    std::cout << "Obrigado, " << nome1 << "!";
}

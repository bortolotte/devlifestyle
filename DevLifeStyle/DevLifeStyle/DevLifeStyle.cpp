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
    
    // variáveis de tipo inteiro
    int numero1 = 66000;    // declaração de variável do tipo inteiro (integer)
    int numero2;
    int opcao;
    long int long1 = 2500000; // 2 * int
    long long int ll1 = 2500000000000000000; // 4 * int
    int resultado = 3;  // declaração de inteiro com inicialização

    bool b = true; // boolean - verdadeiro ou falso

    // variáveis de tipo texto / caractere
    char c1 = 'b';
    string nome1 = "ab";    // declaração de variável do tipo text (string)

    // variáveis de tipo 'ponto flutuante' ou números reais ou decimais
    float f1 = 292341.0;
    double d1 = 28912732198371344.7123;

    // void
    //void v1;  // inválido. não declaramos variáveis void

    cout << "Programa de operacoes aritmeticas entre 2 numeros.\n\n";

    cout << "Digite o primeiro numero: ";
    cin >> numero1;
    
    cout << "Digite o segundo numero: ";
    cin >> numero2;

    if (numero1 > 0 && numero2 > 0) // operador lógico 'E'
        cout << "Ambos positivos" << "\n";
    else if (numero1 < 0 || numero2 < 0) // operador lógico 'OU'
        cout << "Pelo menos um deles eh negativo" << endl;

    printf("Escolha a operacao (1 - soma, 2 - subtracao, 3 - multiplicacao, 4 - divisao): ");
    scanf_s("%d", &opcao);

    if (opcao == 1) // teste da condição
    {
        resultado = numero1 + numero2;   // atribuição
    }
    else if (opcao == 2)
        resultado = numero1 - numero2;
    else if (opcao == 3)
        resultado = numero1 * numero2;
    else if (opcao == 4)
        resultado = numero1 / numero2;

    // operadores lógicos: ==, !=, <, >, <=, >=

    if (resultado < 0)
    {   // início de um bloco de instruções ou escopo
        cout << "O resultado foi negativo";
        cout << "Verifique os valores de entrada";
    }   // término de um bloco de instruções ou escopo

    // operadores aritméticos + - / *
    cout << "O resultado da operacao eh: " << resultado << "\n";
}

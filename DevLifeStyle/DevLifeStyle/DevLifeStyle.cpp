// isto é um comentário de uma linha

#include <iostream>
using namespace std;

/* este é um comentário
 de muitas
 linhas
*/

class Operacao
{
public:
    int operandoA;
    int operandoB;
    int operador;
    int resultado;

    int calcula()
    {
        switch (operador)
        {
        case 1:
            this->resultado = operandoA + operandoB;
            break;
        case 2:
            this->resultado = operandoA - operandoB;
            break;
        case 3:
            this->resultado = operandoA * operandoB;
            break;
        case 4:
            this->resultado = operandoA / operandoB;
            break;
        default:
            this->resultado = 0;
        }
        return this->resultado;
    }

    void imprimeResultado()
    {
        cout << "O resultado da operacao eh: " << this->resultado << "\n";
        // return; desnecessário
    }
};

/*
* Esta função recebe a opção digitada pelo usuário
*/
int recebeOpcao()
{
    int opcao;
    printf("Escolha a operacao (1 - soma, 2 - subtracao, 3 - multiplicacao, 4 - divisao, 5 - sair): ");
    scanf_s("%d", &opcao);
    return opcao;
}

int recebeNumero(string texto)
{
    int num;
    cout << "Digite o " << texto << " numero: ";
    cin >> num;
    return num;
}
int recebePrimeiroNumero()
{
    return recebeNumero("primeiro");
}

int recebeSegundoNumero()
{
    return recebeNumero("segundo");
}

int main() // função principal
{
    cout << "Programa de operacoes aritmeticas entre 2 numeros.\n\n";

    int resultado;
    Operacao op;

    while (true)
    {
        // aquisição
        op.operador = recebeOpcao();
        if (op.operador == 5)
            break;
        op.operandoA = recebePrimeiroNumero();
        op.operandoB = recebeSegundoNumero();
        if (op.operandoA > 0 && op.operandoB > 0) // operador lógico 'E'
            cout << "Ambos positivos" << "\n";
        else if (op.operandoA < 0 || op.operandoB < 0) // operador lógico 'OU'
            cout << "Pelo menos um deles eh negativo" << endl;

#pragma region ifelse
        // operadores lógicos ==, !=, <, >, <=, >=, &&, ||
        /*if (opcao == 1) // teste da condição
            resultado = numero1 + numero2;   // atribuição
        else if (opcao == 2)
            resultado = numero1 - numero2;
        else if (opcao == 3)
            resultado = numero1 * numero2;
        else if (opcao == 4)
            resultado = numero1 / numero2;
        else
            resultado = 0;*/
#pragma endregion 
        resultado = op.calcula();

        // operadores lógicos: ==, !=, <, >, <=, >=

        if (resultado < 0)
        {   // início de um bloco de instruções ou escopo
            cout << "O resultado foi negativo";
            cout << "Verifique os valores de entrada";
        }   // término de um bloco de instruções ou escopo

        // operadores aritméticos + - / *
        op.imprimeResultado();
    }
}

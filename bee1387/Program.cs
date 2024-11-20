// Og é um homem das cavernas com vários filhos e filhas, e ele quer contar todos eles. Og conta seus filhos com sua mão esquerda e suas filhas com sua mão direita.

// Entretanto, Og não é inteligente, e não sabe somar os dois números. Assim, ele pediu para você escrever um programa que realize a soma.

// Entrada
// A entrada contém vários casos de teste. Cada caso de teste consiste em uma linha contendo dois inteiros L e R, separados por um espaço, indicando o número de filhos e de filhas, respectivamente (1 ≤ L, R ≤ 5).

// O fim do arquivo de entrada é indicado por L = R = 0.

//Saída
//Para cada caso de teste, imprima uma linha contendo um inteiro indicando quantos filhos e filhas Og tem ao todo.


using System;
using System.Diagnostics;




class Program
{
    static void Main(string[] args)
    {
        while (true) 
        {
            // Ler dois inputs de uma vez so 
            string input = Console.ReadLine();

            string[] partes = input.Split(' ');


            int L = int.Parse(partes[0]);
            int R = int.Parse(partes[1]);

            if (CondicaoParada(L, R)) 
            {
                break;
            }

            //Calcular a soma
            Console.WriteLine(L + R);
        }
    }


    public static bool CondicaoParada(int L, int R)
    {
        return L == 0 && R == 0;
    }
}
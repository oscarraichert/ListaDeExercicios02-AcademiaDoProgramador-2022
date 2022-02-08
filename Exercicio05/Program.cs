/*Exercício 5:
• Faça um algoritmo que leia dois valores inteiros A e B, se os valores forem 
iguais deverá se somar os dois, caso contrário multiplique A por B.
Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma 
variável C e mostrar seu conteúdo na tela.*/

using System;

namespace Exercicio05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("\nValor A: ");
                int valorA = Convert.ToInt32(Console.ReadLine());

                Console.Write("Valor B: ");
                int valorB = Convert.ToInt32(Console.ReadLine());

                int valorC = 0;

                if (valorA == valorB)
                {
                    valorC = valorA + valorB;
                    Console.WriteLine($"\n{valorC}");
                }

                else if (valorA != valorB)
                {
                    valorC = valorA * valorB;
                    Console.WriteLine($"\n{valorC}");
                }
            }

        }
    }
}
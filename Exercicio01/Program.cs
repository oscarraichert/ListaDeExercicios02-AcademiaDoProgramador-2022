/*Exercício 1:
• Faça um algoritmo que leia os valores A, B, C e imprima na tela se a
soma de A + B é menor que C.*/

using System;

namespace Exercicio01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor A: ");
            double valorA = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor B: ");
            double valorB = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o valor C: ");
            double valorC = Convert.ToDouble(Console.ReadLine());

            double somaAB = valorA + valorB;

            if (somaAB > valorC)
            {
                Console.WriteLine($"A soma de A + B ({somaAB}) é maior que o valor C ({valorC})");
            }
            else Console.WriteLine($"A soma de A + B ({somaAB}) é menor que o valor C ({valorC})");
        }
    }
}

/*Exercício 4:
• Faça um algoritmo para receber um número qualquer e informar na tela se 
é par ou ímpar.*/

using System;

namespace Exercicio04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int resposta = numero % 2;

            if (resposta == 1)
            {
                Console.WriteLine("O número é ímpar.");
            }

            else Console.WriteLine("O número é par.");
        }
    }
}

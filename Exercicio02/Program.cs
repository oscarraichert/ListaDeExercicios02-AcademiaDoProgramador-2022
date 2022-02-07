/*Exercício 2:
• Escreva um algoritmo que leia três valores inteiros e diferentes e
mostre-os em ordem decrescente.*/

using System;

namespace Exercicio02
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

                Console.Write("Valor C: ");
                int valorC = Convert.ToInt32(Console.ReadLine());

                if (valorA == valorB || valorA == valorC || valorC == valorB)
                {
                    Console.WriteLine("\nOs Valores A, B e C devem ser diferentes.\nTente novamente.");
                    continue;
                }

                int maiorNumero = 0;

                if (valorA > valorB && valorA > valorC)
                {
                    maiorNumero = valorA;
                }
                else if (valorB > valorC && valorB > valorA)
                {
                    maiorNumero = valorB;
                }
                else if (valorC > valorA && valorC > valorB)
                {
                    maiorNumero = valorC;
                }

                int segundoNumero = 0;

                if (valorA < valorB && valorA > valorC || valorA < valorC && valorA > valorB)
                {
                    segundoNumero = valorA;
                }
                else if (valorB > valorC && valorB < valorA || valorB > valorA && valorB < valorC)
                {
                    segundoNumero = valorB;
                }
                else if (valorC > valorA && valorC < valorB || valorC > valorB && valorC < valorA)
                {
                    segundoNumero = valorC;
                }

                int terceiroNumero = 0;

                if (valorA < valorB && valorA < valorC)
                {
                    terceiroNumero = valorA;
                }
                else if (valorB < valorA && valorB < valorC)
                {
                    terceiroNumero = valorB;
                }
                else terceiroNumero = valorC;

                Console.WriteLine($"{maiorNumero}, {segundoNumero}, {terceiroNumero}.");
            }
        }
    }
}
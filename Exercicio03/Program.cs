/*Exercício 3:
• O IMC – Índice de Massa Corporal é um critério da Organização Mundial 
de Saúde para dar uma indicação sobre a condição de peso de uma pessoa 
adulta
• A fórmula é IMC = peso / (altura) ²
• Elabore um algoritmo que leia o peso e a altura de um adulto e mostre 
sua condição de acordo com a tabela abaixo.
IMC em adultos Condição
Abaixo de 18,5 Abaixo do peso
Entre 18,5 e 25 Peso normal
Entre 25 e 30 Acima do peso
Acima de 30 obeso*/

using System;

namespace Exercicio03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite seu peso (em Kgs): ");
            double peso = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite sua altura (em metros): ");
            double altura = Convert.ToDouble(Console.ReadLine());

            double imc = peso / (Math.Pow(altura, 2));

            if (imc <= 18.5)
            {
                Console.WriteLine($"Seu IMC é de {Math.Round(imc, 2)}, você está abaixo do peso.");
            }

            else if (imc > 18.5 && imc <= 25)
            {
                Console.WriteLine($"Seu IMC é de {Math.Round(imc, 2)}, você está com o peso normal.");
            }

            else if (imc > 25 && imc <= 30)
            {
                Console.WriteLine($"Seu IMC é de {Math.Round(imc, 2)}, você está com sobrepeso.");
            }

            else if (imc > 30)
            {
                Console.WriteLine($"Seu IMC é de {Math.Round(imc, 2)}, você está obeso.");
            }
        }
    }
}

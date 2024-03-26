using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace ExercicioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lista Exercicio de Arrays. Digite qualquer tecla para continuar...");
            Console.ReadLine();
            Console.Clear();

            int[] numeros = [-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6];

            // Mostrar na Tela os valores da sequência 
            SequenciaDeNumeros(numeros);

            // Encontrar o Maior Valor da sequência 
            MaiorNumeroArray(numeros);

            // Encontrar o Menor Valor da sequência
            MenorNumeroArray(numeros);

            // Encontrar o Valor Médio da sequência
            ValorMedioArray(numeros);

            // Encontrar os 3 maiores valores da sequência 
            TresMaioresValoresArray(numeros);

            // Encontrar os valores negativos da sequência
            ValoresNegativosArray(numeros);

            // Remover um item da sequência
            RemocaoNumero(numeros);

        }

        private static void SequenciaDeNumeros(int[] numeros)
        {
            Console.Write($"A sequência de numeros fornecida é de: ");
            foreach (int i in numeros)
                Console.Write(i + " ");
        }

        private static void MaiorNumeroArray(int[] numeros)
        {
            int maiorValor = int.MinValue;
            for (int i = 0; i < numeros.Length; i++)
            {
                int valorAtual = numeros[i];

                if (valorAtual > maiorValor)
                {
                    maiorValor = numeros[i];
                }
            }
            Console.WriteLine("\n\nMaior numero: " + maiorValor);
        }

        private static void MenorNumeroArray(int[] numeros)
        {
            int menorValor = int.MaxValue;

            for (int i = 0; i < numeros.Length; i++)
            {
                int valorAtual = numeros[i];

                if (valorAtual < menorValor)
                    menorValor = valorAtual;
            }
            Console.WriteLine("\nMenor numero : " + menorValor);
        }

        private static void ValorMedioArray(int[] numeros)
        {
            decimal soma = 0;

            foreach (int valor in numeros)
                soma += valor;

            decimal resultado = soma / numeros.Length;

            Console.WriteLine($"\nValor medio: " + resultado);
        }

        private static void TresMaioresValoresArray(int[] numeros)
        {
            int[] copia = new int[numeros.Length];

            Array.Copy(numeros, copia, numeros.Length);

            Array.Sort(copia);

            Array.Reverse(copia);

            Console.WriteLine($"\nOs 3 maiores valores são: [{copia[0]} {copia[1]} {copia[2]}]");
        }

        private static void ValoresNegativosArray(int[] numeros)
        {
            Console.WriteLine("\nOs valores negativos da numeros são respectivamente:");
            foreach (int valorNegativo in numeros)
                if (valorNegativo < 0)
                    Console.WriteLine(valorNegativo);
        }

        private static void RemocaoNumero(int[] numeros)
        {
            int posicaoParaRemover = 6;

            int[] novoArray = new int[numeros.Length - 1];

            int contadorIntens = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                int valorAtual = numeros[i];
                if (i != posicaoParaRemover)
                {
                    novoArray[contadorIntens] = numeros[i];
                    contadorIntens++;
                }
            }
            Console.WriteLine($"\nSequência após remoção: [{string.Join(", ", novoArray)}]");

            Console.ReadLine();
        }
    }
}
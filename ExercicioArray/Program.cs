using System.Drawing;

namespace ExercicioArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = [-5, 3, 4, 5, 9, 6, 10, -2, 11, 1, 2, 6, 7, 8, 0, -6];

            // Mostrar na Tela os valores da sequência 
            SequenciaDeNumeros(numeros);

            Array.Sort(numeros); //Ordenador de numeros.

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

        }

        private static void SequenciaDeNumeros(int[] numeros)
        {
            Console.WriteLine($"A sequencia de numeros fornecida é de:");
            foreach (int i in numeros)
                Console.Write(i + " ");
        }

        private static void MaiorNumeroArray(int[] numeros)
        {
            Console.WriteLine($"\nO maior numero da sequencia apresentada é de: {numeros[15]}");
        }

        private static void MenorNumeroArray(int[] numeros)
        {
            Console.WriteLine($"O menor numero da sequencia apresentada é de: {numeros[0]}");
        }

        private static void ValorMedioArray(int[] numeros)
        {
            double soma = 0;
            double qntNumeros = 16;

            foreach (int valor in numeros)
                soma += valor;

            double resultado = soma / qntNumeros;

            Console.WriteLine($"O valor medio da sequencia é de: {resultado:F}");
        }

        private static void TresMaioresValoresArray(int[] numeros)
        {
            Console.WriteLine($"Os 3 maiores numeros da sequencia apresentada é de: {numeros[15]} {numeros[14]} {numeros[13]}");
        }

        private static void ValoresNegativosArray(int[] numeros)
        {
            Console.WriteLine("Os valores negativos da sequencia são respectivamente:");
            foreach (int valorNegativo in numeros)
                if (valorNegativo < 0)
                    Console.WriteLine(valorNegativo);
        }

    }
}

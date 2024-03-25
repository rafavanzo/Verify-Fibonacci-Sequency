using System;

namespace SequenciaFibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número para verificar se ele pertence à sequência de Fibonacci:");
            string input = Console.ReadLine();

            if (input != null)
            {
                int numero;
                if (int.TryParse(input, out numero))
                {
                    bool pertence = VerificarSePertenceASequencia(numero);

                    if (pertence)
                        Console.WriteLine($"{numero} pertence à sequência de Fibonacci.");
                    else
                        Console.WriteLine($"{numero} não pertence à sequência de Fibonacci.");
                }
                else
                {
                    Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Por favor, digite um número inteiro válido.");
            }
        }

        static bool VerificarSePertenceASequencia(int numero)
        {
            int a = 0, b = 1;

            while (a <= numero)
            {
                if (a == numero)
                    return true;

                int temp = a;
                a = b;
                b = temp + b;
            }

            return false;
        }
    }
}

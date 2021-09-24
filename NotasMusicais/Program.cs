using System;

namespace NotasMusicais
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] notas = {"Dó", "Ré", "Mi", "Fá", "Sol", "Lá", "Si"};

            int numeroInicial, numeroFinal;
            Console.Write("Digite o número inicial: ");
            numeroInicial = int.Parse(Console.ReadLine());

            Console.Write("Digite o número final: ");
            numeroFinal = int.Parse(Console.ReadLine());

            for(int i = numeroInicial; i <= numeroFinal; i++)
            {
                Console.Write($"{notas[(i % 7)]} ");
            }
        }
    }
}

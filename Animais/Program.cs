using System;
using Animais.Entidades;

namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Gato coca = new Gato("Coca", 20);
            Gato foxy = new Gato("Foxy", 3);
            Cachorro einstein = new Cachorro("Einstein", 10);
            Gato edward = new Gato("Edward", 5);

            Animal[] animais = {coca, foxy, einstein, edward};

            int quantidadeDiariaRacao = 0;

            foreach (var animal in animais)
            {
                quantidadeDiariaRacao += animal.quantidadeDeRacao();
            }

            Console.WriteLine($"Serão consumidos {quantidadeDiariaRacao}g por dia");

            Console.ReadKey();
        }
    }
}

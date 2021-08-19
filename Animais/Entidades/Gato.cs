using System;

namespace Animais.Entidades
{
    public class Gato : Animal
    {
        public Gato(string nome, int peso) : base(nome, peso)
        {
        }

        public override int quantidadeDeRacao()
        {
            if (Peso <= 4)
                return 12 * Peso;

            return 15 * Peso;;
        }

        public override void som()
        {
            Console.WriteLine("miau");
        }
    }
}
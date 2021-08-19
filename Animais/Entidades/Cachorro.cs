using System;

namespace Animais.Entidades
{
    public class Cachorro : Animal
    {
        public Cachorro(string nome, int peso) : base(nome, peso)
        {
        }

        public override int quantidadeDeRacao()
        {
            if (Peso <= 3)
            {
                return 35 * Peso;
            }
            else if (Peso > 3 && Peso <= 10)
            {   
                return 45 * Peso;
            }
            return 50 * Peso;
        }

        public override void som()
        {
            Console.WriteLine("auau");
        }
    }
}
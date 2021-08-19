using System;

namespace Idiomas
{
    public class Tcheco : Idioma
    {
        public Tcheco()
        {
            nomeDoIdioma = "Tcheco";
        }

        public override void saudacao()
        {
            Console.WriteLine($"{nomeDoIdioma} Ahoj Svete");
        }
    }
}
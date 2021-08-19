using System;

namespace Idiomas
{
    public class Portugues : Idioma
    {
        public Portugues()
        {
            nomeDoIdioma = "Português";
        }

        public override void saudacao()
        {
            Console.WriteLine($"{nomeDoIdioma} Olá Mundo");
        }
    }
}
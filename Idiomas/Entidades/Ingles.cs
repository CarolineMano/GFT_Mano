using System;

namespace Idiomas
{
    public class Ingles : Idioma
    {
        public Ingles()
        {
            nomeDoIdioma = "Inglês";
        }

        public override void saudacao()
        {
            Console.WriteLine($"{nomeDoIdioma} Hello World");
        }
    }
}
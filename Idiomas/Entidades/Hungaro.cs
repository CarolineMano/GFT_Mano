using System;

namespace Idiomas
{
    public class Hungaro : Idioma
    {
        public Hungaro()
        {
            nomeDoIdioma = "Húngaro";
        }

        public override void saudacao()
        {
            Console.WriteLine($"{nomeDoIdioma} Helló Világ");
        }
    }
}
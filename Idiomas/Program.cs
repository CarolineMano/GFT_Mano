using System;

namespace Idiomas
{
    class Program
    {
        static void Main(string[] args)
        {
            Portugues portugues = new Portugues();
            Ingles ingles = new Ingles();
            Hungaro hungaro = new Hungaro();
            Tcheco tcheco = new Tcheco();

            portugues.saudacao();
            ingles.saudacao();
            hungaro.saudacao();
            tcheco.saudacao();

            Console.ReadKey();
        }
    }
}

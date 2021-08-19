using System;

namespace Idiomas
{
    public abstract class Idioma
    {
        public string nomeDoIdioma { get; set; }
        public string mensagem {get; set; }
        public virtual void saudacao() 
        {
            Console.WriteLine($"{nomeDoIdioma} {mensagem}");
        }
    }
}
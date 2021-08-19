using System;

namespace Idiomas
{
    public abstract class Idioma
    {
        public string nomeDoIdioma { get; set; }
        public abstract void saudacao();
    }
}
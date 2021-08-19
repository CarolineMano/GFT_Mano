namespace Animais.Entidades
{
    public abstract class Animal
    {
        public string Nome { get; set; }
        public int Peso { get; set; }
        public Animal(string nome, int peso)
        {
            Nome = nome;
            Peso = peso;
        }
        public abstract void som();
        public abstract int quantidadeDeRacao();
    }
}
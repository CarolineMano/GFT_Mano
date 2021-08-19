using System;

namespace PresentesGFT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Por favor, digite o ano de entrada do funcionário: ");
            int anoIngresso = int.Parse(Console.ReadLine());
            int tempoDeCasa = DateTime.Now.Year - anoIngresso;

            Console.WriteLine("O funcionário em questão irá receber...");
            switch (tempoDeCasa)
            {
                case 1:
                    Console.WriteLine("Vale Presente");
                    break;
                case 2:
                    Console.WriteLine("Smart Watch");
                    break;
                case 5:
                    Console.WriteLine("Fone Bluetooth");
                    break;
                case 10:
                    Console.WriteLine("Vale Jantar");
                    break;
                case 15:
                    Console.WriteLine("Vale Jantar Top");
                    break;
                default:
                    Console.WriteLine("Esse ano não vai ter presente");
                    break;
            }

            Console.ReadKey();
        }
    }
}

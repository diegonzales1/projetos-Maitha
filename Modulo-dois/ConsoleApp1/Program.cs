using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu, pulos;
            Gato gato = new Gato("Aris", "Vira-lata", 13, true, true);

            do
            {
                Console.WriteLine("========================================");
                Console.WriteLine($"Brincando com o Gato");
                Console.WriteLine("");
                Console.WriteLine("1 - Alimentar");
                Console.WriteLine("2 - Colocar para dormir");
                Console.WriteLine("3 - Brincar");
                Console.WriteLine("4 - Pular");
                Console.WriteLine("5 - Ver saúde");
                Console.WriteLine("6 - Ver dados");
                Console.WriteLine("7 - Sair");
                Console.WriteLine("========================================");
                Console.Write("Digite a opção: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Console.Clear();
                        gato.Alimentar();
                        break;
                    case 2:
                        Console.Clear();
                        gato.Dormir();
                        break;
                    case 3:
                        Console.Clear();
                        gato.Brincar();
                        break;
                    case 4:
                        Console.Clear();
                        Console.Write("Digite quantos pulos o gato deve dar: ");
                        pulos = int.Parse(Console.ReadLine());
                        gato.Pular(pulos);
                        break;
                    case 5:
                        Console.Clear();
                        gato.Saude();
                        break;
                    case 6:
                        Console.Clear();
                        gato.MostraGato();
                        break;
                }
            } while (menu != 7);
           
        }

    }
}

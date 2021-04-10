using System;


namespace helloworld
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nomes = null;
            string procuraNome = "", opcao = "", sexo = "";
            int cont = 0, idade;
            bool teste;
            float altura;

            Console.WriteLine("====================================================");
            Console.WriteLine("                  Procura Pessoas");
            Console.WriteLine("====================================================");

            Console.Write("Digite até 5 nomes dando espaço entre eles: ");
            nomes = Console.ReadLine().ToLower().Split(' ');

            do
            {
                try
                {
                    if (nomes.Length > 5)
                        throw new Exception("Escreva no máximo 5 nomes");

                    Console.Write("Digite um nome: ");
                    procuraNome = Console.ReadLine().ToLower();

                    foreach (var item in nomes)
                    {
                        if (string.Equals(item, procuraNome))
                        {
                            cont = 1;
                        }
                    }

                    if (cont == 1)
                    {
                        Console.Write("Digite o sexo da pessoa: ");
                        sexo = Console.ReadLine();

                        Console.Write("Digite a idade da pessoa: ");
                        idade = int.Parse(Console.ReadLine());

                        Console.Write("Digite a altura da pessoa: ");
                        altura = float.Parse(Console.ReadLine());


                        Console.WriteLine("====================================================");
                        Console.WriteLine($"Nome: {procuraNome}");
                        Console.WriteLine($"Sexo: {sexo}");
                        Console.WriteLine($"Idade: {idade}");
                        Console.WriteLine($"Altura: {altura}");
                        Console.WriteLine("====================================================");
                    }
                    else
                    {
                        Console.Write("Nome não encontrando, deseja lista o nome? Sim/Não: ");
                        opcao = Console.ReadLine();

                        if (opcao.ToLower().Trim() == "sim")
                        {
                            Console.WriteLine("====================================================");
                            Console.WriteLine("Nomes: ");
                            foreach (var item in nomes)
                            {
                                Console.Write($" {item} ");
                            }
                            Console.WriteLine("====================================================");
                            Console.WriteLine();
                        }
                    }
                }
                catch (Exception err)
                {
                    Console.WriteLine(err.Message);
                }

            } while (opcao == "sim");
        }
    }
}

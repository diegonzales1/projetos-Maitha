using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Gato
    {
        public String Nome { get; set; }
        public String Raca { get; set; }
        public int Idade { get; set; }
        public bool Comer { get; set; }
        public bool Vacina { get; set; }

        public Gato(string nome, string raca, int idade, bool comer, bool vacina)
        {
            Nome = nome;
            Raca = raca;
            Idade = idade;
            Comer = comer;
            Vacina = vacina;
        }

        public void Pular(int pulos)
        {
            Console.WriteLine("");
            for(int i =0; i <= pulos; i++)
            {
                Console.WriteLine($"{Nome} pulou");
            }
            Console.WriteLine("");
        }

        public void Dormir()
        {
            if(Comer == true)
            {
                Console.WriteLine("");
                Console.WriteLine($"{Nome} está de barriga cheia e vai dormir");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{Nome} está com fome e não quer dormir");
                Console.WriteLine("");
            }
        }

        public void Brincar()
        {
            Console.WriteLine("");
            Console.WriteLine($"{Nome} está brincando");
            Console.WriteLine("");
        }

        public void Alimentar()
        {
            if(Comer == true)
            {
                Console.WriteLine("");
                Console.WriteLine($"{Nome} não está com fome");
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine($"{Nome} está comendo");
                Console.WriteLine("");
                Comer = true;
            }
        }

        public void Saude()
        {
            if(Comer == true && Vacina == true)
            {
                Console.WriteLine("");
                Console.WriteLine($"{Nome} está saudavel");
                Console.WriteLine("");
            }
            else if(Vacina == false && Comer == false)
            {
                Console.WriteLine("");
                Console.WriteLine($"{Nome} está ficando doente");
                Console.WriteLine("");
            }
        }

        public void MostraGato()
        {
            Console.WriteLine("");
            Console.WriteLine("========================================");
            Console.WriteLine($"");
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"Idade: {Idade}");
            Console.WriteLine($"Raça: {Raca}");
            Console.WriteLine($"Vacina: {Vacina}");
            Console.WriteLine($"");
            Console.WriteLine("========================================");
            Console.WriteLine("");
        }
    }
}

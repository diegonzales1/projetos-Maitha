using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
     class Peixe : Animal
    {
        public String Cor { get; set; }
        public Peixe(String nome, String cor, decimal peso) : base(nome, peso)
        {
            Cor = cor;
        }

        public override void Comer() {
            Console.WriteLine($"{Nome} está comendo minhoca");
        }

        public override void Mover() {
            Console.WriteLine($"{Nome} está nadando...");
        }

        public override void Status()
        {
            Console.WriteLine($"Nome: {Nome} \tCor: {Cor} \t\tIdade: {Idade} \tPeso: {Peso}kg");
        }

        public void fazerBolhas()
        {
            Console.WriteLine($"{Nome} está fazendo bolhas");
        }
    }
}

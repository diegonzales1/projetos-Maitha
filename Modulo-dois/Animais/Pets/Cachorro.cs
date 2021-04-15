using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais 
{
    class Cachorro : Animal
    {

        public String Raca { get; set; }

        public Cachorro(String nome, String raca, decimal peso) : base(nome, peso) {
            Raca = raca;
        }

        public override void Comer() {
            Console.WriteLine($"{Nome} está comendo ração");
        }

        public override void Mover() {
            Console.WriteLine($"{Nome} está correndo...");
        }

        public override void Status() {
            Console.WriteLine($"Nome: {Nome} \tRaça: {Raca} \t\tIdade: {Idade} \tPeso: {Peso}kg");
        }
        public void Brincar()
        {
            Console.WriteLine($"{Nome} está brincando com a bola");
        }
    }
}

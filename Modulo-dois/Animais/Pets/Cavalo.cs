using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais.Pets
{
    class Cavalo : Animal 
    {

        public String Raca { get; set; }
        public bool Treinado { get; set; }

        public Cavalo(string nome, string raca, bool treinado, decimal peso) : base(nome, peso)
        {
            Raca = raca;
            Treinado = treinado;
        }
        
         public override void Comer()
        {
            Console.WriteLine($"{Nome} está comendo cenoura");
        }

        public override void Mover()
        {
            Console.WriteLine($"{Nome} está galopando...");
        }

        public override void Status()
        {
            Console.WriteLine($"Nome: {Nome} \tAdestrado: {Treinado} \tIdade: {Idade} \tPeso: {Peso}kg");
        }
    }
}

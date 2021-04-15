using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animais
{
     abstract class Animal
    {
        public String Nome { get; set; }
        public int Idade { get; }
        public decimal Peso { get; set; }

        public Animal(String nome, decimal peso)
        {
            Random rnd = new Random();
            Nome = nome;
            Peso = peso;
            Idade = rnd.Next(0 , 10);
        }

        public abstract void Comer();
        public abstract void Mover();
        public abstract void Status();
        


       
        

    }
}

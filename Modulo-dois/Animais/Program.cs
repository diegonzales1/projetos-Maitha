using System;
using Animais.Pets;




namespace Animais
{
    class Program
    {
        static void Main(string[] args)
        {
            Peixe fish = new Peixe("Beto", "Azul", 1.600M);
            Cachorro dog = new Cachorro("Preta", "Pitbul", 5.400M);
            Cavalo horse = new Cavalo("Zézinho", "Puro-Sangue",true, 500.200M);

            fish.Status();
            dog.Status();
            horse.Status();
        }
    }
}

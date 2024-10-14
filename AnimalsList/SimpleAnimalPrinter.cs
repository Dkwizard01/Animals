using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{
    internal class SimpleAnimalPrinter : IAnimalPrinter
    {

        public List<Animal> inputAnimal;


        public void printAnimal(List<Animal> Animals)

        {
            this.inputAnimal = Animals;
            for (int i = 0; i < inputAnimal.Count; i++)
            {
                Console.WriteLine("Name: " + inputAnimal[i].Name);
                Console.WriteLine("Kind: " + inputAnimal[i].Kind);
                Console.WriteLine("ID: " + inputAnimal[i].ID);
                Console.WriteLine("Number of legs: " + inputAnimal[i].Legs);
                if (inputAnimal[i] is Bird)
                {
                    Console.WriteLine("Number of wings: " +
                 ((Bird)inputAnimal[i]).Wings);
                }

                Console.WriteLine("Description: " + inputAnimal[i].Description);

            }
        }
    }
}

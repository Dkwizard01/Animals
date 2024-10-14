using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{
    internal class FileAnimalPrinter : IAnimalPrinter
    {

        public List<Animal> inputAnimal;


        public void printAnimal(List<Animal> Animals)

        {  
            this.inputAnimal = Animals;
            Console.ForegroundColor = ConsoleColor.Blue;
            using (StreamWriter sw = new StreamWriter("animals.txt", true))
            {
                for (int i = 0; i < inputAnimal.Count; i++)
                {
                    sw.WriteLine("Name: " + inputAnimal[i].Name);
                    sw.WriteLine("Kind: " + inputAnimal[i].Kind);
                    sw.WriteLine("ID: " + inputAnimal[i].ID);
                    sw.WriteLine("Number of legs: " + inputAnimal[i].Legs);
                    if (inputAnimal[i] is Bird)
                    {
                        sw.WriteLine("Number of wings: " + ((Bird)inputAnimal[i]).Wings);
                    }

                    sw.WriteLine("Description: " + inputAnimal[i].Description);

                }
            }
        }
    }
}

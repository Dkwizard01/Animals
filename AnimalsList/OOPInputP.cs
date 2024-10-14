using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Daenet_OOP
{
    internal class OOPInputP : IOOPInputP
    {
        List<Animal> inputAnimal = new List<Animal>();
       public List <Animal> Processor()
        {
            while (true)
            {
                Console.WriteLine("Please enter the name of the animal:");
                string name = Console.ReadLine();

                Console.WriteLine("Please eneter the type/kind of animal:");
                string kind = Console.ReadLine().ToLower();

                Console.WriteLine("Please enter the number of legs of the " + kind + ":");
                int legs = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Please enter a description of the " + kind + ":");
                string description = Console.ReadLine();


                Animal animal;
                if (kind == "bird")
                {
                    Console.WriteLine("Please enter the number of wings of the bird:");
                    int numWings;
                    string numberOfWings = Console.ReadLine();
                    int.TryParse(numberOfWings, out numWings);
                    animal = new Bird(name, inputAnimal.Count + 1, legs, description,numWings);
                }
                else
                {
                    animal = new Animal(name, kind, inputAnimal.Count + 1, legs, description);
                }

                inputAnimal.Add(animal);
                
                
                Console.WriteLine("Please enter \"n\" for the next animal or \"e\" to exit.");
                string choice = Console.ReadLine().ToLower();
                if (choice == "e")
                {
                    break;
                }
              

            }
            return inputAnimal;



        }

    }
    

}
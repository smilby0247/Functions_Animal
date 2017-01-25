using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace functions_SCM
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();
            animals.Add(new Animal("Zebra"));
            animals.Add(new Animal("Giraffe"));
            animals.Add(new Animal("Hippo"));
            animals.Add(new Animal("Lion"));
            animals.Add(new Animal("Elephant"));

            foreach (Animal animal in animals)
            {
                Console.WriteLine(animal.Describe());
            }


            Console.ReadKey();
           


        }
    }
}
       
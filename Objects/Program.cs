using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal animal = new Horse();
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.GetLegs());
            animal.Sound();
            Console.WriteLine(animal.AnimalType());
            Console.Read();
        }
    }
}

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
            IAnimal animal = new Person();
            Console.WriteLine(animal.Name);
            Console.WriteLine(animal.GetLegs());
            Console.ReadLine();
        }
    }
}

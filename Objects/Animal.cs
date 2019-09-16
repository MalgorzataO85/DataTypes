using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public abstract class Animal
    {
        public string Name { get; set; }

        public abstract int GetLegs();

        public virtual string AnimalType()
        {
            return "Normal";
        }
        public virtual void Sound()
        {
            Console.WriteLine("Sound...");
        }
    }
}

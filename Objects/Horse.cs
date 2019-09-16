using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Horse : Animal
    {
        public Horse()
        {
            Name = "Horse";
        }
        public override int GetLegs()
        {
            return 4;
        }

        public override string AnimalType()
        {
            string rezault = "XYZ";
            // rezault = rezault + base.AnimalType();
            return rezault;
        }

        public override void Sound()
        {
            Console.WriteLine("Ihahah");
        }
    }
}

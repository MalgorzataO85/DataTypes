using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    class Person : IAnimal
    {
        public string Name { get; set; }

        public int GetLegs()
        {
            return 2;
        }
    }
}

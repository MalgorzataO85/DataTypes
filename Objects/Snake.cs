using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objects
{
    public class Snake : IAnimal
    {
        public string Name { get; set; } = "Snake";

        public int GetLegs()
        {
            return 1;
        }
    }
}

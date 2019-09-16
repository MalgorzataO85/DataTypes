using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    public struct Person
    {
        public string Name;
        public string LastName { get; set; } //właściwość
        public int? BirthDate { get; set; } //? - może być null

        
        public int GetAge()
        {
            return DateTime.Today.Year - (int)BirthDate;   //metoda
        }


    }
}

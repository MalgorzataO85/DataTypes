using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Person
    {
        public string Name;
        public string LastName { get; set; } //właściwość
        public int? BirthDate { get; set; } //? - może być null

        public Person()
        {
            BirthDate = 1950; //konstuktor, wartość domyślna chroni przed wyjątkami, np. żeby nie było nulla
        }

        public int GetAge()
        {
            return DateTime.Today.Year - (int)BirthDate;   //metoda
        }


    }
}

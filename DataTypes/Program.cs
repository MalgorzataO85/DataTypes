using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            ////Console.WriteLine("Hello Worls");
            ////bool isTrue = true;
            ////isTrue = false;
            //int a = 10;
            //decimal b = a;
            ////int c = Convert.ToInt32(b); //konwersja, może być też rzutowanie
            ////int c = int.Parse(b.ToString());
            //int c = 1;
            //string d = "Roman";

            //int e = a / c;
            ////a++; inkrementacje
            ////++a;
            ///
            Person roman = new Person();
            roman.Name = "Roman";
            roman.LastName = "Nowak";
            roman.BirthDate = 2000;

            Person anna = roman;
            anna.Name = "Anna";

            //int c = 10;
            //int d = c;
            //Console.WriteLine(c);
            //Console.WriteLine(d);

            Console.WriteLine(roman.Name);
            Console.WriteLine(roman.LastName);
            Console.WriteLine(roman.GetAge());

            Console.WriteLine(anna.Name);
            Console.WriteLine(anna.LastName);
            Console.WriteLine(anna.GetAge());
            Console.ReadLine();
        }
    }
}

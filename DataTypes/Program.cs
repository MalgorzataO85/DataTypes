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
            TyrFor();
            //////Console.WriteLine("Hello Worls");
            //////bool isTrue = true;
            //////isTrue = false;
            ////int a = 10;
            ////decimal b = a;
            //////int c = Convert.ToInt32(b); //konwersja, może być też rzutowanie
            //////int c = int.Parse(b.ToString());
            ////int c = 1;
            ////string d = "Roman";

            ////int e = a / c;
            //////a++; inkrementacje
            //////++a;
            /////
            Person roman = new Person();
            roman.Name = "Roman";
            roman.LastName = "Nowak";
            roman.BirthDate = 2000;
            object o = new object();
            var anna = roman;
            if (anna.Equals(roman))
            {
                Console.WriteLine("ok");
            }
            anna.Name = "Anna";

            //dynamic x = 45.5m;
            //x = "Imie";
            //x = 10;
            //x = true;
            //Console.WriteLine(x);
            ////int c = 10;
            ////int d = c;
            ////Console.WriteLine(c);
            ////Console.WriteLine(d);

            Console.WriteLine(roman.Name);
            Console.WriteLine(roman.LastName);
            Console.WriteLine(roman.GetAge());

            Console.WriteLine(anna.Name);
            Console.WriteLine(anna.LastName);
            Console.WriteLine(anna.GetAge());
            Console.ReadLine();
        }

        private static void TyrFor()
        {
            //for (int i = 0; i < 10; i++) //gdy chcemy dokładnż ilość razy wyonać pętlę
            //{
            //    Console.WriteLine(i);
            //}
            //int i = 0;           
            //while (i < 0)
            //{
            //    Console.WriteLine(i);
            //    i++;
            //}

            //int i = 0;
            //do
            //{
            //    Console.WriteLine(i);
            //    break; // return; contunue;
            //    i++;
            //}
            //while (i < 0);

            //int[] ints = { 1, 2, 3, 4 };
            //foreach (var item in ints)
            //{
            //    var x = item * 10;
            //    Console.WriteLine(x);
            //}

            //int i = 0;
            //if(i<10)
            //{
            //    return;
            //}
            //else if(i>10)
            //{
            //    Console.WriteLine(i);
            //}
            //else
            //    Console.WriteLine(i *= 10);

            //int i = 100;

            //switch (i)
            //{
            //    case 10:
            //        Console.WriteLine(10);
            //        goto case 100;
            //    case 100:
            //        Console.WriteLine(100);
            //        break;
            //    default:
            //        Console.WriteLine(i *= 10);
            //        break;
            //}

        }
    }
}

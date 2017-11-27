using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilApp
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Bil b = new Bil();
            b.BilId = 1;
            b.Model = "Ford";
            b.AntalCylindre = 4;

            LastBil l = new LastBil() { BilId = 2, Model = "Rookie", AntalCylindre = 8 };


            l.Print();
            b.Print();

            Console.ReadLine();


            PersonBil p = new PersonBil() { Model = "Z" };
            p.Print();


            Bil[] biler = new Bil[3];
            biler[0] = b;
            biler[1] = l;
            biler[2] = p;

            foreach (var bil in biler)
            {
                bil.Print();
                    }

            Console.ReadLine();
        }
    }
}

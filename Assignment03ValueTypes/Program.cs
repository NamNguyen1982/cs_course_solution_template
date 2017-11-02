using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment03ValueTypes
{
    class Program
    {
        static void Main(string[] args)

            
        {
            
            Int32 heltal;
                heltal = 10;
                heltal++;
                heltal--;
                heltal += 20;
            Console.WriteLine(heltal);
            Console.WriteLine();


            // --heltal;


            // Console.ReadKey();


            double kommatal;
                kommatal = 12.5;
                kommatal++;
                kommatal--;
                kommatal *= 2;
            Console.WriteLine(kommatal);
            Console.WriteLine();


            FilTyper ft = FilTyper.csv;
            Console.WriteLine(ft);
            Console.WriteLine((int)ft);
            Console.WriteLine();


            DateTime dato = DateTime.Now;
            Console.WriteLine(dato.ToString("dddd"));
            Console.WriteLine(dato.ToString("dmy"));
            Console.WriteLine(dato.ToLongDateString());
            Console.WriteLine(dato.ToLongTimeString());

            Console.WriteLine();

            Person p = new Person();

            p.id = 1;
            p.ForNavn = "Nam";
            p.EfterNavn = "Nguyen";
            p.Alder = 25;
            p.Postnummer = 2630;

            Console.WriteLine("{0}\n{1} {2} \n{3} \n{4}",p.id,p.ForNavn,p.EfterNavn,p.Alder,p.Postnummer);
            Console.WriteLine();



            if (System.Diagnostics.Debugger.IsAttached)
            {
                System.Console.Write("Press any key to continue . . . ");
                System.Console.ReadKey();
            }

        }


    }

}

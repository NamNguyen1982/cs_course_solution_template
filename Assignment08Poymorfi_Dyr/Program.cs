using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08Poymorfi_Dyr
{
    class Program
    {
        static void Main(string[] args)
        {

            //Dyr d = new Dyr() { Navn = "dyr" };
            //Hund h = new Hund() { Navn = "hund" };
            //Kat k = new Kat() { Navn = "kat" };

            Dyr[] dyr = new Dyr[20];
            for (int i = 0; i < 20; i++)
            {
                dyr[i] = Dyr.TilfædigtDyr();
            }
            foreach (var item in dyr)
            {
                item.SigNoget();
            }

            Console.ReadKey();
        }
    }
}

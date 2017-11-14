using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment08Poymorfi_Dyr
{
    public class Dyr
    {
        public string Navn { get; set; }

        static Random rnd = new Random();

        public virtual void SigNoget()
        {

            Console.WriteLine(" Jeg er et dyr og hedder..." + Navn);

        }


        public static Dyr TilfædigtDyr()
        {

            string sti = @"X:\dyrenavne.txt";
            string[] navne = System.IO.File.ReadAllLines(sti);
            int index = rnd.Next(0, navne.Length);
            if (index % 2 == 0)
            {
                return new Hund() { Navn = navne[index] };
            }
            else
            {
                return new Kat() { Navn = navne[index] };
            }



        }
    }
}
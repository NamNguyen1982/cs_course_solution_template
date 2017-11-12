using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Assignment05SmaaMetoder
{
    class Program
    {
        static void Main(string[] args)
        {

            //int resultat = LaegSammen(10, 2);
            //Console.WriteLine(resultat);
            ////Console.ReadKey();

            //double arealResultat = BeregnAreal(7);
            //Console.WriteLine(arealResultat);
            //Console.ReadKey();

            ////Udskriv();
            //Udskriv("hej");
            //Console.ReadKey();

            double momsRes = BeregnMoms(100);
            Console.WriteLine(momsRes);
            Console.ReadKey();
            //double momsRes2 = 

            var løn = new int[] { 20000, 20000, 30000 };
            double gennemsnit = gns(løn);
            Console.WriteLine(gennemsnit);
            Console.ReadKey();



        }

        static int LaegSammen(int a, int b)
            {

            return a + b;

            }

        static double BeregnAreal(double radius)
            {

            return radius * radius * Math.PI;
            
            }

        static void Udskriv ()
            {

            Console.WriteLine();

            }

        //static void Udskriv()
        //{

        //    Console.WriteLine();

        //}
        static void Udskriv(string txt)
        {

            Console.WriteLine(txt);

        }

        static double BeregnMoms(double beloeb, double momsPct = 0.25)
        {

            return beloeb * momsPct;

        }

        static double gns(int[] månedsløn)

        {
            double sum = 0;
            for (int i = 0; i < månedsløn.Length; i++)
            {
                sum += månedsløn[i];
            }

            return sum / månedsløn.Length;
        }

    }
}

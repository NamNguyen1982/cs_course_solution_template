using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05BeregnArray_2
{
    class Program
    {
        static void Main(string[] args)
        {

            // oprettelse af Array
            int[] test = { 10, 7, 6, 3, 1, 50, 3 };

            // metode kaldet
            var res = BeregnOgSorterArray(test);

            //Console.WriteLine(res.sum);
            Console.WriteLine(res.sum);
            //Console.WriteLine(a);
            
            Console.ReadKey();
            

        }
        // Laver metoden BeregnOgSorterArray , med en struct datatype - med et Array som parameter
        public static ArrayResultat2 BeregnOgSorterArray(int[] a)
        {
            ArrayResultat2 res;

            res.sum = 0;

            foreach (var item in a)
            {

                res.sum += item;


            }

            res.gennemsnit = res.sum / a.Length;

            Array.Sort(a);
            return res;
            


        }

    }

    //ArrayResultat2 datatype som struct
    public struct ArrayResultat2
    {

        public double sum;
        public double gennemsnit;

    }
}

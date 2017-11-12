using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05BeregnArray
{
    class Program
    {
        static void Main(string[] args)
        {
            var val = new int[] { 6, 2, 7, 4, 3, 6, 8 };

            //udskriver Array før manipulering
            foreach (var item in val)
                {
                Console.Write(item.ToString());
                }

            Console.ReadKey();

            var resultat = BeregnOgSortgerArray(val);

                Console.WriteLine("{0}\n{1}",resultat.sum,resultat.gennemsnit);
           
                Console.ReadKey();

            //udskriver Array efter manipulering
            foreach (var item in val)
                {
                Console.Write(item.ToString());
                }

                Console.ReadKey();
        }

        public static ArrayResultat BeregnOgSortgerArray(int[] a)
        {
            ArrayResultat r;
            r.sum = 0;

            foreach (var item in a)
                {
                r.sum += item;


                }

            r.gennemsnit = r.sum / a.Length;
            Array.Sort(a);
            return r;
        }


  
    }

    struct ArrayResultat
    {
        public double sum;
        public double gennemsnit;
    }
}

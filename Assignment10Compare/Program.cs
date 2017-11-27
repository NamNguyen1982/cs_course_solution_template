using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment10Compare
{
    class Program
    {
        static void Main(string[] args)
        {

            Hund[] hunde = new Hund[2];
            hunde[0] = new Hund() { Alder = 10, Name = "Bulder" };
            hunde[1] = new Hund() { Alder = 5, Name = "Lady" };

            Array.Sort(hunde);
            foreach (var item in hunde)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();


        }
    }

     public class Hund : IComparable
    {

        public string Name { get; set; }
        public int Alder { get; set; }
        
        public int CompareTo(object obj)
        {
            Hund h = obj as Hund;

            if (h.Alder > this.Alder)
            {
               return -1;
            }
            if (h.Alder < this.Alder)
            {
                return 1;
            }
            return 0;
            
        }
    }

    //interface IComparable {
    //    int CompareTo(object obj);

    //}

}

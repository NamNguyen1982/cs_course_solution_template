using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignmenet11Collection2
{
    class Program
    {
        static void Main(string[] args)
        {

            Bunke b = new Bunke();


            b.Tilføjkort(new Kort() { Kulør = "Spar", Værdi = 2, });
            b.Tilføjkort(new Kort() { Kulør = "Ruder", Værdi = 7, });
            b.Tilføjkort(new Kort() { Kulør = "Hjerter", Værdi = 9, });
            b.Vis();
            //var k = b.FjernKort();
            var k = b.FjernKort();
            Console.WriteLine("----------------------------------");


            Console.WriteLine(k);
            
            Console.ReadLine();


        }
    }

    public class Bunke
    {

        private Stack<Kort> bunke = new Stack<Kort>();
        public void Tilføjkort(Kort k)
        {
            this.bunke.Push(k);

        }

        public Kort FjernKort()
        {

            if (bunke.Count > 0)

                // POP - Last in First out
                return bunke.Pop();
            return null;
        }

        public void Vis()
        {
            foreach (var item in bunke)
            {
                Console.WriteLine(item);
            }

        }


    }

    public class Kort
    {
        public string Kulør { get; set; }
        public int Værdi { get; set; }
        public override string ToString()
        {
            return this.Kulør + " " + this.Værdi;
        }


    }
}

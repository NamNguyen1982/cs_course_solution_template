using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07Egenskaber
{
    class Vare
    {
        static void Main(string[] args)
        {

            Vare v = new Vare();
            v.navn = "Cola";
            v.pris = 10;

            Console.WriteLine("{0}\n{1}", v.Name,v.PrisMedMoms())
            ;
            Console.ReadKey();
            //Vare v2 = new Vare("Topnøgle",100);
            //Console.WriteLine(v2.pris);
            //Console.ReadKey();
           


        }


        private string navn;

        public string Name
        {
            get {

                Console.WriteLine("indlæs af navn");
                return navn; }
            set {

                Console.WriteLine("indlæs af navn");

                navn = value; }
        }



        private double pris;
        public double Pris
        {
            get {

                Console.WriteLine("indlæs af pris");

                return pris; }
            set {
                Console.WriteLine("print af pris");

                this.pris = value; }
        }


        public double PrisMedMoms() {

            return this.pris * 1.25;

        }


        public Vare()
        {

        }

        public Vare(string navn, int pris)
        {
            this.navn = navn;
            this.pris = pris;
            
        }
    }


}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06Terningen
{
    class Terningen
    {

        public int værdi;
        private bool snyd;
        private static Random rnd = new Random();


        public void Ryst()
        {

            if (snyd)
                this.værdi = 6;
            else
                this.værdi = rnd.Next(1, 7);
            

           

            //Console.WriteLine(this.værdi);
        }


        public void Skriv() {

            Console.WriteLine(this.værdi);
        }


        //public Terningen() {

        //    this.værdi = 1;
        //    this.snyd = false;

        //}

        //public Terningen(bool snyd) {

        //    this.værdi = 1;
        //    this.snyd = snyd;
        //}
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12Event
{
    class Program
    {
        static void Main(string[] args)
        {

            Kunde k = new Kunde() { KreditMax = -500 };
            

            k.KreditOverskredet += (s, e) => {
              Console.WriteLine("Kredit Overskredet");
                Console.ReadLine();
            };
           
            


                
            

            k.Køb(100);
            k.Køb(600);
            //int rest = 
            //Console.WriteLine("Din saldo er : " + rest);
        }
    }

    public class Kunde
    {
        public event EventHandler KreditOverskredet;

        public string Navn { get; set; }

        private int saldo;

        public int Saldo
        {
            get { return saldo; }
            set { saldo = 1000; }
        }


        //public int Saldo { get; set; }
        public int KreditMax { get; set; }

        public void Køb(int værdi) {

            Console.WriteLine("Kunde {0} køber for {1}", Navn,værdi);
            this.Saldo -= værdi;
            if(Saldo < KreditMax)
            {
                if (KreditOverskredet != null)
                {
                    KreditOverskredet(this, new EventArgs());
                }

            }

        }

    }
}

using System;

namespace BilApp
{
    public class Bil
    {
        //public int BilId;
        public int BilId { get; set; }

        public string Model { get; set; }


        //public int AntalCylindre { get; set; }

        private int _antalCylindre;

        public int AntalCylindre
        {
            get { return _antalCylindre;             
            }
            set {

                if (value<4 || value >8)
                {
                    throw new ApplicationException("Forkert antal cylindre");
                }
                _antalCylindre = value; }
        }
        public virtual void Print()
        {
            Console.WriteLine("Bil : " + this.Model);

        }

    }

   


    public class PersonBil : Bil
    {
        public int AntalBarneSæder { get; set; }

        public override void Print()
        {


            Console.WriteLine("Bil : " + this.Model);

        }


    }

    public class LastBil : Bil 
    {

        public int LasteEvne { get; set; }

    }
}

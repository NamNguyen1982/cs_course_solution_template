using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07EgenskaberTrekant
{
    public class Trekant
    {

        public int Grundlinje { get; private set; }

        public int Højde { get; private set; }

        private int areal;

        public double Areal
        {
            get {


                return this.Grundlinje * this.Højde * 0.5; }
            //set {

            //    double res = Grundlinje * Højde * 0.5;

            //    areal = value; }
        }


        public Trekant(int grundlinje, int højde)
        {

            this.Grundlinje = grundlinje;
            this.Højde = højde;


        }

        public Trekant():this(2,3)
        {

        }

    }
}

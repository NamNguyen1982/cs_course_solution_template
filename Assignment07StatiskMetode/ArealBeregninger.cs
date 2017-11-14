using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment07StatiskMetode
{
    public static class ArealBeregninger
    {




        //private double højde;

        //public double Højde
        //{
        //    get { return højde; }
        //    set { højde = value; }
        //}

        //private double bredde;

        //public double Bredde
        //{
        //    get { return bredde; }
        //    set { bredde = value; }
        //}

        //private double radius;

        //public double Radius
        //{
        //    get { return radius; }
        //    set { radius = value; }
        //}




        public static double BeregnArealFirkant(double højde, double bredde)
        {

            return højde * bredde;


        }

        public static double BeregnArealCirkel(double radius)
        {

            return Math.Pow(radius, 2) * Math.PI;

        }


    }


    //public static ArealBeregninger()
    //{
    //    return Console.WriteLine("Ingen parameter indsat");
    //}



}

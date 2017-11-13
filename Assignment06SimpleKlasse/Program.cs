using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06SimpleKlasse
{
    class Program
    {
        static void Main(string[] args)
        {

            Person p = new Person("Nam", "Nguyen", 0);
            //p.Fornavn = "Nam";
            //p.Efternavn = "Nguyen";
            //p.Fødselsår = 1982;
            Console.WriteLine(p.Fuldtnavn());
            Console.WriteLine(p.Alder());
            Console.ReadKey();

            //Person p2 = new Person();

            //p2= p;

            //Console.WriteLine(p2.Fuldtnavn());
            Console.ReadKey();
        }
    }

    //class Person
    //{
    //    public string Fornavn;
    //    public string Efternavn;
    //    public int Fødselsår;




    //    public string Fuldtnavn()

    //    {

    //        return Fornavn + " " + Efternavn;

    //    }

    //    public int Alder()
    //    {

    //        int år = DateTime.Now.Year;
    //        return (år - Fødselsår);

    //    }
    //    //Custom Constructor
    //    //public Person()
    //    //{

    //    //    this.Fornavn = "";
    //    //    this.Efternavn = "";
    //    //}

    //    public Person(string fornavn, string efternavn, int fødselsår) {

    //        this.Fornavn = fornavn.ToUpper();
    //        this.Efternavn = efternavn.ToUpper();
    //        this.Fødselsår = fødselsår;

    //    }

    //}


}

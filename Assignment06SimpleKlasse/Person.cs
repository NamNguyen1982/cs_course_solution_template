using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment06SimpleKlasse
{

    class Person
    {
        public string Fornavn;
    public string Efternavn;
    public int Fødselsår;




    public string Fuldtnavn()

    {

        return Fornavn + " " + Efternavn;

    }

    public int Alder()
    {

        int år = DateTime.Now.Year;
        return (år - Fødselsår);

    }
    //Custom Constructor
    //public Person()
    //{

    //    this.Fornavn = "";
    //    this.Efternavn = "";
    //}

    public Person(string fornavn, string efternavn, int fødselsår)
    {

        this.Fornavn = fornavn.ToUpper();
        this.Efternavn = efternavn.ToUpper();
        this.Fødselsår = fødselsår;

    }

}



}

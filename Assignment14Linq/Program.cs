using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment14Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = new PersonNuGetPackage.PersonRepositoryRandom();
            var people = r.GetPeople(100);

            foreach (var person in people)
            {
                Console.WriteLine(person.Name);
            }

            var sort = from x in people orderby x.Name select people;

            foreach (var item in people)
            {
                Console.WriteLine(sort);
            }


            Console.ReadLine();

            //var rr = new PersonNuGetPackage.PersonRepositoryRandom().GetPeople(100);
            ////var people2 = rr.GetPeople();
            //foreach (var person in rr)
            //{
            //    Console.WriteLine(person.Name);
            //}
            //Console.ReadLine();

            //var sort = rr.OrderBy(i => i.Name);
            //var sort1 = from x in rr orderby x.Name select rr;

            //var sort = from p in rr orderby p.Name select p;
            //foreach (var item in sort)
            //{
            //    Console.WriteLine(sort);
            //}

            //var sort = rr.OrderBy(p => p.Name);
            //foreach (var p.name in sort)
            //{
            //    Console.WriteLine(sort.);
            //}


            //var sort = people2.OrderBy(i => i.Name);
            //var sort1 = from 
            //foreach (var item in sort)
            //{
            //    Console.WriteLine(people2.);
            //}




        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;

namespace BETTERCOMBININGSPECIFICATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person(){ FirstName = "Julius", LastName = "Bacosa", BrainLevel = BrainLevel.bogo },
                new Person(){ FirstName = "Julius", LastName = "Julius", BrainLevel = BrainLevel.sakto  },
                new Person(){ FirstName = "Bacosa", LastName = "Barte", BrainLevel = BrainLevel.bright },
            };
            var firstName = new NameIsJuliusSpecification();
            var lastName = new NameIsBaseSpecification();

            Specification<Person> spec = firstName.And(lastName);

            var res = people.AsQueryable().Where(spec.ToExpression()).ToList();
            foreach (var p in res)
            {
                Console.WriteLine($"-{p.FirstName}-{p.LastName}-");
            }

          
            Console.ReadLine();
        }
    }
}

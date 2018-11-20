using COMBININGSPECIFICATIONS.Models;
using COMBININGSPECIFICATIONS.Specifications;
using System;
using System.Collections.Generic;
using System.Linq;

namespace COMBININGSPECIFICATIONS
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person(){ FirstName = "Julius", LastName = "Bacosa", BrainLevel = BrainLevel.bogo },
                new Person(){ FirstName = "Cabatana", LastName = "Julius", BrainLevel = BrainLevel.sakto  },
                new Person(){ FirstName = "Bacosa", LastName = "Barte", BrainLevel = BrainLevel.bright },
            };
            var spec = new BrainIsSaktoSpecification();
            var res = people.AsQueryable().Where(spec.ToExpression()).ToList();
            foreach (var p in res)
            {
                Console.WriteLine($"-{p.FirstName}-{p.LastName}-");
            }

            var james = new Person()
            {
                FirstName = "James",
                LastName = "Bond",
                BrainLevel = BrainLevel.sakto
            };
            
            var result = spec.IsSatisfiedBy(james) ? 
                                            "Yes, James is Sakto!" : 
                                            "No, James is not sakto!";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}

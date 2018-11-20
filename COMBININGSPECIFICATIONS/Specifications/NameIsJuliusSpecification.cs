using COMBININGSPECIFICATIONS.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace COMBININGSPECIFICATIONS.Specifications
{
    public class NameIsJuliusSpecification : Specification<Person>
    {
        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.FirstName == "Julius";
        }
    }
}

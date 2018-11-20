using SPECIFICATIONINTERFACE.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SPECIFICATIONINTERFACE.Implementations
{
    public class NameIsJuliusSpecification : Specification<Person>
    {
        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.FirstName == "Julius";
        }
    }
}

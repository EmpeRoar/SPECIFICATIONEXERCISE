using SPECIFICATIONINTERFACE.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace SPECIFICATIONINTERFACE.Implementations
{
    public class BrainLevelIsBrightSpecification : Specification<Person>
    {
        public override Expression<Func<Person, bool>> ToExpression()
        {
            return person => person.BrainLevel == BrainLevel.bright;
        }
    }
}

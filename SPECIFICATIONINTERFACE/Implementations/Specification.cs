using SPECIFICATIONINTERFACE.Models;
using System;
using System.Linq.Expressions;

namespace SPECIFICATIONINTERFACE.Implementations
{
    public abstract class Specification<T> 
    {
        public bool IsSatisfiedBy(T entity)
        {
            Func<T, bool> predicate = ToExpression().Compile();
            return predicate(entity);
        }

        public abstract Expression<Func<T, bool>> ToExpression();
    }

   

    
}

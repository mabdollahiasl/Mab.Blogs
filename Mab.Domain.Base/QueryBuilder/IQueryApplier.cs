using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mab.Domain.Base.QueryBuilder
{
    public interface IQueryApplier
    {
        IQueryable Apply<TEntity>(IQueryable query) where TEntity:class;
    }
}

using System;
using System.Linq.Expressions;

namespace RealEstateWebApi.Application.Extensions
{
	public static class QueryableExtension
	{
        public static IQueryable<T> Where<T>(this IQueryable<T> @this,bool condition,Expression<Func<T, bool>> @where)
        {
            return condition ? @this.Where(@where) : @this;
        }
    }
}


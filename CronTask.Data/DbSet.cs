using SqlSugar;
using System;
using System.Collections.Generic;
using System.Text;

namespace CronTask
{
    public class DbSet<T> : SimpleClient<T> where T : class, new()
    {
        public DbSet(SqlSugarClient context) : base(context)
        {

        }
        public List<T> GetByIds(dynamic[] ids)
        {
            return Context.Queryable<T>().In(ids).ToList(); ;
        }
    }
}

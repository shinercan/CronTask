using System;
using System.Collections.Generic;
using System.Text;
using CronTask.Model;
using SqlSugar;

namespace CronTask
{
    public class DbContext
    {
        public DbContext()
        {
            Db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "xx",
                DbType = DbType.SqlServer,
                IsAutoCloseConnection = true
            });
        }
        public SqlSugarClient Db;
        public DbSet<Himall_Members> StudentDb { get { return new DbSet<Himall_Members>(Db); } }
    }
}

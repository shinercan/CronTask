using PetaPoco.NetCore;
using Pomelo.Data.MySql;
using System;
using System.Threading;

namespace CronTask.Entities
{
    public class DbFactory : IDisposable
    {
        private static AsyncLocal<Database> dataContext = new AsyncLocal<Database>();
        public static Database Default
        {
            get
            {
                if (dataContext.Value == null)
                {
                    MySqlConnection connection = new MySqlConnection("server=120.79.84.18;database=himall_test;uid=himall_admin;password=himall@yw;");
                    dataContext.Value = new Database(connection);
                }
                return dataContext.Value;
            }
        }
        public void Dispose()
        {
            dataContext = null;
        }
    }
}
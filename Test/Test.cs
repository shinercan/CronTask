using SqlSugar;
namespace Test
{
    public class Test
    {
        public static void Main(string[] args)
        {
            var sqlsugar = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = "server=120.79.84.18;database=himall_test;uid=himall_admin;password=himall@yw;",
                IsAutoCloseConnection = true,
                DbType = DbType.MySql
            });
            sqlsugar.DbFirst.Where(o => o == "Himall_Members").SettingClassTemplate(o => { return o.Replace("Himall", ""); })
                .SettingClassTemplate(old =>
                {
                    return old;
                })
                .SettingNamespaceTemplate(old =>
                {
                    return old;
                })
                .SettingPropertyDescriptionTemplate(old =>
                {
                    return old;
                })
                .SettingPropertyTemplate(old =>
                {
                    return old;
                })
                .SettingConstructorTemplate(old =>
                {
                    return old;
                }).IsCreateAttribute();

        }
    }
}

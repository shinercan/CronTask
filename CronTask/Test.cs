using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CronTask
{
    public static class Test
    {
        public static void TestAddStr(IServiceCollection service, IConfiguration configuration)
        {
            string testConStr = configuration["ConStr:Default"];
        }
    }
}

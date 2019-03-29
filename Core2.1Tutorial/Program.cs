using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace Core2._1Tutorial
{
    public class Program
    {
        //Entry point
        public static void Main(string[] args)
        {
            //Calls method below
            CreateWebHostBuilder(args).Build().Run();
        }

        //Look at Startup.cs
        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}

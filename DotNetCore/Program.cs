﻿// <copyright file="Program.cs" company="Microsoft">
// Open source
// </copyright>

namespace DotNetCore
{
    using Microsoft.AspNetCore;
    using Microsoft.AspNetCore.Hosting;

    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                // Needed for a bug in Kestrel
                .UseUrls("http://0.0.0.0:80")
                .Build();
    }
}

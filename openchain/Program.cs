﻿using System.IO;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Openchain.Server;

namespace Openchain
{
    public class Program
    {
        public static void Main(string[] args) =>
            new WebHostBuilder()
            .UseKestrel()
            .UseContentRoot(Directory.GetCurrentDirectory())
            .UseStartup<Startup>()
            .UseUrls("http://0.0.0.0:8080")
            .Build()
            .Run();
    }
}

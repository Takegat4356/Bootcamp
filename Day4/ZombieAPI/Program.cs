using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace ZombieAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();

           //added from ZombieData Exercise 
           StatusRepository repository = new StatusRepository();
           List<Status> statuses = repository.GetAll(); 

            foreach (Status status in statuses)
            {
                Console.WriteLine (status.FirstName + " " + 
                status.LastName + " has a status of " + 
                status.StatusDescription);
            }
            //added from ZombieData Exercise 
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}

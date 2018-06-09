
using System;
using System.Collections.Generic;

namespace Zombie.Simulator4
{
    class Program
    {
        static void Main(string[] args)
        {
           //instantiate 
           StatusRepository repository = new StatusRepository();
           List<Status> statuses = repository.GetAll(); 

            foreach (Status status in statuses)
            {
                Console.WriteLine (status.FirstName + " " + 
                status.LastName + "has status" + 
                status.StatusDescription);
            }
        }
    }
}

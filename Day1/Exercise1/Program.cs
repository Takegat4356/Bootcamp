using System;

namespace Exercise1
{
    class Program
    {
        static void Main(string[] args)
        {
        int status = 2;
        
            if (status == 1)
            {
            Console.WriteLine("Alive");
            }
            else if (status == 2)
            {
            Console.WriteLine("Zombie");
            }
            else if (status == 3)
            {
            Console.WriteLine("Dead");
            }
            else if (status == 4)
            {
            Console.WriteLine("Unknown");
            }
            Console.WriteLine("Exact value of a is: {0}", status);
            Console.ReadLine();
        }
    }
}

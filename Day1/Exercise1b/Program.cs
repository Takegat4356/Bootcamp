using System;

namespace Exercise1b
{
    class Program
    {
        static void Main(string[] args)
        {
            int caseSwitch = 3;

            switch (caseSwitch)
            {
                case 1: 
                    Console.WriteLine("Alive");
                    break;
                case 2:
                    Console.WriteLine("Zombie");
                    break;
                case 3:
                    Console.WriteLine("Dead");
                    break;
                default:
                    Console.WriteLine("Unknown");
                    break;
            }
        }
    }
}

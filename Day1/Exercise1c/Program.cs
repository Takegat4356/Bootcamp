using System;

namespace Exercise1c
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            //Continue looping until internal condition is met
            //while loop
            while (true)
            {
                int value = ++index;
                //Check to see if the limit is hit.
               
                int status = 2;
        
                if (status == 1)
                {
                Console.WriteLine("Alive");
                break;
                }
                else if (status == 2)
                {
                Console.WriteLine("Zombie");
                break;
                }
                else if (status == 3)
                {
                Console.WriteLine("Dead");
                break;
                }
                else if (status == 4)
                {
                Console.WriteLine("Unknown");
                break;
                }  
            Console.WriteLine("Exact value of a is: {0}", status);
            Console.ReadLine();                 
            }                    
        }       
    }
}

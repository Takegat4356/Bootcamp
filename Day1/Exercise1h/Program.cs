using System;

namespace Exercise1h
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] status = new int[]{3, 4, 1, 4, 2, 3, 4};            

            //status = 1 for Alive
            //status = 2 for Zombie
            //status = 3 for Dead
            //status = 4 for Unknown
            //4,2,4,2,1,4,2
            int counter = 0;
            
            foreach (int i in status)
            
                if (status[counter] == 1)
                {
                    Console.WriteLine("Alive");                    
                }
                else if (status[counter] == 2)
                {
                    Console.WriteLine("Zombie");                  
                }
                else if (status[counter] == 3)
                {
                    Console.WriteLine("Dead");
                }
                else if (status[counter] == 4)
                {
                    Console.WriteLine("Unknown");                    
                }           
                counter++;     
            }
        }
    }
}

using System;

namespace Exercise1d
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] array = new int[5];

            array[0] = 1;
            array[1] = 2;
            array[2] = 3;
            array[3] = 4;
            array[4] = 5;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] >= 4)
                {
                    Console.WriteLine(array[i]);
                }
                else if (array[i] >= 2 || array[i] <4)
                {
                    Console.WriteLine(array[i]);
                }
               
            }
            Console.ReadKey();
            
           /* int index = 0;
            //Continue looping until internal condition is met
            //for loop
            for (i = 0; i <= 4; i++)
            {
                int value = ++index;
                //Check to see if the limit is hit.
               
                int status = 3;
        
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
            Console.ReadLine(); */                
            }      
        }
    }
}

using System;

namespace Exercise1g
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] status = new int[4];

            status[0] = 1;
            status[1] = 2;
            status[2] = 3;
            status[3] = 4;

            int i = 0; //status [0] = 1 for Alive
            //int i = 1; //status [1] = 2 for Zombie
            //int i = 2; //status [2] = 3 for Dead
            //int i = 3; //status [3] = 4 for Unknown

            do
            {
                if (status[i] == 1)
                {
                    Console.WriteLine("Alive");
                    break;
                }
                else if (status[i] == 2)
                {
                    Console.WriteLine("Zombie");
                    break;
                }
                else if (status[i] == 3)
                {
                    Console.WriteLine("Dead");
                    break;
                }
                else if (status[i] == 4)
                {
                    Console.WriteLine("Unknown");
                    break;
                }
                 i++;
            } while (i < status.Length);

            Console.ReadKey();  
        }
    }
}

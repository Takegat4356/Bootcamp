using System;

namespace Exercise1e
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

            //for (int i = 0; i < status.Length; i++) //status [0] = 1 for Alive
            //for (int i = 1; i < status.Length; i++) //status [1] = 2 for Zombie
            for (int i = 2; i < status.Length; i++) //status [2] = 3 for Dead
            //for (int i = 3; i < status.Length; i++) //status [3] = 4 for Unknown
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
            }
            Console.ReadKey();  
        }
    }
}

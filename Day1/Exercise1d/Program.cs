using System;

namespace Exercise1d
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] status = new int[5];

            status[0] = 1;
            status[1] = 2;
            status[2] = 3;
            status[3] = 4;
            status[4] = 5;

            for (int i = 0; i < status.Length; i++)
            {
                if (status[i] >= 4)
                {
                    Console.WriteLine(status[i]);
                }
                else if (status[i] >= 2 || status[i] <4)
                {
                    Console.WriteLine(status[i]);
                }                           
            }
            Console.ReadKey();
        }
    }
}

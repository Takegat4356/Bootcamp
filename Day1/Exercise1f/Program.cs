﻿using System;

namespace Exercise1f
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

            while (i < status.Length)
            {
                if (status[i] == 1)
                {
                    Console.WriteLine("Alive");
                }
                else if (status[i] == 2)
                {
                    Console.WriteLine("Zombie");
                }
                else if (status[i] == 3)
                {
                    Console.WriteLine("Dead");
                }
                else if (status[i] == 4)
                {
                    Console.WriteLine("Unknown");
                }
                 i++;
            }
            Console.ReadKey();  
        }
    }
}

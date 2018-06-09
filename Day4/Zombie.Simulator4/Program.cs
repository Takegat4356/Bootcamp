namespace Zombie.Simulator4
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
            int i = 0;

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

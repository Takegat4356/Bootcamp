using System;

namespace Zombie.Simulator
{
    class Program
    {        
        static void Main(string[] args)
        {
            Person Mary = new Person("Mary"); // new instance of the Person class
        }        
    }
    public class Person //this can also be in another file
        {
                public Person()
                {
                    Console.Write ("A new person has been created.");
                }
        }  

}

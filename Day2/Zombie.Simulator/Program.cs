using System;

namespace Zombie.Simulator
{
    class Program
    {        
        static void Main(string[] args)
        {
            Person Mary = new Person(); // new instance of the Person class
            Person person1 = new Person();
            person1.DistanceTraveled = 5;
            Console.WriteLine(person1.DistanceTraveled);
        }        
    }
    public class Person //this can also be in another file
        {
                public int DistanceTraveled  {get; set;}
                public Person()
                {
                    Console.Write ("A new person has been created.");
                }
        }  

}

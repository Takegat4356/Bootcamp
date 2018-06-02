using System;

namespace Zombie.Simulator3
{
    class Program
   {        
        static void Main(string[] args)
        {
            //Class was on Saturday 5/26/2018
            //Person Mary = new Person(); // 1st in class Exercise new instance of the Person class
            //Person person1 = new Person();// 2nd in class Exercise new instance of the Person class
            //person1.DistanceTraveled = 5;
            //Console.WriteLine(person1.DistanceTraveled);
            //person1.Walk(10);
            //Console.WriteLine (person1.DistanceTraveled);

            //Person person2 = new Person();
            //person2.Walk(10);
            //Console.WriteLine (person2.DistanceTraveled);
            //Console.WriteLine (person1.DistanceTraveled);

            //local variables because they are inside of a method.
            //you create the variable within the method, it stays only within the method

            Zombie Zombie = new Zombie ();
            Zombie.Walk(100);
            Console.WriteLine (Zombie.DistanceTraveled);

            Human human = new Human ();
            human.Run(50);
            human.Walk(50);
            Console.WriteLine (human.DistanceTraveled);

        }        
    }
 
}

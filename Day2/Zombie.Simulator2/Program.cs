﻿using System;

namespace Zombie.Simulator2
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
    public abstract class Person //this can also be in another file
        {
                public int DistanceTraveled  {get; set;}
                public Person()
                {
                    Console.Write ("A new person has been created. ");
                }

                public virtual void Walk(int minutes)
                {
                    //use void, when we are not running anything
                    //virtual - can be overidden
                    int distance = CalculateDistance(minutes);
                    DistanceTraveled = DistanceTraveled + minutes * 2;
                    //just a random calculation
                    //local variable in this method
                    //we'll just use int for now instead of decimal
                }

                public int CalculateDistance(int minutes)
                {
                    //the details you want to hide, make private
                    return minutes *2;
                }
        }  

        public sealed class Human: Person
        {
             // Person fields, properties, methods and events are inherited
             // New Human fields, properties, methods and events go here...
        
                public void Run(int minutes)
                {
                    //use void, when we are not running anything
                    //virtual - can be overidden
                    int distance = CalculateDistance(minutes);
                    DistanceTraveled = DistanceTraveled + minutes * 8;
                    //just a random calculation
                    //local variable in this method
                    //we'll just use int for now instead of decimal
                }        
        }

         public sealed class Zombie: Person
        {
             // Person fields, properties, methods and events are inherited
             // New Zombie fields, properties, methods and events go here...
        
                public override void Walk(int minutes)
                {
                    //use void, when we are not running anything
                    //virtual - can be overidden
                    int distance = CalculateDistance(minutes);
                    DistanceTraveled = DistanceTraveled + minutes * 1;
                    //just a random calculation
                    //local variable in this method
                    //we'll just use int for now instead of decimal
                }        
        }
}

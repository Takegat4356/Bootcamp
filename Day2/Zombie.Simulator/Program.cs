using System;

namespace Zombie.Simulator
{
    class Program
    {        
        static void Main(string[] args)
        {
            //Class was on Saturday 5/26/2018
            Person Mary = new Person(); // 1st in class Exercise new instance of the Person class
            Person person1 = new Person();// 2nd in class Exercise new instance of the Person class
            person1.DistanceTraveled = 5;
            Console.WriteLine(person1.DistanceTraveled);
            person1.Walk(10);
            Console.WriteLine (person1.DistanceTraveled);

            Person person2 = new Person();
            person2.Walk(10);
            Console.WriteLine (person2.DistanceTraveled);
            Console.WriteLine (person1.DistanceTraveled);

            //local variables because they are inside of a method.
            //you create the variable within the method, it stays only within the method
        }        
    }
    public class Person //this can also be in another file
        {
                public int DistanceTraveled  {get; set;}
                public Person()
                {
                    Console.Write ("A new person has been created. ");
                }
                public void Walk(int minutes)
                {
                    //use void, when we are not running anything
                    int distance = CalculateDistance(minutes);
                    DistanceTraveled = DistanceTraveled + minutes * 2;
                    //just a random calculation
                    //local variable in this method
                }

                private int CalculateDistance(int minutes)
                {
                    //the details you want to hide, make private
                    return minutes *2;
                }
        }  

}

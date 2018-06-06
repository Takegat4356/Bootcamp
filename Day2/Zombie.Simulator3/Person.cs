using System;

namespace Zombie.Simulator3
{
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
}
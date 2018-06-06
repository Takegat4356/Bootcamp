namespace Zombie.Simulator3
{
public sealed class Human: IPerson
        {
             public decimal DistanceTraveled {get;set;}           
             // Person fields, properties, methods and events are inherited
             // New Human fields, properties, methods and events go here...
        
                public void Run(int minutes)
                {
                    //use void, when we are not running anything
                    //virtual - can be overidden
                    
                    DistanceTraveled = DistanceTraveled + minutes * 8;
                    //just a random calculation
                    //local variable in this method
                    //we'll just use int for now instead of decimal
                }   

                public void Walk(decimal minutes)
                {
                    //use void, when we are not running anything
                    //virtual - can be overidden
                   
                    DistanceTraveled = DistanceTraveled + minutes * 1;
                    //just a random calculation
                    //local variable in this method
                    //we'll just use int for now instead of decimal
                }          
        }
}
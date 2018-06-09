namespace Zombie.Simulator4
{

        public interface IPerson
        {
            decimal DistanceTraveled {get;set;}

            void Walk (decimal minutes);

        }

}
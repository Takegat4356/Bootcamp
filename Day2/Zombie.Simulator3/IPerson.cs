namespace Zombie.Simulator3
{

        public interface IPerson
        {
            decimal DistanceTraveled {get;set;}

            void Walk (decimal minutes);

        }

}
namespace Zombie.Simulator3
{

        public interface IPerson
        {
            decimal DistranceTraveled {get;set;}

            void Walk (decimal minutes);
        }

}
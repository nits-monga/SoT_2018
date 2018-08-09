namespace Vehicle
{
    public class Car
    {
        // TODO: Refactor this to practice the 'Liskov's Substitution' Principle
        // TODO: Refactor this further to practice the 'Interface segregation' Principle
        public BigEngine Engine {get; private set;}
        public byte PetrolLitresConsumed { get; private set; }
        public double MetresTraveled { get; private set; }

        public Car()
        {
            MetresTraveled = 0;
            PetrolLitresConsumed = 0;
            Engine = new BigEngine();
        }

        public void Start()
        {
            Engine.Start();
        }

        public void Stop()
        {
            Engine.Stop();
        }

        public void MoveForward()
        {
            if (!Engine.Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled +=0.1;
            PetrolLitresConsumed++;
        }

        public void MoveBackward()
        {
            if (!Engine.Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled-=0.1;
            PetrolLitresConsumed++;
        }

        public void Service()
        {
            Engine.Replace();
        }
    }
}

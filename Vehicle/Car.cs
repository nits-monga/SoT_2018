namespace Vehicle
{
    public class Car
    {
        // TODO: Refactor this to practice the 'Open/Closed' principle
        // TODO: Update your unit tests accordingly

        public BigEngine Engine;
        public byte PetrolLitresConsumed;
        public double MetresTraveled;
        public bool Started;

        public Car()
        {
            MetresTraveled = 0;
            PetrolLitresConsumed = 0;
            Engine = new BigEngine();
        }

        public void Start()
        {
            if (Started)
            {
                throw new CarAlreadyStartedException();
            }
            Started = true;

            // TODO: Refactor this to practice the 'Single Responsibility' principle
            // TODO: Update your unit tests accordingly
        }

        public void Stop()
        {
            if (!Started)
            {
                throw new CarNotStartedException();
            }

            Started = false;
        }

        public void MoveForward()
        {
            if (!Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled +=0.1;
            PetrolLitresConsumed++;
        }

        public void MoveBackward()
        {
            if (!Started)
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

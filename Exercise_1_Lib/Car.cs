namespace Exercise_1_Lib
{
    public class Car
    {
        private readonly BigEngine _engine;

        private byte _petrolLitresConsumed;

        public Car()
        {
            MetresTraveled = 0;
            _petrolLitresConsumed = 0;
            Started = false;

            // TODO: Refactor this to practice the 'Open/Closed' principle
            // TODO: Update your unit tests accordingly
            _engine = new BigEngine();
        }

        public bool Started { get; private set; }
        public double MetresTraveled { get; private set; }

        public int PetrolLitresConsumed => _petrolLitresConsumed;

        public void Start()
        {
            if (Started)
            {
                throw new CarAlreadyStartedException();
            }
            Started = true;
            _engine.Start();

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
            _engine.Stop();
        }

        public void MoveForward()
        {
            if (!Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled+=0.1;
            _petrolLitresConsumed++;
        }

        public void MoveBackward()
        {
            if (!Started)
            {
                throw new CarNotStartedException();
            }

            MetresTraveled-=0.1;
            _petrolLitresConsumed++;
        }

        public void Service()
        {
            _engine.Replace();
        }
    }
}

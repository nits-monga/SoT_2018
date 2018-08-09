using System;

namespace Vehicle
{
    public class SmallEngine
    {
        private readonly double _capacity;

        public bool Started { get; private set; }

        public SmallEngine()
        {
            _capacity = 2.0;
        }

        public void Replace()
        {
            throw new NotImplementedException();
        }

        public void Start()
        {
            if (Started)
            {
                throw new CarAlreadyStartedException();
            }
            Started = true;
        }

        public void Stop()
        {
            if (!Started)
            {
                throw new CarNotStartedException();
            }

            Started = false;
        }
    }
}
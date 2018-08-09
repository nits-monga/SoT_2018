namespace Vehicle
{
    [System.Serializable]
    public class CarAlreadyStartedException : System.Exception
    {
        public CarAlreadyStartedException() { }
        public CarAlreadyStartedException(string message) : base(message) { }
        public CarAlreadyStartedException(string message, System.Exception inner) : base(message, inner) { }
        protected CarAlreadyStartedException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
using System;

namespace Exercise_1_Lib
{
    [System.Serializable]
    public class CarNotStartedException : System.Exception
    {
        public CarNotStartedException() { }
        public CarNotStartedException(string message) : base(message) { }
        public CarNotStartedException(string message, System.Exception inner) : base(message, inner) { }
        protected CarNotStartedException(
            System.Runtime.Serialization.SerializationInfo info,
            System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}
using System;

namespace Vehicle
{
    public interface IEngine
    {
        bool Started { get; }
        
        void Replace();

        void Start();

        void Stop();
    }
}
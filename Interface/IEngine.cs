using System;


namespace Interface
{
   interface IEngine
    {
      void Start();
      void Stop();
      int Weight { get; }
      int Power { get; }
    }
}

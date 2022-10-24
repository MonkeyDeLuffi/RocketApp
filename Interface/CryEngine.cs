using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    class CryEngine : IEngine
    {
        public int Weight { get; }

        public int Power { get; }

        public CryEngine()
        {
            Weight = 380;
            Power = 560;
           
        }

        public void Start()
        {
            Console.WriteLine("ohohohoh");
        }

        public void Stop()
        {
            Console.WriteLine("Da Pobachenya");
        }
    }
}

using System;


namespace Interface
{
     class Rocket
    {
        public RocketHeader Header { get; set; }
        public IEngine Engine { get; set; }

        public int Weight
        {
            get { return Header.GetWeight() + Engine.Weight; }
        }

    }
}

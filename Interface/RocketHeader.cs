using System;


namespace Interface
{
   class RocketHeader
    {
        public int Cosmonauts { get; set; }
        public int MassShell { get; set; }

        public RocketHeader()
        {
            Cosmonauts = 3;
            MassShell = 5000;
        }
        
        public int GetWeight()
        {
            return (Cosmonauts * 80) + MassShell;
        }

        public void SendMessage(string message)
        {
            Console.WriteLine("Повідомлення:");
            Console.WriteLine(message);
            Console.WriteLine("Відправлено");
        }
    }
}

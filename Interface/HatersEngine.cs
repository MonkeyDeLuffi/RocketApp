using System;


namespace Interface
{
    class HatersEngine : IEngine
    {
        public int Weight { get; }

        public int Power { get; }
        public string GetCopyWrite { get;}

        public HatersEngine()
        {
            Weight = 322;
            Power = 228;
            GetCopyWrite = "Alex Edition";
        }

        public void Start()
        {
            Console.WriteLine("Вщу полетіли,тяга на максимум");
        }

        public void Stop()
        {
            Console.WriteLine("Стоп,oстиваеєм");
        }
    }
}

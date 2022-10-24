using System;


namespace Interface
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            var rocket = new Rocket();

            rocket.Header = new RocketHeader();
            rocket.Engine = new HatersEngine();

            var  rocket2 = new Rocket();

            rocket2.Header = new RocketHeader();
            rocket2.Engine = new CryEngine();


            int result = SpecialNasaMethod(rocket.Engine.Power, rocket.Weight);
            Console.WriteLine($"Максимальна швидкість: {result}"); 

            if (result > 200)
            {
                rocket.Engine.Start();
            }
            else
            {
                Console.WriteLine("Сорі, двіга не вивозить");
            }
            int result2 = SpecialNasaMethod(rocket2.Engine.Power, rocket2.Weight);
            Console.WriteLine($"Максимальна швидкість: {result2}");

            if (result2 > 200)
            {
                rocket2.Engine.Start();
            }
            else
            {
                Console.WriteLine("Сори двіга не вивозить");
            }
            Console.ReadLine();
        }


        public static int SpecialNasaMethod(int power, int mass)
        {
            return (mass / power * 10) + 82;
        }
    }
}
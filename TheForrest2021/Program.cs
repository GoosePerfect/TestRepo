using System;
using System.Collections.Generic;

namespace TheForrest2021
{
    class Program
    {
        static void Main(string[] args)
        {

            // Dagtid eller Nattetid
            bool day = true;


            List<Animal> forrest = new List<Animal>();
            forrest.Add(new Owl(7, true, 34));
            forrest.Add(new Horse(740, false, 70));
            forrest.Add(new Dolphin(432, false, 95));


            while (true)
            {
                day = Menu(day);

                foreach (Animal a in forrest)
                {
                    a.Move(a.Nocturnal, day);
                    Console.WriteLine("Vikt: " + a.Weight);
                    Console.WriteLine("Nattdjur: " + a.Nocturnal);

                    if(a is Owl)
                    {
                        Console.WriteLine("Vingbredd: " + ((Owl)a).Wingspan + "cm");
                    }

                    if (a is Horse)
                    {
                        Console.WriteLine("Hö per dag: " + ((Horse)a).HayPerDay + "kg");
                    }

                    if (a is Dolphin)
                    {
                        Console.WriteLine("Fiskar per dag: " + ((Dolphin)a).FishPerDay + "st");
                    }
                }


            }

        }


        public static bool Menu(bool day)
        {
            Console.WriteLine("Välj [D]ag eller [N]att\n");
            Console.WriteLine($"Nu är det {(day ? "dag" : "natt")}");

            string key = Console.ReadKey().Key.ToString();
            switch (key)
            {
                case "D":
                    day = true;
                    break;
                case "N":
                    day = false;
                    break;

            }

            Console.ForegroundColor = day ? ConsoleColor.Black : ConsoleColor.White;
            Console.BackgroundColor = day ? ConsoleColor.White : ConsoleColor.Black;
            Console.Clear();

            return day;
        }

    }
}

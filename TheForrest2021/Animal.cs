using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TheForrest2021
{
    class Animal
    {

        public int Weight { get; set; }

        public bool Nocturnal { get; set; }

        public virtual void Move(bool nocturnal, bool day)
        {
            Console.WriteLine("Djuret är antingen vaket eller sover");
        }

    }

    class Owl : Animal
    {
        public int Wingspan { get; set; }

        public Owl(int weight, bool isNocturnal, int wingspan)
        {
            Wingspan = wingspan;
            Weight = weight;
            Nocturnal = isNocturnal;
        }


        public override void Move(bool nocturnal, bool day)
        {
            if(nocturnal == true && day == false)
            {
                Console.WriteLine("Ugglan flyger bland träden och letar mat");
            }
            else
            {
                Console.WriteLine("Ugglan sover i ett hål i trädet");
            }
        }
    }

    class Dolphin : Animal
    {
        public int FishPerDay { get; set; }

        public Dolphin(int weight, bool isNocturnal, int fishPerDay)
        {
            FishPerDay = fishPerDay;
            Weight = weight;
            Nocturnal = isNocturnal;
        }


        public override void Move(bool nocturnal, bool day)
        {
            if (nocturnal == false && day == true)
            {
                Console.WriteLine("Delfinen simmar i sjön");
            }
            else
            {
                Console.WriteLine("Delfinen flyter sovande i sjön");
            }
        }

    }

    class Horse : Animal
    {
        public int HayPerDay { get; set; }

        public Horse(int weight, bool isNocturnal, int hayPerDay)
        {
            HayPerDay = hayPerDay;
            Weight = weight;
            Nocturnal = isNocturnal;
        }

        public override void Move(bool nocturnal, bool day)
        {
            if (nocturnal == false && day == true)
            {
                Console.WriteLine("Hästen betar hö");
            }
            else
            {
                Console.WriteLine("Hästen sover i stallet");
            }
        }
    }
}

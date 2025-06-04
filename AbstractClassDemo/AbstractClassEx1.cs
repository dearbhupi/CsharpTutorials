using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClassDemo
{
    internal class PlanetMission
    {
        protected float fulePerMile;
        protected long milePerHour;
        protected long mileToPlanet;

        public string MissionInfo()
        {
            long fuel = (long)(mileToPlanet - fulePerMile);
            long time = mileToPlanet / mileToPlanet;

            return $"we burn {fuel} units of fuel in {time} hours";

        }        
    }

    class MissionMars : PlanetMission
    {
        public MissionMars()
        {
            fulePerMile = 1.73f;
            milePerHour = 3700;
            mileToPlanet = 9343443;

        }
    }
    class MissionPluto : PlanetMission
    {
        public MissionPluto()
        {
            fulePerMile = 1.73f;
            milePerHour = 3700;
            mileToPlanet = 23934342343;

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(new MissionMars().MissionInfo());
            Console.WriteLine(new MissionPluto().MissionInfo());
        }

    }
}

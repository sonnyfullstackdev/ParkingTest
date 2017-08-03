using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTest.BizObject
{
    public class ParkingStructureService
    {
        public ParkingStructureService()
        {
            //build your parking structure
        }

        public void BuildParkingStructure(int levels, int generalSpots, int frequentFlyerSpots = 10, int valetSpots = 10)
        {

            Console.WriteLine($"Levels: {levels}, General Spots: {generalSpots}, FrequentFlyer Spots: {frequentFlyerSpots}, Valet Spots: {valetSpots}.");
            Console.WriteLine($"Total Spots: {generalSpots + frequentFlyerSpots + valetSpots * levels}");
        }
    }
}



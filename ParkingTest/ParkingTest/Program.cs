using ParkingTest.BizObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingTest
{
    class Program
    {
         static void Main(string[] args)
        {
            ParkingStructureService pss = new ParkingStructureService();

            //int levels, int generalSpots, int frequentFlyerSpots = 10, int valetSpots = 10
            Console.WriteLine("How many levels?");
            string levels = Console.ReadLine();
            Console.WriteLine("How many general spots?");
            string genspots = Console.ReadLine();
            Console.WriteLine("How many general spots?");
            string ffspots = Console.ReadLine();
            Console.WriteLine("How many general spots?");
            string vspots = Console.ReadLine();
            Console.WriteLine("How many general spots?");
            


            int  _ilevels = 0, _igenspots = 0, _iffspots = 0, _ivspots = 0;

            int.TryParse(levels, out _ilevels);
            int.TryParse(genspots, out _igenspots);
            int.TryParse(ffspots, out _iffspots);
            int.TryParse(vspots, out _ivspots);

            pss.BuildParkingStructure(_ilevels, _igenspots, _iffspots, _ivspots);

            Console.ReadLine();
        }
    }
    
}

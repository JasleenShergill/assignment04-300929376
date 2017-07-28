using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Name: Jasleen
 * Date: july 28,2017
 * Description: driver program class
 * Version:0.1 
 * */
namespace assignment04_300929376
{
    class Program
    {
        static void Main(string[] args)
        {
            GiantPlanet giantPlanet = new GiantPlanet("Venus", 15674, 617.8, "GAS");
            TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 14563, 6.3452, true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}

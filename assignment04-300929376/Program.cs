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
 * https://github.com/JasleenShergill/assignment04-300929376
 * */
namespace assignment04_300929376
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("######################################### PLANET INFORMATION ###################################################");
            Console.WriteLine("############################################-JASLEEN- 300929376 ################################################");
            Console.WriteLine("LET'S KNOW ABOUT PLANETS");
            Console.WriteLine("A Planet is a celestial body distinguished from the fixed stars by having an apparent motion of its own (including the moon and sun), especially with reference to its supposed influence on people and events.");

            Console.WriteLine("1) Mercury,\n\n\t2) Venus,\n\n\t\t3) Earth,\n\n\t\t\t4) Mars,\n\n\t\t\t\t5) Jupiter,\n\n\t\t\t\t\t 6)Saturn,\n\n\t\t\t\t\t\t7)Uranus, \n\n\t\t\t\t\t\t\t8)Neptune");
            Console.WriteLine("#############################################################################################################");
            GiantPlanet giantPlanet = new GiantPlanet("Venus", 15674, 617.8, "GAS");
           TerrestrialPlanet terrestrialPlanet = new TerrestrialPlanet("Mercury", 14563, 6.3452, true);
            giantPlanet.ToString();
            terrestrialPlanet.ToString();
            Console.WriteLine("#############################################################################################################");
            Program.WAITFORANYKEY();
        }
        static void WAITFORANYKEY()
        {
            Console.ReadLine();
        }
    }
}

﻿using System;
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
            Console.WriteLine("\n @-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@- PLANET INFORMATION @-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@\n");
            Console.WriteLine("LET'S KNOW ABOUT PLANETS");
            Console.WriteLine("\n \n  ");
            Console.WriteLine("A Planet is a celestial body distinguished from the fixed stars by having an apparent motion of its own (including the moon and sun), especially with reference to its supposed influence on people and events.");
            Console.WriteLine("\n\n");
            Console.WriteLine("1) Mercury,\n\n\t2) Venus,\n\n\t\t3) Earth,\n\n\t\t\t4) Mars,\n\n\t\t\t\t5) Jupiter,\n\n\t\t\t\t\t 6)Saturn,\n\n\t\t\t\t\t\t7)Uranus, \n\n\t\t\t\t\t\t\t8)Neptune");
            Console.WriteLine("\n @-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@-@\n");
            GiantPlanet giantPlanet = new GiantPlanet("Venus", 15674, 617.8, "GAS");
            Console.WriteLine("\n");
            
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

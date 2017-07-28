using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Jasleen
 * Date: July 28,2017
 * Description: this is inhert of planet class
 * Version:0.1 created GiantPlanet class
 * https://github.com/JasleenShergill/assignment04-300929376
 * */
namespace assignment04_300929376
{
  
    //  GiantPlanet class
 
    public class GiantPlanet : Planet, IHasMoon, IHasRings
    {
        //this is a private instance variable
        private string _type;

        //this is a public properties


       /* constructor
        
          GiantPlanet is a constrctor
       which will take 3 arguments
         name(string) - diameter(double) - mass(double)
       
       <param name="name"></param>
         <param name="diameter"></param>
        <param name="mass"></param>*/
        public GiantPlanet(string name, double diameter, double mass, string type)
            : base(name, diameter, mass)
        {
            this._type = type;
        }
        public bool HasMoon()
        {
            if (MoonCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool HasRings()
        {
            if (RingCount > 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
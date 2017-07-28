using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Jasleen
 * Date: July 28,2017
 * Description: TerrestrialPlanet class which  will is inherted  from Planet 
 * Version:0.1 created GiantPlanet class
 * */
namespace assignment04_300929376
{
   
    // Terrestrial planet class
    
    public class TerrestrialPlanet : Planet, IHasMoon, IHabital
    {
        //this is a private instance variable
        private bool _oxygen;
        // this is a public properties

       /*
          Constructor for Terrestrial planet
         It will accept four argument 
         *name(string) 
         * diameter(double) 
         * mass(double) 
         * oxygen(bool) 
        
       <param name="name"></param>
         <param name="diameter"></param>
        <param name="mass"></param>
         <param name="oxygen"></param>
        Constructor*/
        public TerrestrialPlanet(string name, double diameter, double mass, bool oxygen)
            : base(name, diameter, mass)
        {
            this._oxygen = oxygen;
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

        public bool Habitable()
        {
            if (_oxygen == true)
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
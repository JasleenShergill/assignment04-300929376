using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*
 * Name: Jasleen
 * Date: july 28,2017
 * Description: driver program class
 * Version:0.1 
 * https://github.com/JasleenShergill/assignment04-300929376
 * */

namespace assignment04_300929376
{
  
    ///  abstract Planet class
  
    public abstract class Planet
    {
        // this is a private instance variable 
        private double _diameter;
        private string _name;
        private double _mass;
        private double _orbitalPlanet;
        private int _moonCount;    
        private int _ringCount;
        private double _rotationPeriod;

        //this is a public properties
        public double Diameter
        {
            get { return this._diameter; }

        }

        public double Mass
        {
            get { return this._mass; }

        }

        public int MoonCount
        {
            get
            {
                return this._moonCount;
            }
            set
            {
                this._moonCount = value;
            }
        }

        public string Name
        {
            get { return this._name; }

        }

        public double OrbitalPeriod
        {
            get
            {
                return this._orbitalPlanet;
            }
            set
            {
                this._orbitalPlanet = value;
            }
        }

        public int RingCount
        {
            get
            {
                return this._ringCount;
            }
            set
            {
                this._ringCount = value;
            }
        }

        public double RotationalPeriod
        {
            get
            {
                return this._rotationPeriod;
            }
            set
            {
                this._rotationPeriod = value;
            }
        }

        /* Constructor used is as follow
      
            Planet class use this as a main constructor
            taking three parameters:
           * name(string)
           * mass(double)
           * diameter(double)      
        
        <param name="name"></param>
        <param name="diameter"></param>
         <param name="mass"></param>*/

        public Planet(string name, double diameter, double mass)
        {
            this._name = name;
            this._diameter = diameter;
            this._mass = mass;
        }




        public override string ToString()
        {
            string output =  this.Name + " has a diameter of " + this.Diameter + "km " + " and has a mass of : " + this.Mass + " x 10^24 kg";
            Console.WriteLine(output);
            return output;
        }


    }
}
/// Reptile.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different reptile objects
/// </summary>
namespace AnimalPark
{
    abstract class Reptile : Animal
    {
        private readonly bool livesInWater;
        private readonly double weight;
        public abstract FoodSchedule FoodSchedule { get; }

        public Reptile(double weight, bool livesInWater)
        {
            this.weight = weight;
            this.livesInWater = livesInWater;

        }

        /// <summary>
        /// CreateReptile: Method that will be used to created different reptile objects
        /// </summary>
        /// 

        public static Reptile CreateReptile(ReptileSpecies species, double weight, bool livesInWater)
        {

            Reptile reptile = null;
            switch (species)
            {
                case ReptileSpecies.Snake:
                    reptile = new Snake(weight, livesInWater);
                    break;
                case ReptileSpecies.Lizard:
                    reptile = new Lizard(weight, livesInWater);
                    break;
                case ReptileSpecies.Turtle:
                    reptile = new Turtle(weight, livesInWater);
                    break;

            }
            return reptile;
        }

        /// <summary>
        /// ToString: Method to print out info about reptiles
        /// </summary>
        public override string GetExtraInfo()
        {

            string strOut = base.GetExtraInfo();
            strOut += String.Format("\n\n{0,-20}{1,10}\n{2,-20}{3,10}\n\n",
                "Lives in water?:",livesInWater,"Weight:",weight);
            return strOut;
        }
    }


            
    
}

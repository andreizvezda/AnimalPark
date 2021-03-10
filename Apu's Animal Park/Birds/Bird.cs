/// Bird.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate bird objects
/// </summary>
namespace AnimalPark
{
    abstract class Bird : Animal
    {
        private readonly double wingSpan;
        private readonly double lengthOfBeak;
        public abstract FoodSchedule FoodSchedule { get; }

        public Bird(double wingSpan, double lengthOfBeak)
        {
            this.wingSpan = wingSpan;
            this.lengthOfBeak = lengthOfBeak;
        }
        /// <summary>
        /// CreateBird: Method that will be used to create different bird objects
        /// </summary>
        public static Bird CreateBird(BirdsSpecies species, double wingSpan, double lengthOfBeak)
        {

            Bird bird = null;
            switch (species)
            {
                case BirdsSpecies.Dove:
                    bird = new Dove(wingSpan, lengthOfBeak);
                    break;
                case BirdsSpecies.Pigeon:
                    bird = new Pigeon(wingSpan, lengthOfBeak);
                    break;
                case BirdsSpecies.Eagle:
                    bird = new Eagle(wingSpan, lengthOfBeak);
                    break;


            }
            return bird;
        }

        /// <summary>
        /// ToString: Method to print out info about bird objects
        /// </summary>
        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();
            strOut += String.Format("\n\n{0,-20}{1,10}\n{2,-16}{3,10}\n\n",
                "Wingspan (cm):",wingSpan,"Length of a beak:",lengthOfBeak);
            return strOut;
        }
    }
}

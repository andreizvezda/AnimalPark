﻿/// Mammal.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different mammal objects
/// </summary>
namespace AnimalPark
{
    abstract class Mammal : Animal
    {
        private readonly int numOfTeeth;
        private readonly double tailLength;
        public abstract FoodSchedule FoodSchedule { get; }

        public Mammal(int numOfTeeth, double tailLength)
        {
            this.numOfTeeth = numOfTeeth;
            this.tailLength = tailLength;
        }
        /// <summary>
        /// ToString: Method to print out info about birds mammal objects
        /// </summary>
        public static Mammal CreateMammal(MammalSpecies species, int numOfTeeth, double tailLength)

        {
            Mammal mammal = null;
            switch (species)
            {
                case MammalSpecies.Cat:
                    mammal = new Cat(numOfTeeth, tailLength);
                    break;
                case MammalSpecies.Dog:
                    mammal = new Dog(numOfTeeth, tailLength);
                    break;
                case MammalSpecies.Horse:
                    mammal = new Horse(numOfTeeth, tailLength);
                    break;

            }
            return mammal;
        }
        public override string GetExtraInfo()
        {
            string strOut = base.GetExtraInfo();
            strOut += String.Format("\n\n{0,-20}{1,10}\n{2,-20}{3,10}\n\n",
                "Tail length (cm):",tailLength,"No. of Teeth:",numOfTeeth);
            return strOut;
        }
    }
}

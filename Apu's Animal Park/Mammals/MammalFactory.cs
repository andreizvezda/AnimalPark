/// MammalFactory.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be used to create different mammal objects
/// </summary>
namespace AnimalPark
{
    /// <summary>
    /// Method to create different mammal objects
    /// </summary>
    class MammalFactory
    {
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
    }
}

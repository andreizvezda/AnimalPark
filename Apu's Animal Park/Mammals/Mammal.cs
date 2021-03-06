﻿/// Mammal.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

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
    class Mammal : Animal
    {
        private int numOfTeeth;
        private double tailLength;

        public Mammal(int numOfTeeth, double tailLength)
        {
            this.numOfTeeth = numOfTeeth;
            this.tailLength = tailLength;
        }
        /// <summary>
        /// ToString: Method to print out info about birds mammal objects
        /// </summary>
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("{0,-20}{1,10}\n{2,-20}{3,10}\n",
                "Tail length (cm):",tailLength,"No. of Teeth:",numOfTeeth);
            return strOut;
        }
    }
}

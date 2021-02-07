/// Horse.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different horses
/// </summary>
namespace AnimalPark
{
    class Horse : Mammal
    {
        private string breed;
        public Horse(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
            breed = "unknown";
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        /// <summary>
        /// ToString: Method to print out info about horse
        /// </summary>
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("Breed: {0}. ", breed);

            return strOut;
        }

    }

}

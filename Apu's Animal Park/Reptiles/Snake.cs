/// Snake.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different snakes
/// </summary>
namespace AnimalPark
{
    class Snake : Reptile

    {
        private string color;
        public Snake(double weight, bool livesInWater) : base(weight, livesInWater)
        {
            color = "unknown";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        /// <summary>
        /// ToString: Method to print out info about snake
        /// </summary>
        public override string ToString()
        {
            string strOut = base.ToString();
            strOut += String.Format("Color: {0}. ", color);

            return strOut;
        }
    }
}


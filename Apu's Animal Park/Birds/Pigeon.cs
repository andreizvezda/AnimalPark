/// Pigeon.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different pigeons
/// </summary>
namespace AnimalPark
{
    class Pigeon : Bird
    {
        private string color;
        private FoodSchedule foodSchedule;
        private string species;
        public Pigeon(double wingSpan, double lengthOfBeak) : base(wingSpan, lengthOfBeak)
        {
            color = "unknown";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //Method to set food schedule for pigeon
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule
            {
                EaterType = EaterType.Omnivore
            };
            foodSchedule.Add("Morning: Bla Bla Bla");
            foodSchedule.Add("Lunch: Bla Bla Bla");
            foodSchedule.Add("Evening: Bla Bla Bla");
        }
        public override FoodSchedule FoodSchedule => foodSchedule;
        //Method to get food schedule for dove
        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;

        }
        //Method to get eater type

        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;

        }

        //Method to get species

        public override string GetSpecies()
        {
            species = BirdsSpecies.Pigeon.ToString();
            return species;
        }
        /// <summary>
        /// ToString: Method to print out info about pigeon
        /// </summary>
        public override string GetExtraInfo()
        {
            string strOut = species + "\n\n";

            strOut += base.GetExtraInfo();
            strOut += String.Format("Color: {0}. ", color);
            return strOut;
        }

    }
}
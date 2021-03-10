/// Lizard.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different lizards
/// </summary>
namespace AnimalPark
{
    class Lizard : Reptile

    {
        private string color;
        private FoodSchedule foodSchedule;
        private string species;

        public Lizard(double weight, bool livesInWater) : base(weight, livesInWater)
        {
            color = "unknown";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }
        //method to set food schedule
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
        //method to get food schedule

        public override FoodSchedule GetFoodSchedule()

        {
            SetFoodSchedule();
            return foodSchedule;
        }
        //method to get eater type

        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;

        }
        //method to get species

        public override string GetSpecies()
        {
            species = ReptileSpecies.Lizard.ToString();
            return species;
        }
        /// <summary>
        /// ToString: Method to print out info about lizard
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



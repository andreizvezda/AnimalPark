/// Horse.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10

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
        private FoodSchedule foodSchedule;
        private string species;
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
        /// 


        //Method to set food schedule for Horse
        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.Add("Morning: Bla Bla Bla");
            foodSchedule.Add("Lunch: Bla Bla Bla");
            foodSchedule.Add("Evening: Bla Bla Bla");
        }
        public override FoodSchedule FoodSchedule => foodSchedule;
        //Method to get food schedule for Horse
        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;

        }
        //Method to get Eater type
        public override EaterType GetEaterType()
        {
            return EaterType.Herbivore;

        }
        //Method to get species
        public override string GetSpecies()
        {
            species = MammalSpecies.Horse.ToString();
            return species;
        }
        public override string GetExtraInfo()
        {
            string strOut = species +  "\n\n";

            strOut += base.GetExtraInfo();
            strOut += String.Format("Breed: {0}. ", breed);

            return strOut;
        }

    }

}

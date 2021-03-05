﻿/// Dog.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class that will be inherited to instantiate different dogs
/// </summary>
namespace AnimalPark
{
    class Dog : Mammal
    {
        private string breed;
        private FoodSchedule foodSchedule;

        public Dog(int numOfTeeth, double tailLength) : base(numOfTeeth, tailLength)
        {
            breed = "unknown";
        }

        public string Breed
        {
            get { return breed; }
            set { breed = value; }
        }

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.Add("Morning: Bla Bla Bla");
            foodSchedule.Add("Lunch: Bla Bla Bla");
            foodSchedule.Add("Evening: Bla Bla Bla");
        }
        public override FoodSchedule FoodSchedule => foodSchedule;
        public override FoodSchedule GetFoodSchedule()
        {
            SetFoodSchedule();
            return foodSchedule;

        }

        public override EaterType GetEaterType()
        {
            return EaterType.Carnivore;

        }
        /// <summary>
        /// ToString: Method to print out info about dog
        /// </summary>
        public override string GetExtraInfo()
        {
            string strOut = "Dog\n\n";
            strOut += base.GetExtraInfo();
            strOut += String.Format("Breed: {0}. ", breed);

            return strOut;
        }

    }

}

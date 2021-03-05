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
        private FoodSchedule foodSchedule;

        public Snake(double weight, bool livesInWater) : base(weight, livesInWater)
        {
            color = "unknown";
        }

        public string Color
        {
            get { return color; }
            set { color = value; }
        }

        private void SetFoodSchedule()
        {
            foodSchedule = new FoodSchedule();
            foodSchedule.EaterType = EaterType.Omnivore;
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
        /// ToString: Method to print out info about snake
        /// </summary>
        public override string GetExtraInfo()
        {
            string strOut = "Snake\n\n";

            strOut += base.GetExtraInfo();
            strOut += String.Format("Color: {0}. ", color);

            return strOut;
        }

    }
}


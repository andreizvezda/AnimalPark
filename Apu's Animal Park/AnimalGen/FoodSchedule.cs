/// FoodSchedule.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10
/// 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPark
{
    public class FoodSchedule
    {
        //collection for maiting a registry of food items
        private EaterType eaterType;
        private readonly List<string> foodList;



        public FoodSchedule()
        {         //constructor
            foodList = new List<string>();
        }
        public int Count
        {             //Method to count Foodlist items

            get
            {
                if ((foodList != null))
                {
                    return foodList.Count;
                }
                else
                {
                    return 0;
                }
            }
        }
        public EaterType EaterType
        {
            //method to get and set EaterType
            get { return eaterType; }
            set { eaterType = value; }
        
        }


        public bool CheckIndex(int index)
        {
            //Method to check indext of foodlist item

            return (foodList != null) & (index < foodList.Count) & (index >= 0);
        }

        public void Add(string item)
        {            //Method to add foodlist item

            foodList.Add(item);
        
        }

        public string GetAt(int index)
        {
            if (CheckIndex(index))
                return foodList[index];
            else
                return null;
        }

        public string[] GetFoodListInfoStrings()

        {
            //Method to convert Foodlist to strings
            string[] strOut = new string[this.foodList.Count];
            int i = 0;

            foreach (string item in foodList)
            {
                strOut[i] += item.ToString();
                i += 1;
            }
            return strOut;
        }



    }
}

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
        private List<string> foodList;

        //constructor

        public FoodSchedule()
        {
            foodList = new List<string>();
        }
        public int Count
        {
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
            get { return eaterType; }
            set { eaterType = value; }
        
        }

       // public bool ChangeAt(string item, int index)
       // {
           
       // }

        public bool CheckIndex(int index)
        {
            return (foodList != null) & (index < foodList.Count) & (index >= 0);
        }

        public void Add(string item)
        {
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

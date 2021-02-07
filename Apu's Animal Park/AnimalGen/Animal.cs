/// Animal.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPark
{
    /// <summary>
    /// Base class to instantiate animal object
    /// </summary>
    class Animal
    {
        private string name;
        private GenderType gender;
        private CategoryType category;
        private double age;
        private string id;

        public Animal()
        {
            Reset();
        }

        public void Reset()

        {   //Default values:
            this.name = "No name";
            this.gender = GenderType.unknown;
            this.age = 0;
            this.id = "0000";
            category = CategoryType.Mammal; 
        }

        public string Id
        {
            set

            {
                if (value.Length > 0)
                    id = value;
            }


        }

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public double Age
        {
            get { return age; }
            set { age = value; }

        }

        public CategoryType Category
        {
            get { return category; }
            set { category = value; }

        }

        public GenderType Gender
        {
            get { return gender; }
            set { gender = value; }

        }

        public override string ToString()
        {
            string strOut = string.Format("{0,-20}{1,10}\n{2,-20}{3,10}\n{4,-20}{5,10}\n",
                "ID:", id, "Name:",name, "Age:", age);

            strOut += string.Format("{0,-20}{1,10}\n{2,-20}{3,10}\n",
                 "Gender:", gender.ToString(), "Category:", category.ToString());

            return strOut;
        }

    }
}

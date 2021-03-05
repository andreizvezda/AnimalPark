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
    abstract class Animal : IAnimal
    {
        // animal name
        private string name;
        // Animal age
        private double age;
        // animal id
        private string id;
        // animal gender
        private GenderType gender;
        // animal type
        private CategoryType category;

        private List<string> animals;


        public abstract FoodSchedule GetFoodSchedule();
        public abstract EaterType GetEaterType();

        public Animal()
        {

        }

        public Animal(string Name, double Age, List<string> animalList)
        {
            Reset();

            name = Name;
            age = Age;
            if ((animalList != null))
            {
                animals = animalList;
            }
        }

        public List<string> Animals
        {
            //To do: The get should send a copy of 
            //m_ingredients the ref
            get { return animals; }
            set { animals = value; }
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
            get { return id; }
            set
            {
                if (value != String.Empty)
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

        string IAnimal.Id {
            get { return id; }
            set { id = value; }
        }

        //this method can be used or overridden by subclasses 





        public override string ToString()
        {
            string strOut = string.Format("{0,-10}{1,-20}{2,10}", id, name, age);

            strOut += string.Format("{0,10}", gender.ToString());

            return strOut;
        }
        public virtual string GetExtraInfo()
        {
            
            string strOut = string.Empty;
            strOut = string.Format("{0,-15} {1, 10}\n", "Category:", category.ToString()); return strOut;
        }
    }
}

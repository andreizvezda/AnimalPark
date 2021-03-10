/// Animal.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10

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
        //animal species
        //private string species;
        // animal gender
        private GenderType gender;
        // animal type
        private CategoryType category;
        // animal list
        private List<string> animals;

        // abstract method to get Food schedule
        public abstract FoodSchedule GetFoodSchedule();
        // abstract method to get Eater type
        public abstract EaterType GetEaterType();
        // abstract method to get Species
        public abstract string GetSpecies();


        public Animal()
        {

        }

        public Animal(string Name, double Age, List<string> animalList)
        {
            Reset();
            //species = Species;
            name = Name;
            age = Age;

            if ((animalList != null))
            {
                animals = animalList;
            }
        }

        public List<string> Animals
        { //Method to get and set animals list

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
        {  //method to get and set animal ID
            get { return id; }
            set
            {
                if (value != String.Empty)
                    id = value;
            }


        }

        public string Name
        { //method to get and set animal name
            get { return name; }
            set { name = value; }

        }


        public double Age
        { //method to get and set animal Age
            get { return age; }
            set { age = value; }

        }

        public CategoryType Category
        { //method to get and set animal Category
            get { return category; }
            set { category = value; }

        }

        public GenderType Gender
        { //method to get and set animal ID
            get { return gender; }
            set { gender = value; }

        }

        string IAnimal.Id 
        {

        //Method to get and set ID
            get { return id; }
            set { id = value; }
        }


        //this method can be used or overridden by subclasses 

        public override string ToString()
        {
            //method to print out general animal info
            string strOut = string.Format("{0,-10}{1,-20}{2,10}", id, name, age, GetSpecies());

            strOut += string.Format("{0,10}", gender.ToString());

            return strOut;
        }
        public virtual string GetExtraInfo()
        {
            //method to print out category specific info
            string strOut = string.Format("{0,-15} {1, 10}\n", "Category:", category.ToString());
            return strOut;
        }
    }
}

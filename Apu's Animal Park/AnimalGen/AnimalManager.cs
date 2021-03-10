/// AnimalManager.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-03-10
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

/// <summary>
/// Class to manage created Animal list
/// </summary>
namespace AnimalPark
{
    class AnimalManager
    {
        private readonly List<IAnimal> animalList;
        private string startID = "000";
        public AnimalManager()
        {
            animalList = new List<IAnimal>();
            
        
        }

        //will save animal object into animalList array if there is free space, and return true/false
        public int Add(IAnimal newAnimal, CategoryType 
            category)
        {
            
            if (newAnimal != null)
            {
                newAnimal.Id = GetNewID(category);
                animalList.Add(newAnimal);
            }
            return animalList.Count - 1;

        }


        //giving current number of items in the array
        public int CurrentNumberOfItems()
        {
            int count = 0;
            for (int i = 0; i < animalList.Count; i++)
                if (animalList[i] != null)
                    count++;
            return count;
        }

        //checking in index is not out of bound
        public bool CheckIndex(int index)
        {
            return (animalList != null) & (index < animalList.Count) & (index >= 0);
        }

        //Gets animal with a selected index from the array
        public IAnimal GetAnimalAt(int index)
        {
            if (CheckIndex(index))
                return animalList[index];
            else
                return null;
        }

        public string[] GetAnimalListInfoStrings()
            //Method to convert animal info to strings
        {
            string[] strOut = new string[this.animalList.Count];
            int i = 0;

            foreach (Animal obj in this.animalList)
            {
                strOut[i] += obj.ToString();
                i += 1;
            }
            return strOut;

        }
        public string GetNewID(CategoryType category)
        {   //method to get animal id
            if (category == CategoryType.Mammal)
            {
                startID = "M0";
            }
            else if (category == CategoryType.Bird)
            {
                startID = "B0";
            }
            else if (category == CategoryType.Reptile)
            {
                startID = "R0";
            }

            return startID + CurrentNumberOfItems().ToString();
        }
    }

}
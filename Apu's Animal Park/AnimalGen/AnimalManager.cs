/// AnimalManager.cs
/// Created by Andrius Sukys
/// Created: 2020-02-01
/// Updated: 2020-02-07
/// 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// Class to manage created Animal list
/// </summary>
namespace AnimalPark
{
    class AnimalManager
    {
        private List<Animal> animalList;

        public AnimalManager()
        {
            animalList = new List<Animal>();
        
        }
        private int FindVacantPosition()
        {
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList[i] == null)
                    return i;
            }
            return -1;
        }

        //will save animal object into animalList array if there is free space, and return true/false
        public bool Add(Animal newAnimal)
        {
            bool ok = true;
            int emptyIndex = FindVacantPosition();

            if (emptyIndex >= 0 && newAnimal != null)
            {

               animalList[emptyIndex] = newAnimal;
            }
            else
            {
                ok = false;
            }

            return ok;

        }

        //overloaded Add method 
        public bool Add(Animal newAnimal, int index)
        {
            bool ok = true;

            if (newAnimal != null)
            {

                animalList[index] = newAnimal;
            }
            else
                ok = false;
            return ok;

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
            if (index < animalList.Count)
                return true;
            else
                return false;

        }

        //Gets animal with a selected index from the array
        public Animal GetAnimalAt(int index)
        {
            if (CheckIndex(index))
                return animalList[index];
            else
                return null;
        }

    }

}
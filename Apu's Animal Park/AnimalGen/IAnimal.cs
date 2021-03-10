/// IAnimal.cs
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
    //Animal interface
{
    public interface IAnimal
    {
        string Name { get; set; }
        string Id { get; set; }
        double Age { get; set; }
        GenderType Gender { get; set; }
        CategoryType Category { get; set; }
        FoodSchedule GetFoodSchedule();
        EaterType GetEaterType();
        string GetSpecies();
        string GetExtraInfo();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalPark

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

        string GetExtraInfo();

    }
}

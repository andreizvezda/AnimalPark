/// IFood.cs
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
    public interface IFood
    {
        string Name { get; set; }

        List<string> Ingredients { get; set; }

        //Each food type must define whether a food is good for 
        //a eater type
        bool IsGoodFor(EaterType eType);
    }
}

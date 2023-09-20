using H1_Breeding_station.Model.Classes.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Other
{
    /// <summary>
    /// This class keeps track of all the animals, by using lists.
    /// Each animal is inside the animals list and also in the more specialized list, for the actual type of animal that it is.
    /// </summary>
    internal class BookKeeping
    {
        internal List <Animal> animals = new();
        internal List<Chicken> chickens = new();
        internal List<Bunny> bunnies = new();
        internal List<Dog> dogs = new(); 
    }
}

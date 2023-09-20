using H1_Breeding_station.Model.Classes.Animals;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Other
{
    internal class BookKeeping
    {
        internal List <Animal> animals = new();
        internal List<Chicken> chickens = new();
        internal List<Bunny> bunnys = new();
        internal List<Dog> dogs = new(); 
    }
}

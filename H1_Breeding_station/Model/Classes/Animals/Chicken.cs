using H1_Breeding_station.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Animals
{
    /// <summary>
    /// This is the chicken class, which inherits from Animal.
    /// It does not have any new attributes, however it can be sold, which sets atStation to false, through the Sell() method.
    /// </summary>
    internal class Chicken : Animal
    {
        internal Chicken(string name, string animalType, float weight, byte legs, byte age, byte leaveAge, bool canFly, bool isMale, bool laysEggs, bool atStation) : base(name, animalType, weight, legs, age, leaveAge, canFly, isMale, laysEggs, atStation)
        {
        }

        public override void Sell()
        {
            atStation = false;
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Animals
{
    /// <summary>
    /// The Dog class inherits from Animal.
    /// It has a new attribute called "fur", which is a string that can be assigned a value, when the object is created.
    /// This animal can also be sold, which then sets atStation to false, since it wont be at the breeding station, if its sold.
    /// ToString() gets updated with the fur attribute.
    /// </summary>
    internal class Dog : Animal
    {
        private protected string fur;

        internal Dog(string name, string animalType, string fur, float weight, byte legs, byte age, byte leaveAge, bool canFly, bool isMale, bool laysEggs, bool atStation) : base(name, animalType, weight, legs, age, leaveAge, canFly, isMale, laysEggs, atStation)
        {
            this.fur = fur;
        }

        public override void Sell()
        {
            atStation = false;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Fur: {fur}\n";
        }
    }
}

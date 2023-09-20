using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Animals
{
    /// <summary>
    /// This class object inherits from Animal.
    /// Unlike the Animal, it has a new field called "fur".
    /// It also has a method called Sell(), which gets called once a bunny gets sold.
    /// Sell() sets atStation to false, because it no longer is at the breeding station, because its sold.
    /// This class also updates the ToString(), with the "fur" variable.
    /// </summary>
    internal class Bunny : Animal
    {
        private protected string fur;

        internal Bunny(string name, string animalType, string fur, float weight, byte legs, byte age, byte leaveAge, bool canFly, bool isMale, bool laysEggs, bool atStation) : base(name, animalType, weight, legs, age, leaveAge, canFly, isMale, laysEggs, atStation)
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

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Animals
{
    internal class Dog : Animal
    {
        private protected string fur;

        internal Dog(string name, string fur, float weight, byte legs, byte age, byte leaveAge, bool canFly, bool isMale, bool laysEggs, bool atStation) : base(name, weight, legs, age, leaveAge, canFly, isMale, laysEggs, atStation)
        {
            this.fur = fur;
        }

        public override string ToString()
        {
            return $"{base.ToString()}" +
                $"Fur: {fur}\n";
        }
    }
}

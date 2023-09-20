using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Animals
{
    internal abstract class Animal
    {
        private protected string name;
        private protected float weight;
        private protected byte legs;
        private protected byte age;
        private protected byte leaveAge;
        private protected bool canFly;
        private protected bool isMale;
        private protected bool laysEggs;
        internal bool atStation;

        protected Animal(string name, float weight, byte legs, byte age, byte leaveAge, bool canFly, bool isMale, bool laysEggs, bool atStation)
        {
            this.name = name;
            this.weight = weight;
            this.legs = legs;
            this.age = age;
            this.leaveAge = leaveAge;
            this.canFly = canFly;
            this.isMale = isMale;
            this.laysEggs = laysEggs;
            this.atStation = atStation;
        }


        public override string ToString()
        {
            return $"Name: {name}\n" +
                $"Weight: {weight}\n" +
                $"Total Legs: {legs}\n" +
                $"age: {age}\n" +
                $"When does this animal leave? {leaveAge}\n" +
                $"Can this animal fly? {canFly}\n" +
                $"is male? {isMale}\n" +
                $"Does this animal lay eggs? {laysEggs} \n" +
                $"Still at the breeding station? {atStation}\n";
        }
    }
}

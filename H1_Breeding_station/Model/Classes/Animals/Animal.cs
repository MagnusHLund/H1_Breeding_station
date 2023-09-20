using H1_Breeding_station.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Classes.Animals
{
    /// <summary>
    /// This is an abstract class, which is the base for all the animals (Bunny, Chicken, Dog).
    /// It is connected to an interface called ISale, which it gets its abstract Sell() method from.
    /// This class sets a bunch of attributes, which will be inherited by each animal type.
    /// The class has a ToString() override, which allows for easy retrieval of the animal data.
    /// </summary>
    internal abstract class Animal : ISell
    {
        private protected string name;
        private protected string animalType;
        private protected float weight;
        private protected byte legs;
        private protected byte age;
        private protected byte leaveAge;
        private protected bool canFly;
        private protected bool isMale;
        private protected bool laysEggs;
        private protected bool atStation;

        protected Animal(string name, string animalType, float weight, byte legs, byte age, byte leaveAge, bool canFly, bool isMale, bool laysEggs, bool atStation)
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
            this.animalType = animalType;
        }

        public abstract void Sell();

        public override string ToString()
        {
            return $"Animal: {animalType}\n" +
                $"Name: {name}\n" +
                $"Weight: {weight}\n" +
                $"Total Legs: {legs}\n" +
                $"Age: {age}\n" +
                $"When does this animal leave? {leaveAge}\n" +
                $"Can this animal fly? {canFly}\n" +
                $"Is male? {isMale}\n" +
                $"Does this animal lay eggs? {laysEggs} \n" +
                $"Still at the breeding station? {atStation}\n";
        }
    }
}

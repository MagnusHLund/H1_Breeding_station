using H1_Breeding_station.Model.Classes.Animals;
using H1_Breeding_station.Model.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Controller
{
    internal class CreationController
    {
        Random random = new();

        internal BookKeeping bookKepping = new BookKeeping();

        internal void Start()
        {
            CreateBunny();
            CreateChicken();
            CreateDog();
        }

        private void CreateBunny()
        {
            for (int i = 0; i < 10; i++)
            {
                float weight = (float)(random.NextDouble() * (3.0 - 1.0) + 1.0);

                byte legs;

                // 1% chance of having lost a leg
                if (random.Next(0, 100) == 10)
                {
                    legs = 3;
                }
                else
                {
                    legs = 4;
                }

                byte age = (byte)random.Next(1, 6);

                byte leaveAge = 6;

                bool canFly = false;

                bool isMale = Convert.ToBoolean(random.Next(0, 2));

                bool laysEggs = false;

                bool isAtStation;

                if (age == 6)
                {
                    isAtStation = false;
                }
                else
                {
                    isAtStation = true;
                }

                Bunny bunny = new(GenerateName(isMale), GenerateFur(), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.bunnys.Add(bunny);
                bookKepping.animals.Add(bunny);
            }
        }

        private void CreateChicken()
        {
            for (int i = 0; i < 10; i++)
            {
                float weight = (float)(random.NextDouble() * (4.0 - 2.5) + 2.5);

                byte legs;

                // 1% chance of having lost a leg
                if (random.Next(0, 100) == 10)
                {
                    legs = 1;
                }
                else
                {
                    legs = 2;
                }

                byte age = (byte)random.Next(1, 5);

                byte leaveAge = 5;

                bool canFly = true;

                bool isMale = Convert.ToBoolean(random.Next(0, 2));

                bool laysEggs = true;

                if (isMale)
                {
                    laysEggs = false;
                }

                bool isAtStation;

                if (age == 5)
                {
                    isAtStation = false;
                }
                else
                {
                    isAtStation = true;
                }

                Chicken chicken = new(GenerateName(isMale), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.chickens.Add(chicken);
                bookKepping.animals.Add(chicken);
            }
        }

        private void CreateDog()
        {
            for (int i = 0; i < 10; i++)
            {
                float weight = (float)(random.NextDouble() * (10.0 - 1.0) + 1.0);

                byte legs;

                // 3% chance of having lost a leg
                if (random.Next(0, 100) < 3)
                {
                    legs = 3;
                }
                else
                {
                    legs = 4;
                }

                byte age = (byte)random.Next(1, 6);
                byte leaveAge = 6;
                bool canFly = false;
                bool isMale = Convert.ToBoolean(random.Next(0, 2));
                bool laysEggs = false;
                bool isAtStation;

                if (age == 6)
                {
                    isAtStation = false;
                }
                else
                {
                    isAtStation = true;
                }

                Dog dog = new(GenerateName(isMale), GenerateFur(), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.dogs.Add(dog);
                bookKepping.animals.Add(dog);
            }
        }

        internal void Breed(byte animal)
        {

        }

        private string GenerateName(bool isMale)
        {
            if (isMale)
            {
                return new Randomizer().maleNames[random.Next(0, 38)];
            }

            return new Randomizer().femaleNames[random.Next(0, 24)];
        }

        private string GenerateFur()
        {
            return new Randomizer().fur[random.Next(0, 16)];
        }
    }
}

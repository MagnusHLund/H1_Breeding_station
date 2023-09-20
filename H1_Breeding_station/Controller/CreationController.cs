using H1_Breeding_station.Model.Classes.Animals;
using H1_Breeding_station.Model.Classes.Other;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Controller
{
    /// <summary>
    /// This class is responsible for creating new animals, of all types.
    /// It creates 10 of each type and then the user can create more, through the menu, by breeding.
    /// </summary>
    internal class CreationController
    {
        Random random = new();

        // This is the instance to the book keeping class, which has the 4 lists for animals.
        internal BookKeeping bookKepping = new BookKeeping();

        /// <summary>
        /// This is the entry point for the Creation controller.
        /// It calls 3 methods, which create 10 of each animal types.
        /// </summary>
        internal void Start()
        {
            CreateBunny();
            CreateChicken();
            CreateDog();
        }

        /// <summary>
        /// This method creates 10 bunnies. 
        /// It generates a bunch of random information, such as a random weigh between 2 numbers, random age, if its male, name and fur.
        /// However some attributes are also not random. Legs can only be 4 and leaveAge is 6, among other fixed values.
        /// It creates the bunny object and then it puts it inside the bunny list and animals list, in the BookKeeping class.
        /// </summary>
        private void CreateBunny()
        {
            for (int i = 0; i < 10; i++)
            {
                string type = "Bunny";
                float weight = (float)(random.NextDouble() * (3.0 - 1.0) + 1.0);
                byte legs = 4;
                byte age = (byte)random.Next(1, 7);
                byte leaveAge = 6;
                bool canFly = false;
                bool isMale = Convert.ToBoolean(random.Next(0, 2));
                bool laysEggs = false;
                bool isAtStation = true;

                Bunny bunny = new(GenerateName(isMale), type, GenerateFur(), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.bunnies.Add(bunny);
                bookKepping.animals.Add(bunny);
            }
        }

        /// <summary>
        /// This method is almost identical to the previous method.
        /// The only difference are some of the random values, which now have new ranges.
        /// Also it ensures that only females can lay eggs.
        /// Once again, the new chicken gets put in BookKeeping lists.
        /// </summary>
        private void CreateChicken()
        {
            for (int i = 0; i < 10; i++)
            {
                string type = "Chicken";
                float weight = (float)(random.NextDouble() * (4.0 - 2.5) + 2.5);
                byte legs = 2;
                byte age = (byte)random.Next(1, 6);
                byte leaveAge = 5;
                bool canFly = true;
                bool isMale = Convert.ToBoolean(random.Next(0, 2));
                bool isAtStation = true;
                bool laysEggs = true;

                if (isMale)
                {
                    laysEggs = false;
                }

                Chicken chicken = new(GenerateName(isMale), type, weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.chickens.Add(chicken);
                bookKepping.animals.Add(chicken);
            }
        }

        /// <summary>
        /// This method creates a dog, again its very similiar to the other "Create" methods.
        /// It creates some attributes and assigns values, which then creates a new dog object, which ends up in 2 lists inside BookKeeping.
        /// </summary>
        private void CreateDog()
        {
            for (int i = 0; i < 10; i++)
            {
                string type = "Dog";
                float weight = (float)(random.NextDouble() * (10.0 - 1.0) + 1.0);
                byte legs = 4;
                byte age = (byte)random.Next(1, 7);
                byte leaveAge = 6;
                bool canFly = false;
                bool isMale = Convert.ToBoolean(random.Next(0, 2));
                bool laysEggs = false;
                bool isAtStation = true;

                Dog dog = new(GenerateName(isMale), type, GenerateFur(), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.dogs.Add(dog);
                bookKepping.animals.Add(dog);
            }
        }

        /// <summary>
        /// This class gets called by the user input.
        /// It breeds new dogs and sets the appropriate values for a puppy.
        /// Very similiar to the "Create" methods, since this method also creates a new dog object, however this time its new borns.
        /// The amount of puppies born at once, can range between 6 and 12.
        /// </summary>
        internal void BreedDog()
        {
            int puppies = random.Next(6, 13);

            for(int i = 0; i < puppies; i++)
            {
                string type = "Dog";
                float weight = (float)(random.NextDouble() * (0.5 - 0.1) + 0.1);
                byte legs = 4;
                byte age = 0;
                byte leaveAge = 6;
                bool canFly = false;
                bool isMale = Convert.ToBoolean(random.Next(0, 2));
                bool laysEggs = false;
                bool isAtStation = true;

                Dog dog = new(GenerateName(isMale), type, GenerateFur(), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.dogs.Add(dog);
                bookKepping.animals.Add(dog);
            }
        }

        /// <summary>
        /// This breeds chickens.
        /// Its similiar to the BreedDog() method, however these attributes values are based on a chicken/roaster instead of a dog.
        /// Its a kind of mix between BreedDog() and CreateChicken(), in terms of what happens.
        /// Look at those methods, for more detailed information, since its essentially the same.
        /// </summary>
        internal void BreedChicken()
        {
            string type = "Chicken";
            float weight = (float)(random.NextDouble() * (0.03 - 0.01) + 0.1);
            byte legs = 2;
            byte age = 0;
            byte leaveAge = 5;
            bool canFly = true;
            bool isMale = Convert.ToBoolean(random.Next(0, 2));
            bool isAtStation = true;
            bool laysEggs = true;

            if (isMale)
            {
                laysEggs = false;
            }

            Chicken chicken = new(GenerateName(isMale), type, weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
            bookKepping.chickens.Add(chicken);
            bookKepping.animals.Add(chicken);
        }

        /// <summary>
        /// Bunnies spit out 1 to 9 babies or "kits".
        /// Those kits need some attributes, which are either a fix value or random, such as the weight.
        /// Once we got all the values, it creates a new baby bunny, and adds it to the bunny list and animal list, inside the BookKeeping class.
        /// </summary>
        internal void BreedBunny()
        {
            int kits = random.Next(1, 10);

            for(int i = 0; i < kits; i++)
            {
                string type = "Bunny";
                float weight = (float)(random.NextDouble() * (0.06 - 0.03) + 0.3);
                byte legs = 4;
                byte age = 0;
                byte leaveAge = 6;
                bool canFly = false;
                bool isMale = Convert.ToBoolean(random.Next(0, 2));
                bool laysEggs = false;
                bool isAtStation = true;

                Bunny bunny = new(GenerateName(isMale), type, GenerateFur(), weight, legs, age, leaveAge, canFly, isMale, laysEggs, isAtStation);
                bookKepping.bunnies.Add(bunny);
                bookKepping.animals.Add(bunny);
            }
        }

        /// <summary>
        /// This method generates a name, based on the gender of the animal and the available options inside the maleNames/femaleNames array in the randomizer class.
        /// The value then gets returned to the new object creation, in either a "Breed" method or a "Create" method.
        /// </summary>
        /// <param name="isMale"></param>
        /// <returns></returns>
        private string GenerateName(bool isMale)
        {
            if (isMale)
            {
                return new Randomizer().maleNames[random.Next(0, 38)];
            }

            return new Randomizer().femaleNames[random.Next(0, 24)];
        }

        /// <summary>
        /// This generates a random fur type, based on an array inside the Randomizer class.
        /// It returns the fur string, to the new object that called this method.
        /// </summary>
        /// <returns></returns>
        private string GenerateFur()
        {
            return new Randomizer().fur[random.Next(0, 16)];
        }
    }
}

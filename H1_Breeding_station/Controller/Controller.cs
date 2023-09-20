using H1_Breeding_station.Model.Classes.Animals;
using H1_Breeding_station.Model.Classes.Other;
using H1_Breeding_station.Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Controller
{
    /// <summary>
    /// The controller class is responsible for handling user input, 
    /// as well as calling the view class with UI required calculations, such as TotalDogs() does.
    /// This is the real entry point of the program, as far as functionality goes.
    /// </summary>
    internal class Controller
    {
        CreationController creator = new CreationController();
        SalesController sales = new SalesController();
        View.View view = new();

        /// <summary>
        /// This is where Program.Main() calls, as soon as the program starts.
        /// This method is responsible for calling creator.Start() which sets up 10 of each animal.
        /// Once the program got 10 of each, then the user gets to play around with 10 options.
        /// </summary>
        internal void Start()
        {
            creator.Start();
            User();
        }

        /// <summary>
        /// This method is where all the user control comes in.
        /// First of all it displays the current dogs, chickens and bunnies in the breeding station, 
        /// by calling the view.Menu, with the correct parameter values.
        /// Next it reads the user input which then gets checked by a switch statement.
        /// Each of the 10 options calls an appropriate method, according to what the menu says the numbers do.
        /// </summary>
        private void User()
        {
            while (true)
            {
                view.Menu(TotalDogs(), TotalChickens(), TotalBunnies());
                string input = view.Readline();

                switch (input)
                {
                    case "1":
                        creator.BreedDog();
                        break;
                    case "2":
                        creator.BreedChicken();
                        break;
                    case "3":
                        creator.BreedBunny();
                        break;
                    case "4":
                        sales.SellDog(creator);
                        break;
                    case "5":
                        sales.SellChicken(creator);
                        break;
                    case "6":
                        sales.SellBunny(creator);
                        break;
                    case "7":
                        Output("all");
                        break;
                    case "8":
                        Output("dogs");
                        break;
                    case "9":
                        Output("chickens");
                        break;
                    case "0":
                        Output("bunnies");
                        break;
                    default:
                        view.Clear();
                        break;
                }
            }
        }

        /// <summary>
        /// This returns the total number of dogs in the breeding station.
        /// It does this by going through each dog in the list inside of the BookKeeping class.
        /// It then checks if the currently selected dog, inside the foreach loop, is still in the breeding station.
        /// It does this because BookKeeping keeps track of all animals that has been in the breeding station, regardless if its sold or not.
        /// If it has been sold, then it will not be counted towards the total dogs, in the menu header.
        /// </summary>
        /// <returns></returns>
        private int TotalDogs()
        {
            // Counter to keep track of all the dogs that are in the breeding station
            int counter = 0;

            // Goes through each dog in the BookKeeping class list.
            foreach (Dog dog in creator.bookKepping.dogs)
            {   
                // Gets the ToString() which are returned from the dog object. This then gets split up into an array, containing a line each.
                string info = dog.ToString();
                string[] lines = info.Split('\n');

                // Goes through each of the lines of dog data
                foreach (string line in lines)
                {
                    // If the line starts with "Still", then we got the correct line to check if its still at the breeding station or not.
                    if (line.StartsWith("Still"))
                    {
                        // Splits up the line, each time there is a space. Then it checks for the 6th split (zero based numbering).
                        // If the value is true, then its still in the breeding station.
                        string[] split = line.Split(" ");
                        if (split[5] == "True")
                        {
                            // If the dog is still being bred, then the counter goes up by 1 and breaks out of the lines foreach loop, to count the next dog.
                            counter++;
                            break;
                        }
                    }
                }
            }
            
            // Returns the value of dogs which are still in the breeding station.
            return counter;
        }

        /// <summary>
        /// This is essentially the same as the TotalDogs() method, which is directly above.
        /// TotalChickens() does the exact same, except its for chickens instead of dogs.
        /// For a detailed description of the method, check out TotalDogs(), which goes in great depth to explain what happens.
        /// </summary>
        /// <returns></returns>
        private int TotalChickens()
        {
            int counter = 0;

            foreach (Chicken chicken in creator.bookKepping.chickens)
            {
                string info = chicken.ToString();
                string[] lines = info.Split('\n');

                foreach (string line in lines)
                {
                    if (line.StartsWith("Still"))
                    {
                        string[] split = line.Split(" ");
                        if (split[5] == "True")
                        {
                            counter++;
                            break;
                        }
                    }
                }
            }

            return counter;
        }

        /// <summary>
        /// This method does exactly the same as TotalDogs() and TotalChickens(). 
        /// Check out TotalDogs(), which is a method inside this class, for a very detailed description of whats going on.
        /// </summary>
        /// <returns></returns>
        private int TotalBunnies()
        {
            int counter = 0;

            foreach (Bunny bunny in creator.bookKepping.bunnies)
            {
                string info = bunny.ToString();
                string[] lines = info.Split('\n');

                foreach (string line in lines)
                {
                    if (line.StartsWith("Still"))
                    {
                        string[] split = line.Split(" ");
                        if (split[5] == "True")
                        {
                            counter++;
                            break;
                        }
                    }
                }
            }

            return counter;
        }

        /// <summary>
        /// This method outputs either all the animals, or just 1 animal type.
        /// The output depends on the parameter, which is assigned depending on the user input inside the User() method, inside this class.
        /// It goes through each animal inside the desired list, which then gets all the information from the ToString(), inside the Animal objects.
        /// Once its done outputting, the user can press enter to get back to the menu.
        /// </summary>
        /// <param name="animals"></param>
        private void Output(string animals)
        {
            if (animals == "all")
            {
                foreach (Animal animal in creator.bookKepping.animals)
                {
                    view.Message(animal.ToString());
                }
            }
            else if (animals == "dogs")
            {
                foreach (Animal animal in creator.bookKepping.dogs)
                {
                    view.Message(animal.ToString());
                }
            }
            else if (animals == "chickens")
            {
                foreach (Animal animal in creator.bookKepping.chickens)
                {
                    view.Message(animal.ToString());
                }
            }
            else if (animals == "bunnies")
            {
                foreach (Animal animal in creator.bookKepping.bunnies)
                {
                    view.Message(animal.ToString());
                }
            }

            view.Message("Press enter to continue");
            view.Readline();
            view.Clear();
        }
    }
}

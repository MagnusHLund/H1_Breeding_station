using H1_Breeding_station.Model.Classes.Animals;
using H1_Breeding_station.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Controller
{
    internal class SalesController
    {
        View.View view = new();

        /// <summary>
        /// This method sells a dog.
        /// It only sells dogs that are 6 years old. Why?
        /// Because once a dog is 6 years old, its time to leave the breeding station.
        /// It then gets sold off, however it remains in BookKeeping lists.
        /// This method only sells 1 dog at a time and will not be able to sell any, if there arent any 6 year olds left at the station.
        /// It has a link to the CreationController, through the parameter, which is used to go through each of the dogs inside the BookKeeping lists, which is instantiated in CreationController. 
        /// </summary>
        /// <param name="creator"></param>
        internal void SellDog(CreationController creator)
        {
            // Bool to check if it has sold a dog. If it has then it should break out of both foreach loops.
            bool sold = false;

            view.Message("Selling a 6 year old dog, if there are any.");
            
            // Goes through each dog in the dogs list.
            foreach (Dog dog in creator.bookKepping.dogs)
            {
                // If a dog has been sold, then it waits for user input and then breaks out of the loop.
                if (sold)
                {
                    view.Message("Press enter to continue");
                    view.Readline();
                    break;
                }

                // Gets information about the dog, then splits it up into a string array, which gets one line each.
                string info = dog.ToString();
                string[] lines = info.Split('\n');

                // Goes through each line in the string array
                foreach (string line in lines)
                {
                    // Finds a line that starts with "Age". Then it splits the line at the space character, and checks the 2nd half of the split.
                    if (line.StartsWith("Age"))
                    {
                        string[] split = line.Split(" ");

                        // If the 2nd half of the split is 6, then that means the dog is 6 years old and it can be sold.
                        if (int.Parse(split[1]) == 6)
                        {
                            // It updates that the dog is no longer in service, by calling the dog.Sell() method.
                            // the sold bool gets set to true, to indicate that we got a sale and we break out of the lines foreach loop.
                            view.Message("Sold dog!");
                            dog.Sell();
                            sold = true;
                            break;
                        }
                    }
                }
            }

            // This checks if no dogs were sold, it then tells the user and waits for user confirmation to go back to the menu screen.
            if (!sold)
            {
                view.Message("No dogs are 6 years old!\nPress enter to continue");
                view.Readline();
            }

            // Clears the console.
            view.Clear();
        }

        /// <summary>
        /// This method is identical to the SellDog() method, however it sells chickens instead.
        /// For a more detailed description of the method, refer to the SellDog() method, which is directly above this one.
        /// </summary>
        /// <param name="creator"></param>
        internal void SellChicken(CreationController creator)
        {
            bool sold = false;

            view.Message("Selling a 5 year old chicken, if there are any.");

            foreach (Chicken chicken in creator.bookKepping.chickens)
            {
                if (sold)
                {
                    view.Message("Press enter to continue");
                    view.Readline();
                    break;
                }

                string info = chicken.ToString();
                string[] lines = info.Split('\n');

                foreach (string line in lines)
                {
                    if (line.StartsWith("Age"))
                    {
                        string[] split = line.Split(" ");
                        if (int.Parse(split[1]) == 5)
                        {
                            view.Message("Sold Chicken!");
                            chicken.Sell();
                            sold = true;
                            break;
                        }
                    }
                }
            }

            if (!sold)
            {
                view.Message("No chickens are 6 years old!\nPress enter to continue");
                view.Readline();
            }

            view.Clear();
        }

        /// <summary>
        /// This method sells bunnies. 
        /// SellBunny() is almost identical to the 2 previous methods. 
        /// Refer to the top method inside this class, to get a detailed description of how this method works.
        /// </summary>
        /// <param name="creator"></param>
        internal void SellBunny(CreationController creator)
        {
            bool sold = false;
            view.Message("Selling a 6 year old bunny, if there are any.");

            foreach (Bunny bunny in creator.bookKepping.bunnies)
            {
                if (sold)
                {
                    view.Message("Press enter to continue");
                    view.Readline();
                    break;
                }

                string info = bunny.ToString();
                string[] lines = info.Split('\n');

                foreach (string line in lines)
                {
                    if (line.StartsWith("Age"))
                    {
                        string[] split = line.Split(" ");
                        if (int.Parse(split[1]) == 6)
                        {
                            view.Message("Sold bunny!");
                            bunny.Sell();
                            sold = true;
                            break;
                        }
                    }
                }
            }

            if (!sold)
            {
                view.Message("No bunnies are 6 years old!\nPress enter to continue");
                view.Readline();
            }

            view.Clear();
        }
    }
}

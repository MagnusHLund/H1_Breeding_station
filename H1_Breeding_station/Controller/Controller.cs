using H1_Breeding_station.Model.Classes.Animals;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Controller
{
    internal class Controller
    {
        CreationController creator = new CreationController();
        internal void Start()
        {
            creator.Start();
            User();
        }

        private void User()
        {
            View.View view = new View.View();


            while (true)
            {
                view.Menu(creator.bookKepping.dogs.Count, creator.bookKepping.chickens.Count, creator.bookKepping.bunnys.Count);
                string input = view.Readline();

                switch (input)
                {
                    case "1":
                        creator.Breed(1);
                        break;
                    case "2":
                        creator.Breed(2);
                        break;
                    case "3":
                        creator.Breed(3);
                        break;
                    case "4":
                        Sell(1);
                        break;
                    case "5":
                        Sell(2);
                        break;
                    case "6":
                        Sell(3);
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
                    default:
                        Output("bunnies");
                        break;
                }
            }
        }

        private void Sell(int animal)
        {
            if (animal == 1) // Dogs
            {
                foreach(Dog dog in creator.bookKepping.dogs)
                {
                    string info = dog.ToString();
                    string[] lines = info.Split('\n');
                    
                    foreach(string line in lines)
                    {
                        if (line.StartsWith("Age"))
                        {
                            string[] split = line.Split(" ");
                            if (int.Parse(split[1]) == 6)
                            {
                                dog.atStation = false;
                            }
                        }
                    }
                }
            }
            else if (animal == 2) // Chickens
            {

            }
            else // Bunnies
            {

            }

            
        }

        private void Output(string animals)
        {

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.View
{
    internal class View
    {
        internal void Message(string message)
        {
            Console.WriteLine(message);
        }

        internal void Menu(int dogs, int chickens, int bunnies)
        {
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("                  Lunds breeding station\n");
            Console.WriteLine($"   Total dogs: {dogs} Total chickens: {chickens} Total bunnies: {bunnies}\n");
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine(" 1. Breed dogs");
            Console.WriteLine(" 2. Breed chickens");
            Console.WriteLine(" 3. Breed bunnies");
            Console.WriteLine(" 4. Sell old dog");
            Console.WriteLine(" 5. Sell old chicken");
            Console.WriteLine(" 6. Sell old bunny");
            Console.WriteLine(" 7. See all animals");
            Console.WriteLine(" 8. See all dogs");
            Console.WriteLine(" 9. See all chickens");
            Console.WriteLine(" 0. See all bunnies");
        }

        internal void Clear()
        {
            Console.Clear();
        }

        internal string Readline()
        {
            return Console.ReadLine();
        }

        internal void colors(int i, string? animal)
        {
            if (animal == "bunny")
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                } 
                else
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
            }
            else if (animal == "dog")
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
            }
            else if (animal == "chicken")
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
            }
            else
            {
                if (i % 2 == 0)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
        }
    }
}

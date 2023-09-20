using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.View
{
    internal class View
    {
        /// <summary>
        /// This method allows a custom message to be outputted to the console, using the message parameter.
        /// </summary>
        /// <param name="message"></param>
        internal void Message(string message)
        {
            Console.WriteLine(message);
        }

        /// <summary>
        /// This method outputs the whole menu screen.
        /// It takes 3 parameters, which represents how many animals i have, of each type.
        /// This method only gets called from the main controller, in the User() method.
        /// </summary>
        /// <param name="dogs"></param>
        /// <param name="chickens"></param>
        /// <param name="bunnies"></param>
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

        /// <summary>
        /// This method clears the console window.
        /// </summary>
        internal void Clear()
        {
            Console.Clear();
        }

        /// <summary>
        /// This method returns a readline, which can be used to etiher gather input or just pause the program until the user presses enter.
        /// </summary>
        /// <returns></returns>
        internal string Readline()
        {
            return Console.ReadLine();
        }
    }
}

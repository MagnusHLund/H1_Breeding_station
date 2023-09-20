namespace H1_Breeding_station
{
    internal class Program
    {
        /// <summary>
        /// Calls the main controller class and gets out of static.
        /// </summary>
        static void Main()
        {
            new Controller.Controller().Start();
        }
    }
}
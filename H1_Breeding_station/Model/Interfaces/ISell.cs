using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace H1_Breeding_station.Model.Interfaces
{
    /// <summary>
    /// This is an interface which takes care of the sell aspect of the program.
    /// Classes that use this interface, which is Animal, are required to use a Sell() method, which represents selling an animal.
    /// </summary>
    internal interface ISell
    {
        void Sell();
    }
}

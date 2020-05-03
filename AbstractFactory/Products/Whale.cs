using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.AbstractFactory.Products
{
    public class Whale : IAnimal
    {
        public readonly static string whoAmI = "WHALE ";

        public string Create()
        {
            return whoAmI + "Created Aqua Animal";
        }
    }
   
}

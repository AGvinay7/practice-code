using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_Web_API.AbstractFactory.Products
{
    public class Shark : IAnimal
    {
        public readonly static string whoAmI = "I'm the SHARK :D ";

        public string Create()
        {
            return whoAmI + "Created Aqua Animal";
        }
    }
}

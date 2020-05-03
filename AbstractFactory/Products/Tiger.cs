using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.AbstractFactory.Products
{
    public class Tiger : IAnimal
    {
        public readonly static string whoAmI = "I'm TIGERR";

        public string Create()
        {
            return "Land Animal Created i.e " + whoAmI;
        }
    }
}

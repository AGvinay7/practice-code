using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_Web_API.AbstractFactory.Products
{
    public class Cat : IAnimal
    {
        public readonly static string whoAmI = "I'm cat";
        public string Create()
        {
            return "Land Animal Created i.e : " + whoAmI;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.AbstractFactory.Products
{
    public class Tiger : IAnimal
    {
        private string Name = "Tiger";
        public string WhoAmI { get { return Name; } set { } }

        public string Create()
        {
            return "Land Animal Created i.e - " + WhoAmI;
        }
    }
}

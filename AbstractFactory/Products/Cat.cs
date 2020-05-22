using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.AbstractFactory.Products
{
    public class Cat : IAnimal
    {
          private string Name="Cat";
        public string WhoAmI { get { return Name; } set {} }
        public string Create()
        {
            return "Land Animal Created i.e : " + WhoAmI;
        }
    }
}

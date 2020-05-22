using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.AbstractFactory.Products
{
    public class Whale : IAnimal
    {
        private string Name;
        public string WhoAmI { get { return Name; } set { Name = "Whale"; } }
        public string Create()
        {
            return "Created Aqua Animal i.e -" + WhoAmI;
        }
    }
   
}

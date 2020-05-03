using VinayAG.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.AbstractFactory.Factories
{
    public class AquaAnimalsFactory : AbstractFactory
    {
        public override IAnimal CreateAnimals(string AquaAnimalType)
        {
            IAnimal animal = null;
            switch (AquaAnimalType)
            {
                case "whale": return new Whale();
                case "shark": return new Shark();
                default: break;
            }
            return animal;
        }
    }
}

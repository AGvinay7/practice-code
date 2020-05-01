using sample_Web_API.AbstractFactory.Factories;
using sample_Web_API.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_Web_API.AbstractFactory
{
    public abstract class AbstractFactory
    {
        public abstract IAnimal CreateAnimals(string landAnimalType);

        public static AbstractFactory CreateAnimalFactory(string type)
        {
            if (type.Equals("landAnimal"))
            {
                return new LandAnimalsFactory();
            }
            else
            {
                return new AquaAnimalsFactory();
            }          
        }

    }
}

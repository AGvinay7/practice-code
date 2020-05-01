using sample_Web_API.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_Web_API.AbstractFactory
{
    public class AnimalMaker
    {
        public void CreateAnimal()
        {
            //create a Factory for Land Animals Production 
            AbstractFactory factoryOfLA = AbstractFactory.CreateAnimalFactory("landAnimal");

            //using Factory for Land Animals Production, create a Tiger
            IAnimal createdAnimal = factoryOfLA.CreateAnimals("tiger");

            var result = createdAnimal.Create();


        }

    }
}

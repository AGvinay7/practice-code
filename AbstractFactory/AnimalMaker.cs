using VinayAG.AbstractFactory.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Diagnostics;

namespace VinayAG.AbstractFactory
{
    public class AnimalMaker
    {
        public void CreateAnimal()
        {
            //create a Factory for Land Animals Production 
            AbstractFactory factoryOfLA = AbstractFactory.CreateAnimalFactory("landAnimal");

            //using Factory for Land Animals Production, create a Tiger
            IAnimal createdAnimal = factoryOfLA.CreateAnimals("tiger");
            Trace.WriteLine("\n\n" + createdAnimal.Create());

           // AbstractFactory chocoFactory = AbstractFactory.getMeChoco("5*");
            IAnimal CreateCat = factoryOfLA.CreateAnimals("cat");
            Trace.WriteLine("\n\n" + CreateCat.Create());

        }

    }
}

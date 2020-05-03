using VinayAG.AbstractFactory.Products;

namespace VinayAG.AbstractFactory.Factories
{
    public class LandAnimalsFactory : AbstractFactory
    {
        public override IAnimal CreateAnimals(string landAnimalType)
        {
            IAnimal animal = null;
            switch(landAnimalType)
            {
                case "cat": return new Cat();
                case "tiger": return new Tiger();
                default: break;
            }
            return animal;
        }

       
    }
}

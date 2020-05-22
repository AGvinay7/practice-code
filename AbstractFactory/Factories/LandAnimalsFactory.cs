using VinayAG.AbstractFactory.Products;

namespace VinayAG.AbstractFactory.Factories
{
    public class LandAnimalsFactory : AbstractFactory
    {
        public override IAnimal CreateAnimals(string landAnimalType)
        {
            if(!string.IsNullOrWhiteSpace(landAnimalType))
            {
                switch (landAnimalType)
                {
                    case "cat": return new Cat();
                    case "tiger": return new Tiger();
                    default: break;
                }
            }
            
            return null;
        }
       
    }
}

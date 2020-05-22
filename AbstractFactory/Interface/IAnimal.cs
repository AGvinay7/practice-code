namespace VinayAG.AbstractFactory.Products
{
    public interface IAnimal
    {
        string WhoAmI { get; set; }
        string Create();
    }
}

namespace VinayAG.FactoryDesignPattern
{
    public class ActionMovie : IMovies
    {
        private readonly string ActionMovieName = " Name: SAAHOO";
        public string GetMovie()
        {
            return ActionMovieName;
        }
    }
}

namespace VinayAG.FactoryDesignPattern
{
    public class MoviesFactory
    {
        public IMovies GetMyMovie(string typeOfMovie)
        {
            if (!string.IsNullOrWhiteSpace(typeOfMovie))
            {
                switch (typeOfMovie)            // based on type create objects dynamically 
                {
                    case "action": return new ActionMovie();
                    case "horror": return new HorrorMovie();
                    case "historic": return new HistoricMovie();
                    default: break;
                }
            }

            return null;
        }
    }
}

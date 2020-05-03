namespace VinayAG.FactoryDesignPattern
{
    public class MoviesFactory
    {
        public IMovies GetMyMovie(string typeOfMovie)
        {
            IMovies movie = null;
            switch (typeOfMovie)
            {
                case "action": return new ActionMovie();
                case "horror": return new HorrorMovie();
                case "historic": return new HistoricMovie();
                default: break;

            }
            return movie;

        }
    }
}

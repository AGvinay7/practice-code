using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sample_Web_API.FactoryDesignPattern
{
    public class Client
    {
        public object GetMovies()
        {
            MoviesFactory moviesFactory = new MoviesFactory();
            var actionMovie = moviesFactory.GetMyMovie(Movies.action.ToString());
            var actionMovieResult = actionMovie.GetMovie();

            var horrorMovie = moviesFactory.GetMyMovie(Movies.horror.ToString());
            var horrorMovieResult = horrorMovie.GetMovie();

            var historicMovie = moviesFactory.GetMyMovie(Movies.historic.ToString());
            var historicMovieResult = historicMovie.GetMovie();

            return actionMovieResult + horrorMovieResult + historicMovieResult;

        }
    }

    public enum Movies
    {
        action, horror, historic
    }
}

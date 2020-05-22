using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.FactoryDesignPattern
{
    public class Client
    {
        public void GetMovies()
        {
            // Client asks Factory to create different products based on name and the Factory does that job! 

            MoviesFactory moviesFactory = new MoviesFactory();

            var actionMovie = moviesFactory.GetMyMovie("action");
            Trace.WriteLine("\n\n Factory created a Movie " + actionMovie.GetMovie());

            var horrorMovie = moviesFactory.GetMyMovie("horror");
            Trace.WriteLine("\n Factory created a Movie " + horrorMovie.GetMovie());

            var historicMovie = moviesFactory.GetMyMovie("historic");
            Trace.WriteLine("\nFactory created a Movie " + historicMovie.GetMovie());

        }
    }
    
}

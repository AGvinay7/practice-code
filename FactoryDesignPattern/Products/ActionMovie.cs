using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.FactoryDesignPattern
{
    public class ActionMovie : IMovies
    {
        private readonly string ActionMovieName = "SAAHOO";
        public string GetMovie()
        {
            return ActionMovieName;
        }
    }
}

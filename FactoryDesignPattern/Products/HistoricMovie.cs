﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.FactoryDesignPattern
{
    public class HistoricMovie : IMovies
    {
        private readonly string HistoricMovieName = "Name: Gladiator";
        public string GetMovie()
        {
            return HistoricMovieName;
        }
    }
}

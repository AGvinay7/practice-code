﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VinayAG.FactoryDesignPattern
{
    public class HorrorMovie : IMovies
    {

        private readonly string MovieName = "Name: The Conjuring";
        public string GetMovie()
        {
            return MovieName;
        }
    }
}

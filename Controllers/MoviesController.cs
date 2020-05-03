using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using VinayAG.AbstractFactory;
using VinayAG.FactoryDesignPattern;
using VinayAG.Processors.Impl;
using VinayAG.Processors.Interface;

namespace VinayAG.Controllers
{

    [ApiController]
    public class MoviesController : ControllerBase
    {
        public readonly IDesignPatterns _designPatterns;
        //public MoviesController(IDesignPatterns designPatterns)
        //{
        //    _designPatterns = designPatterns;
        //}
        /// <summary>
        /// API to get all movies
        /// </summary>
        /// <returns>200</returns>
        [HttpGet]
        [Route("api/movies")]
        public IList<MovieModel> GetAllMovies([FromServices] IDesignPatterns _designPatterns)
        {
            _designPatterns.DemoDesignPatterns();
            return new List<MovieModel>();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/movies/{id}")]
        public MovieModel GetMovieById(int id)
        {
            return new MovieModel();
        }

        // POST api/movies
        [HttpPost]
        [Route("api/movies/{id}")]
        public void CreateMovie([FromBody] string value)
        {
        }

        // PUT api/movies/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/movies/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

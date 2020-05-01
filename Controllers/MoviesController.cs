using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using sample_Web_API.AbstractFactory;
using sample_Web_API.FactoryDesignPattern;

namespace sample_Web_API.Controllers
{

    [ApiController]
    public class MoviesController : ControllerBase
    {
        /// <summary>
        /// API to get all movies
        /// </summary>
        /// <returns>200</returns>
        [HttpGet]
        [Route("api/movies")]
        public IList<MovieModel> GetAllMovies()
        {
            // creat objects using Factory Design Pattern
            //var callerObj = new Client();
           // callerObj.GetMovies();

            // creat objects using Abstract Factory Design Pattern
            var createTiger = new AnimalMaker();
            createTiger.CreateAnimal();

            return new List<MovieModel>();
        }

        // GET api/values/5
        [HttpGet]
        [Route("api/movies/{id}")]
        public MovieModel GetMovieById(int id)
        {
            return new MovieModel();
        }

        // POST api/values
        [HttpPost]
        [Route("api/movies/{id}")]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

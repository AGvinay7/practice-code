using System.Collections.Generic;

namespace sample_Web_API.Controllers
{
    public class MovieModel
    {
        public string Name { get; set; }
        public IList<string> Language { get; set; }
        public int Year { get; set; }
        public Cast Cast { get; set; }       

    }
}
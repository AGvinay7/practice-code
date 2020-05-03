
using Microsoft.AspNetCore.Mvc;

namespace VinayAG.Controllers
{
    
    [ApiController]
    public class StudentsController : ControllerBase
    {

        [HttpPost]
        [Route("api/students")]
        public bool CreateStudent(Student student)
        {
            return true;
        }
    }
}
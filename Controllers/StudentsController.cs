
using Microsoft.AspNetCore.Mvc;

namespace sample_Web_API.Controllers
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
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Refreshing.API.Controllers
{
    
    // https://localhost:portnumber/api/students
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        // GET: https://localhost:portnumber/api/students
        [HttpGet]
        public IActionResult GetAllStudents()
        {
            string[] studentsNames = new string[] { "Jonh", "Jane", "Mark", "Emily", "David" };

            return Ok(studentsNames);
        }
    }
}

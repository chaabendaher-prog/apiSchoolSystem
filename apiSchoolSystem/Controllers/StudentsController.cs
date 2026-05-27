using apiSchoolSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Heloo");
        }
        [HttpPost]
        public IActionResult Add(Student s) {
            return Ok("Added");
        
        }
    }
}

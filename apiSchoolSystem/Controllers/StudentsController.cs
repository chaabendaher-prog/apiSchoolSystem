using apiSchoolSystem.Data;
using apiSchoolSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace apiSchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public StudentsController(AppDbContext context)
        {
            _context = context;
        }
        [HttpPut]
        public async Task<IActionResult> UpdateStudent(Student student)
        {
            var u = await _context.Students.FindAsync(student.Id);
            if (u == null)
            {
                return NotFound("User not found");
            }
            _context.Students.Update(student);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
            return Ok();
        }
        [HttpGet]
        public async Task<ActionResult<Student>> GetStudents()
        {
            return Ok(_context.Students.ToList);


        }

        [HttpPost]
        public async Task<IActionResult> CreateStudent(Student student)
        {
            _context.Students.Add(student);
            await _context.SaveChangesAsync();
            return Ok();
        }
    
   
    }
}


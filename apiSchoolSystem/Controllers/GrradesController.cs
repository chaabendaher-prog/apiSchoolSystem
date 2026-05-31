using apiSchoolSystem.Data;
using apiSchoolSystem.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiSchoolSystem.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GrradesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public GrradesController(AppDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public IActionResult GetGrades()
        {
            return Ok(_context.Grades.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> CreateGrade(Grade grade)
        {
            _context.Grades.Add(grade);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> UpdateGrade(Grade grade)
        {
            _context.Grades.Update(grade);
            await _context.SaveChangesAsync();
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteGrade(int id)
        {
            var grade = await _context.Grades.FindAsync(id);

            if (grade == null)
                return NotFound();

            _context.Grades.Remove(grade);
            await _context.SaveChangesAsync();

            return Ok();
        }
    }
}

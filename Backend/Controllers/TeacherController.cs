using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Backend.Data;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Backend.Controllers
{
[Route("api/Teacher")]
[ApiController]
public class TeacherController : ControllerBase
{
    public DatabaseContext _context { get; }
    public TeacherController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetTeachers()
    {
        var Teachers = await _context.Teachers.ToListAsync();
        return Ok(Teachers);
    }
    [HttpGet("{id}")]
    public async Task<ActionResult> GetByid([FromRoute] int id)
    {
        var Teacher = await _context.Teachers.FindAsync(id);
        if (Teacher == null)
        {
            return BadRequest("Can't find the Teacher");
        }

        return Ok(Teacher);
    }
}
}
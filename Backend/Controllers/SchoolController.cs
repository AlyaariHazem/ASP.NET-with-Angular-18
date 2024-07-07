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

[Route("api/School")]
[ApiController]
public class SchoolController : ControllerBase
{

    public DatabaseContext _context { get; }
    public SchoolController(DatabaseContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult> GetSchools()
    {
        var Schools =await _context.Schools.ToListAsync();
        return Ok(Schools);
    }

    [HttpGet("{id}")]
    public async Task<ActionResult> GetByid([FromRoute] int id)
    {
        var School =await _context.Schools.FindAsync(id);
        if(School==null){
            return BadRequest("Cant find the school");
        }

        return Ok(School);
    }
}
}
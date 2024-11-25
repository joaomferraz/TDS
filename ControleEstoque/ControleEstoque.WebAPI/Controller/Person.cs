using ControleEstoque.EFCore.DataContext;
using ControleEstoque.Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.WebAPI.Controllers;

[Route("api/person")]
[ApiController]
public class PersonController : ControllerBase {
    private readonly ControleEstoqueEFCoreContext context;

    public PersonController(ControleEstoqueEFCoreContext context) {
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var persons = await context.Persons.ToListAsync();
        return Ok(persons);
    }

    [HttpGet("getByID")]
    public async Task<IActionResult> GetByID(int personID) {
        Person? person = await context.Persons.FindAsync(personID);
        if (person == null) {
            return NotFound($"Person with ID {personID} not found");
        }
        return Ok(person);
    }

    [HttpPost]
    [Produces("application/json")]
    public async Task<IActionResult> Create([FromBody]Person person) {
        context.Add(person);
        await context.SaveChangesAsync();
        return Created("", person);
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteById(int personID) {
        Person? person = await context.Persons.FindAsync(personID);
        if (person != null) {
            context.Remove(person);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(Person person) {
        context.Entry(person).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(person);
    }
}

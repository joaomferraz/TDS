using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ControleEstoque.EFCore.DataContext;
using ControleEstoque.Model.Model;

namespace ControleEstoque.WebAPI.Controller;

[Route("api/category")]
[ApiController]
public class CategoryController : ControllerBase {
    private readonly ControleEstoqueEFCoreContext context;
    
    public CategoryController(ControleEstoqueEFCoreContext context){
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var categories = await context.Categories.ToListAsync();
        return Ok(categories);
    }

    [HttpGet("getByID")]
    public async Task<IActionResult> GetByID(int categoryID) {
        CategoryModel? category = await context.Categories.FindAsync(categoryID);
        if (category == null) {
            return NotFound();
        }
        return Ok(category);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CategoryModel category) {
        context.Add(category);
        await context.SaveChangesAsync(); 
        return Created("", category);   
    }

    [HttpDelete]
    public async Task<IActionResult> DeleteById(int categoryID) {
        CategoryModel? category = await context.Categories.FindAsync(categoryID);
        if (category != null) {
            context.Remove(category);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(CategoryModel category) {
        context.Entry(category).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(category);
    }
}

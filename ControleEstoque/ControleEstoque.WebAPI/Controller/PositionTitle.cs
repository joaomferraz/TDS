using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using ControleEstoque.EFCore.DataContext;


namespace ControleEstoque.WebAPI.Controller;

[Route("api/positinstitle")]
[ApiController]
public class PositionTitle : ControllerBase {
    private readonly ControleEstoqueEFCoreContext context;
    public PositionTitleController(ControleEstoqueEFCoreContext context){
        this.context = context;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll() {
        var positionstitle = await context.PositionsTitle.ToListAsync();
        return Ok(positionstitle);
    }

    [HttpGet("getByID")]
    public async Task<IActionResult> GetByID(int positionID) {
        PositionTitle? positiontitle = await context.PositionTitle.FindAsync(positionID);
        return Ok(positiontitle);
    }

      [HttpPost]
    public async Task<IActionResult> Create(PositionTitle positionTitle) {
        context.Add(positionTitle);
        await context.SaveChangesAsync(); 
        return  Created("", positionTitle);   
    }

    [HttpDelete] 
    public async Task<IActionResult> DeleteById(int positionID) {
        PositionTitle? positionTitle = await context.PositionsTitle.FindAsync(positionID);
        if (positionTitle != null) {
            context.Remove(positionTitle);
            await context.SaveChangesAsync();
            return Ok();
        }
        return NoContent();
    }

    [HttpPut]
    public async Task<IActionResult> Update(PositionTitle positionTitle) {
        context.Entry(positionTitle).State = EntityState.Modified;
        await context.SaveChangesAsync();
        return Ok(positionTitle);
    }


}


  





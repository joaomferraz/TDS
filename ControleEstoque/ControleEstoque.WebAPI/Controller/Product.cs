using ControleEstoque.EFCore.DataContext;
using ControleEstoque.Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.WebAPI.Controller
{
    [Route("api/product")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly ControleEstoqueEFCoreContext context;

        public ProductController(ControleEstoqueEFCoreContext context)
        {
            this.context = context;
        }

        // GET: api/product
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var products = await context.Products
                .Include(p => p.Supplier)  // Inclui o Supplier associado
                .Include(p => p.Category)   // Inclui a Category associada
                .ToListAsync();
            return Ok(products);
        }

        // GET: api/product/getByID
        [HttpGet("getByID")]
        public async Task<IActionResult> GetByID(int productID)
        {
            var product = await context.Products
                .Include(p => p.Supplier)
                .Include(p => p.Category)
                .FirstOrDefaultAsync(p => p.ProductID == productID);
                
            if (product == null)
            {
                return NotFound($"Product with ID {productID} not found");
            }
            return Ok(product);
        }

        // POST: api/product
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Product product)
        {
            context.Products.Add(product);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetByID), new { productID = product.ProductID }, product);
        }

        // PUT: api/product
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Product product)
        {
            context.Entry(product).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(product);
        }

        // DELETE: api/product
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int productID)
        {
            var product = await context.Products.FindAsync(productID);
            if (product == null)
            {
                return NotFound($"Product with ID {productID} not found");
            }

            context.Products.Remove(product);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

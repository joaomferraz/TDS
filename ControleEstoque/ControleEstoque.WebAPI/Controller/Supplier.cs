using ControleEstoque.EFCore.DataContext;
using ControleEstoque.Model.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ControleEstoque.WebAPI.Controller
{
    [Route("api/supplier")]
    [ApiController]
    public class SupplierController : ControllerBase
    {
        private readonly ControleEstoqueEFCoreContext context;

        public SupplierController(ControleEstoqueEFCoreContext context)
        {
            this.context = context;
        }

        // GET: api/supplier
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var suppliers = await context.Suppliers
                .Include(s => s.Product)  // Inclui os produtos associados ao fornecedor
                .ToListAsync();
            return Ok(suppliers);
        }

        // GET: api/supplier/getByID
        [HttpGet("getByID")]
        public async Task<IActionResult> GetByID(int supplierID)
        {
            var supplier = await context.Suppliers
                .Include(s => s.Product)
                .FirstOrDefaultAsync(s => s.SupplierID == supplierID);
                
            if (supplier == null)
            {
                return NotFound($"Supplier with ID {supplierID} not found");
            }
            return Ok(supplier);
        }

        [HttpGet("{supplierID}/products")]
        public async Task<IActionResult> GetProductsBySupplier(int supplierID)
        {
            var supplier = await context.Suppliers
                .Include(s => s.Product)
                .FirstOrDefaultAsync(s => s.SupplierID == supplierID);

            if (supplier == null)
            {
                return NotFound($"Supplier with ID {supplierID} not found");
            }

            return Ok(supplier.Product);
        }


        // POST: api/supplier
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] Supplier supplier)
        {
            context.Suppliers.Add(supplier);
            await context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetByID), new { supplierID = supplier.SupplierID }, supplier);
        }

        // PUT: api/supplier
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] Supplier supplier)
        {
            context.Entry(supplier).State = EntityState.Modified;
            await context.SaveChangesAsync();
            return Ok(supplier);
        }

        // DELETE: api/supplier
        [HttpDelete]
        public async Task<IActionResult> DeleteById(int supplierID)
        {
            var supplier = await context.Suppliers.FindAsync(supplierID);
            if (supplier == null)
            {
                return NotFound($"Supplier with ID {supplierID} not found");
            }

            context.Suppliers.Remove(supplier);
            await context.SaveChangesAsync();
            return NoContent();
        }
    }
}

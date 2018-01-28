using System.Linq;
using Microsoft.AspNetCore.Mvc;
using bangazon_inc.Data;
using bangazon_inc.Models;

namespace bangazon_inc.Controllers
{
    [Route("api/[controller]")]

    //Create a new class for the product type table controller
    public class ProductController : Controller
    {
        //Declare an empty variable "_context" to store BangazonContext Class
        private BangazonContext _context;

        //Create a constructor that is equal to BangazonContext. Multiple controller actions will require the same service.  Create a constructor to request those dependencies.
        public ProductController(BangazonContext ctx){
            _context = ctx;
        }


        //Get all product types
        [HttpGet]
        public IActionResult Get()
        {
            //
            var Product = _context.Product.ToList();
            if (Product == null){
                return NotFound();
            }
            return Ok(Product);
        }

        // GET a single product type
        [HttpGet("{id}", Name = "GetSingleProduct")]
    
        public IActionResult Get(int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            try
            {
                Product Product = _context.Product.Single(g => g.ProductId == id);

                if(Product == null)
                {
                    return NotFound();
                }
                return Ok(Product);
            }
            catch (System.InvalidOperationException ex)
            {
                return NotFound(ex);
            }
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
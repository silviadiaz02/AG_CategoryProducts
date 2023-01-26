using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProducts.Business.Interfaces;
using WebApiProducts.Data.Models;
using WebApiProducts.Entities.Models;

namespace WebApiProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : Controller
    {
        private readonly IProductBusiness _managerBusiness;
        public ProductController(IProductBusiness managerBusiness)
        {
            _managerBusiness = managerBusiness;
        }

        // GET: CategoryController
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(Producto))]
        [HttpGet("GetById/{Id}")]
        public ActionResult GetById(int Id)
        {
            var response = _managerBusiness.GetById(Id);
            return StatusCode((int)response.ResponseCode, response);
        }

        // GET: CategoryController/Details/5
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(Producto))]
        [HttpGet("GetList")]
        public IActionResult GetList()
        {
            var response = _managerBusiness.GetList();
            return StatusCode((int)response.ResponseCode, response);
        }

        // GET: CategoryController/Create
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(InputProduct))]
        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] InputProduct objectInsert)
        {
            var response = _managerBusiness.Insert(objectInsert);
            return StatusCode((int)response.ResponseCode, response);
        }        

        // POST: CategoryController/Create
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(InputProduct))]
        [HttpPost("Update")]
        public IActionResult Update([FromBody] InputProduct objectUpdate)
        {
            var response = _managerBusiness.Update(objectUpdate);
            return StatusCode((int)response.ResponseCode, response);
        }

        // GET: CategoryController/Edit/5
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(Producto))]
        [HttpGet("Delete/{Id}")]
        public ActionResult Delete(int Id)
        {
            var response = _managerBusiness.Delete(Id);
            return StatusCode((int)response.ResponseCode, response);
        }
    }
}

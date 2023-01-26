using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiProducts.Business.Interfaces;
using WebApiProducts.Data.Models;

namespace WebApiProducts.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : Controller
    {

        private readonly ICategoryBusiness _managerBusiness;

        public CategoryController(ICategoryBusiness managerBusiness)
        {
            _managerBusiness = managerBusiness;
        }

        // GET: CategoryController
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(Categorium))]
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
        [Produces("application/json", Type = typeof(Categorium))]
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
        [Produces("application/json", Type = typeof(Categorium))]
        [HttpPost("Insert")]
        public IActionResult Insert([FromBody] Categorium objectInsert)
        {
            var response = _managerBusiness.Insert(objectInsert);
            return StatusCode((int)response.ResponseCode, response);
        }

        // POST: CategoryController/Create
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(Categorium))]
        [HttpPost("Update")]
        public IActionResult Update([FromBody] Categorium objectUpdate)
        {
            var response = _managerBusiness.Update(objectUpdate);
            return StatusCode((int)response.ResponseCode, response);
        }

        // GET: CategoryController/Edit/5
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        [ProducesResponseType(403)]
        [Produces("application/json", Type = typeof(Categorium))]
        [HttpGet("Delete/{Id}")]
        public ActionResult Delete(int Id)
        {
            var response = _managerBusiness.Delete(Id);
            return StatusCode((int)response.ResponseCode, response);
        }
    }
}

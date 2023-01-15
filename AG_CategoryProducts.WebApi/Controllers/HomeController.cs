using AG_CategoryProducts.Models;
using AG_CategoryProducts.WebApi.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace AG_CategoryProducts.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        CategoryBL CategoryBL = new CategoryBL();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        [HttpPost, Route("InsertCategory")]
        public bool InsertCategory(categoria objCategoria)
        {
            CategoryBL.InsertarCategoria(objCategoria);
            return true;
        }
        [HttpPost, Route("UpdateCategory")]
        public bool UpdateCategory(categoria objCategoria)
        {
            CategoryBL.ActualizarCategoria(objCategoria);
            return true;
        }
        [HttpPost, Route("DeleteCategory")]
        public bool DeleteCategory(categoria objCategoria)
        {
            CategoryBL.EliminarCategoria(objCategoria);
            return true;
        }
        [HttpGet, Route("GetCategory")]
        public categoria GetCategory(int intidCategoria)
        {           
            return CategoryBL.ConsultarCategoria(intidCategoria); 
        }
        [HttpGet, Route("GetCategorys")]
        public List<categoria> GetCategorys()
        {
            return CategoryBL.ConsultarCategorias();
        }


    }
}

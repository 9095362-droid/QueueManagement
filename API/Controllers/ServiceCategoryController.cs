using BLL;
using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCategoryController : ControllerBase
    {

        private readonly ServiceCategoryBl _bl = new();

        [HttpGet]
        public ActionResult<List<ServiceCategory>> GetAll()
        {
            return _bl.GetAll();
        }

        [HttpGet("{id}")]
        public ActionResult<ServiceCategory> GetById(int id)
        {
            var c = _bl.GetById(id);
            if (c == null) return NotFound();
            return c;
        }

        [HttpPost]
        public IActionResult Add(ServiceCategory c)
        {
            if (!_bl.Add(c)) return BadRequest("Name is required");
            return Ok(c);
        }

        [HttpPut]
        public IActionResult Update(ServiceCategory c)
        {
            if (string.IsNullOrWhiteSpace(c.Name)) return BadRequest("Name is required");
            return _bl.Update(c) ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        { 
            return _bl.Delete(id) ? Ok() : NotFound();
        }
    }
}

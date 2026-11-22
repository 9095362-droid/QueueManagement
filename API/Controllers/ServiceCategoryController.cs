using DAL;
using Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCategoryController : ControllerBase
    {
        private readonly ServiceCategoryDal _dal = new();

        [HttpGet]
        public ActionResult<List<ServiceCategory>> GetAll() => _dal.GetAll();

        [HttpGet("{id}")]
        public ActionResult<ServiceCategory> GetById(int id)
        {
            var c = _dal.GetById(id);
            if (c == null) return NotFound();
            return c;
        }

        [HttpPost]
        public IActionResult Add(ServiceCategory c)
        {
            if (string.IsNullOrWhiteSpace(c.Name)) return BadRequest("Name is required");
            _dal.Add(c);
            return Ok(c);
        }

        [HttpPut]
        public IActionResult Update(ServiceCategory c)
        {
            if (string.IsNullOrWhiteSpace(c.Name)) return BadRequest("Name is required");
            return _dal.Update(c) ? Ok() : NotFound();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id) => _dal.Delete(id) ? Ok() : NotFound();
    }
}

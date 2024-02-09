using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.service.concreate;
using KriptoCüzdan.service.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KriptoCüzdan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlımController : ControllerBase
    {

        private readonly IAlımService _service;

        public AlımController(IAlımService service)
        {
            _service = service;
        }
        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            List<Alım> alım = _service.GetAll();
            return Ok(alım);
        }


        [HttpGet("getbyid")]
        public IActionResult GetById([FromQuery] int id)
        {
            Alım alım = _service.GetById(id);
            return Ok(alım);
        }
        [HttpPost("add")]
       public IActionResult Add([FromBody]AlımAddRequestDto dto)
        {
            _service.Add(dto);
            return Ok("Ekleme Başarılı");
        }
    }
}

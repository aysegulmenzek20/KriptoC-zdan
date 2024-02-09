using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.service.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KriptoCüzdan.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SatımController : ControllerBase
    {
        private readonly ISatımService _sut;

        public SatımController(ISatımService sut)
        {
            _sut = sut;
        }
        [HttpGet("getall")]
        public ActionResult GetAll()
        {
            List<Satım> satıms = _sut.GetAll();
            return Ok(satıms);
        }
        [HttpGet("getbyid")]
        public ActionResult GetById([FromQuery]int id)
        {
         Satım satım = _sut.GetById(id);
            return Ok(satım);

        }
        [HttpPost("add")]
        public IActionResult Add([FromBody]SatımAddRequestDto dto)
        {
            _sut.Add(dto);
            return Ok("Ekleme Başarılı");
        }
    }
}

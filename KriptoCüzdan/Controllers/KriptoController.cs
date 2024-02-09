
using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.Dto.ResponseDto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.service.interfaces;
using Microsoft.AspNetCore.Mvc;

namespace KriptoCüzdan.Controllers;
[Route("api/[controller]")]
[ApiController]

public class KriptoController : ControllerBase
{
    private readonly IKriptoService _kriptoService;

    public KriptoController(IKriptoService kriptoService)
    {
        _kriptoService = kriptoService;
    }
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
        List<Cryptio> kriptos = _kriptoService.GetAll();
        return Ok(kriptos);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery] int id)
    {
        Cryptio kripto = _kriptoService.GetById(id);
        return Ok(kripto);

    }

    [HttpPut("update")]
    public IActionResult Update(KriptoUpdateRequestDto dto)
    {
        _kriptoService.Update(dto);
        return Ok("Güncelleme Başarılı");
    }

    [HttpPost("add")]
    public IActionResult Add([FromBody]KriptoAddRepuestDto dto)
    {
        _kriptoService.Add(dto);
        return Ok("Ekleme Başarılı");
    }

    [HttpDelete("delete")]
    public IActionResult Delete([FromQuery]int id)
    {
        _kriptoService.Delete(id);
        return Ok("Silme işlemi başarılı");
    }

    [HttpGet("getalldetails")]
    public IActionResult GetAllDetails()
    {
List<KriptoResponseDto>result= _kriptoService.GetAllDetails();
        return Ok(result);
    }
}

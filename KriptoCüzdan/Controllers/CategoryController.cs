using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.service.concreate;
using KriptoCüzdan.service.interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace KriptoCüzdan.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoryController : ControllerBase
{
    private readonly ICategoryService _categoryService;

    public CategoryController(ICategoryService categoryService)
    {
        _categoryService = categoryService;
    }
    [HttpGet("getall")]
    public IActionResult GetAll()
    {
    List<Category>categories = _categoryService.GetAll();
    return Ok(categories);
    }

    [HttpGet("getbyid")]
    public IActionResult GetById([FromQuery]int id)
    {
    Category category = _categoryService.GetById(id);
    return Ok(category);
    }
    [HttpPost("add")]
    public IActionResult Add([FromBody] CategoryAddRequestDto dto)
    {
        _categoryService.Add(dto);
        return Ok("Ekleme Başarılı");
    }





}

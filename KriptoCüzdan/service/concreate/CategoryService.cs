using AutoMapper;
using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.repository;
using KriptoCüzdan.service.interfaces;

namespace KriptoCüzdan.service.concreate;

public class CategoryService : ICategoryService
{
    private readonly BaseDbContext _dbContext;
    private readonly IMapper _mapper;
    public CategoryService(BaseDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }


    public void Add(CategoryAddRequestDto dto)
    {
       Category category=_mapper.Map<Category>(dto);
        _dbContext.Categories.Add(category);
        _dbContext.SaveChanges();
    }
    public List<Category> GetAll()
    {
      List<Category> result=_dbContext.Categories.ToList();
        return result;
    }

    public Category GetById(int id)
    {
        Category? category = _dbContext.Categories.Find(id);
        if (category == null)
        {
            throw new Exception($"id:{id} kategori bulunamadı. ");
        }
        return category;
    }
}

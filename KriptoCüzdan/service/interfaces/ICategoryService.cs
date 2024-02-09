using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;

namespace KriptoCüzdan.service.interfaces;

public interface ICategoryService
{
    List<Category> GetAll();
    Category GetById(int id);
    void Add(CategoryAddRequestDto category);

}

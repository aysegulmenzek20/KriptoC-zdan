using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;

namespace KriptoCüzdan.service.interfaces;

public interface IAlımService
{
  void Add( AlımAddRequestDto alım);
    List<Alım> GetAll();
    Alım GetById(int id);
}

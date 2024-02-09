using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.Dto.ResponseDto;
using KriptoCüzdan.model.entity;

namespace KriptoCüzdan.service.interfaces;

public interface IKriptoService
{
    List<Cryptio> GetAll();
    Cryptio GetById(int id);
    void Update(KriptoUpdateRequestDto dto);
    void Add(KriptoAddRepuestDto dto);
    void Delete(int id);


    List<KriptoResponseDto> GetAllDetails();
}

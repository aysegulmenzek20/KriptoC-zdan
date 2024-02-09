using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;

namespace KriptoCüzdan.service.interfaces
{
    public interface ISatımService
    {
        void Add(SatımAddRequestDto satım);
        List<Satım>GetAll();
        Satım GetById(int id);
    }
}

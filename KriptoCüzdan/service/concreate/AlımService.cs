using AutoMapper;
using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.repository;
using KriptoCüzdan.service.interfaces;

namespace KriptoCüzdan.service.concreate;





public class AlımService : IAlımService
{

    private readonly BaseDbContext _dbContext;
    private readonly IMapper _mapper;

    public AlımService(BaseDbContext dbContext, IMapper mapper)
    {
        _dbContext = dbContext;
        _mapper = mapper;
    }

    public void Add(AlımAddRequestDto dto)
    {
        Alım alım= _mapper.Map<Alım>(dto);
        _dbContext.Alım.Add(alım);
        _dbContext.SaveChanges();
    }

    public List<Alım> GetAll()
    {
        List<Alım> alıms = _dbContext.Alım.ToList();
        return alıms;
    }

    public Alım GetById(int id)
    {
        Alım? alım = _dbContext.Alım.Find(id);
        if (alım == null)
        {
            throw new Exception($"id:{id} alım bulunamadı. ");
        }
        return alım;
    }
}

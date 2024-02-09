using AutoMapper;
using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.repository;
using KriptoCüzdan.service.interfaces;

namespace KriptoCüzdan.service.concreate
{
    public class SatımService : ISatımService
    {
        private readonly BaseDbContext _dbContext;
        private readonly IMapper _mapper;

        public SatımService(BaseDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Add(SatımAddRequestDto dto)
        {

            Satım satım = _mapper.Map<Satım>(dto);
            _dbContext.Satım.Add(satım);
            _dbContext.SaveChanges();
        }

        public List<Satım> GetAll()
        {
            List<Satım> satıms = _dbContext.Satım.ToList();
            return satıms;
        }

        public Satım GetById(int id)
        {
            Satım? satım = _dbContext.Satım.Find(id);
            if (satım == null)
            {
                throw new Exception($"id:{id} satım bulunamadı. ");
            }
            return satım;
        }
    }
}

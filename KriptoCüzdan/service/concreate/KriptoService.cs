using AutoMapper;
using KriptoCüzdan.model.Dto;
using KriptoCüzdan.model.Dto.ResponseDto;
using KriptoCüzdan.model.entity;
using KriptoCüzdan.repository;
using KriptoCüzdan.service.interfaces;
using Microsoft.EntityFrameworkCore;

namespace KriptoCüzdan.service.concreate
{
    public class KriptoService : IKriptoService
    {    
        private readonly BaseDbContext _dbContext;
        private readonly IMapper _mapper;

        public KriptoService(BaseDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public void Add(KriptoAddRepuestDto dto)
        {
            Cryptio kripto = _mapper.Map<Cryptio>(dto);
            _dbContext.cryptios.Add(kripto);
            _dbContext.SaveChanges();
        }

        public void Delete(int id)
        {
           Cryptio? kripto=_dbContext.cryptios.Find(id);
            if (kripto == null)
            {
                throw new Exception($"id:{id}coin bulunamadı."); // hata verir errror
            }
            _dbContext.cryptios.Remove(kripto);
            _dbContext.SaveChanges();
        }

        public List<Cryptio> GetAll()
        {
            List<Cryptio> kripto = _dbContext.cryptios.ToList();
            return kripto;
        }

        public List<KriptoResponseDto> GetAllDetails()
        {
          List<Cryptio>kripto= _dbContext.cryptios
                .Include(x=>x.Alım)
                .Include(x=>x.Satım)
                .Include(x=>x.Category)
                .ToList();
            List<KriptoResponseDto> response = _mapper.Map<List<KriptoResponseDto>>(kripto);
            return response;



        }

        public Cryptio GetById(int id)
        {
            Cryptio? kripto = _dbContext.cryptios.Find(id);
            if(kripto == null)
            {
                throw new Exception($"id:{id} coin bulunamadı. ");
            }
            return kripto;  
        }

        public void Update(KriptoUpdateRequestDto dto)
        {

            Cryptio? kripto = _dbContext.cryptios.Find(dto.Id);
            if (kripto == null)
            {
                throw new Exception($"id:{dto.Id} coin bulunamadı. ");
            }

            Cryptio UpdateKripto = _mapper.Map<Cryptio>(dto);
            _dbContext.cryptios.Update(UpdateKripto);
            _dbContext.SaveChanges();
        }
    }
}

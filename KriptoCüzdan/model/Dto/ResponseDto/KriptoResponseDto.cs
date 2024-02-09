using KriptoCüzdan.model.entity;

namespace KriptoCüzdan.model.Dto.ResponseDto
{
    public class KriptoResponseDto
    {
        public required string name { get; set; }
        public double lot { get; set; }
        public double değer { get; set; }
        public string AlımName { get; set; }
        public Alım Alım { get; set; }
        public string SatımName { get; set; }
        public Satım Satım { get; set; }
        public string CategoryName { get; set; }
        public Category Category { get; set; }
        public string Kripto_1_Name { get; set; }
        public Kripto_1_ Kripto_1_ { get; set; }
    }
}

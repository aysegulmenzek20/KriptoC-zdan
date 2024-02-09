using KriptoCüzdan.model.entity;

namespace KriptoCüzdan.model.Dto;

public class KriptoAddRepuestDto
{
    public  string name { get; set; }
    public double lot { get; set; }
    public double değer { get; set; }
    public int AlımId { get; set; }
    public int SatımId { get; set; }
    public int CategoryId {  get; set; }



}

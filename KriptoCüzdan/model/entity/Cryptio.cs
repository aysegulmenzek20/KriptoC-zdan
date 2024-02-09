using KriptoCüzdan.model.Dto;

namespace KriptoCüzdan.model.entity;

public class Cryptio:Entity
{
    public required string name { get; set; }
    public double lot {  get; set; }
    public double değer { get; set; }
    //public int AlımId { get; set; }
    public Alım Alım { get; set; }
    //public int SatımId { get; set; }
    public Satım Satım { get; set; }
    //public int CategoryId {  get; set; }
    public Category Category { get; set; }
    //public int Kripto_1_Id {  get; set; }
    public Kripto_1_ Kripto_1_ {  get; set; }



}

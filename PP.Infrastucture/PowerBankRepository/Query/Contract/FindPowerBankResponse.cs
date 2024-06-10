namespace PP.Infrastucture.PowerBankRepository.Query.Contract;

public class FindPowerBankResponse
{
    public long Id { get; set; }
    
    public float Longitude { get; set; }
    
    public float Latitude { get; set; }
    
    public float RemainingPower { get; set; }
}
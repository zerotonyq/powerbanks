using PP.Domain.Entities;

namespace PP.Infrastucture.PowerStationRepository;

public class PowerStationRepository : IPowerStationRepository
{
    public Task<PowerStation> Get(long id)
    {
        throw new NotImplementedException();
    }

    public Task Add(PowerStation newPowerBank)
    {
        throw new NotImplementedException();
    }

    public Task Update(PowerStation powerBank)
    {
        throw new NotImplementedException();
    }
}
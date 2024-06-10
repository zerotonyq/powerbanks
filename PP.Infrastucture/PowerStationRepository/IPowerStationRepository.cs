using PP.Domain.Entities;

namespace PP.Infrastucture.PowerStationRepository;

public interface IPowerStationRepository
{
    Task<PowerStation> Get(long id);

    Task Add(PowerStation newPowerBank);

    Task Update(PowerStation powerBank);
}
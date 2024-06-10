using PP.Domain.Entities;

namespace PP.Infrastucture.PowerBankRepository;

public interface IPowerBankRepository
{
    Task<PowerBank> Get(long id, CancellationToken cancellationToken);

    Task Add(PowerBank newPowerBank, CancellationToken cancellationToken);

    Task Update(PowerBank powerBank, CancellationToken cancellationToken);
}
using PP.Domain.Entities.Base;

namespace PP.Domain.Entities;

public sealed class PowerStation : PositionEntity
{
    public int PowerBanksMaxCount { get; set; }

    public List<PowerBank> PowerBanks = new();
}
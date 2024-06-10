using PP.Domain.Entities.Base;

namespace PP.Domain.Entities;

public class PowerBank : PositionEntity
{
    public float RemainingPower { get; set; }
}
namespace PP.Domain.Entities.Base;

public class PositionEntity : BaseEntity
{
    public required float Longitude { get; set; }

    public required float Latitude { get; set; }
}
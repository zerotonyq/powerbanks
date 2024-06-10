using PP.Domain.Entities.Base;

namespace PP.Domain.Entities;

public sealed class User : PositionEntity
{
    public string Username { get; set; }
    
    public string Password { get; set; }
    
    public string AvatarUrl { get; set; }
    
    public PowerBank? PowerBank { get; set; }
}
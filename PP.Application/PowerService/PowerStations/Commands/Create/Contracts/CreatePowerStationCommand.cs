using MediatR;
using PP.Domain.Entities;

namespace PP.Application.PowerService.PowerStations.Commands.Create.Contracts;

public sealed record CreatePowerStationCommand(
    float Longitude,
    float Latitude,
    int PowerBanksMaxCount,
    IList<PowerBank> PowerBanks) : IRequest<CreatePowerStationResponse>
{
    
}
using MediatR;
using PP.Domain.Entities;

namespace PP.Application.PowerService.PowerStations.Commands.Update.Contracts;

public sealed record UpdatePowerStationCommand(
    float Longitude,
    float Latitude,
    int PowerBanksMaxCount,
    IList<PowerStation> PowerBanks) : IRequest<UpdatePowerStationResponse>
{
    
}
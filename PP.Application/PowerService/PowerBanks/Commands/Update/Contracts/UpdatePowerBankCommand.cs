using MediatR;
using PP.Application.PowerService.PowerBanks.Commands.Create.Contracts;

namespace PP.Application.PowerService.PowerBanks.Commands.Update.Contracts;

public sealed record UpdatePowerBankCommand(
    long Id,
    float Longitude,
    float Latitude,
    float RemainingPower) : IRequest<UpdatePowerBankResponse>
{
    
}
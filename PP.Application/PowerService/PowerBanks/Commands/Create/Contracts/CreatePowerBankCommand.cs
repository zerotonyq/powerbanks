using MediatR;

namespace PP.Application.PowerService.PowerBanks.Commands.Create.Contracts;

public sealed record CreatePowerBankCommand(
    float Longitude,
    float Latitude,
    float RemainingPower) : IRequest<CreatePowerBankResponse>
{
}
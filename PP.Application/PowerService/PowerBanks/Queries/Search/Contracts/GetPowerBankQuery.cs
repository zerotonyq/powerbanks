using MediatR;

namespace PP.Application.PowerService.PowerBanks.Queries.Search.Contracts;

public sealed record GetPowerBankQuery(long id) : IRequest<GetPowerBankResponse>;
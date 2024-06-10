using MediatR;

namespace PP.Application.PowerService.PowerStations.Queries.Search.Contracts;

public sealed record GetPowerStationQuery(long id) : IRequest<GetPowerStationResponse>;
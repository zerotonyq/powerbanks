using AutoMapper;
using MediatR;
using PP.Application.PowerService.PowerStations.Queries.Search.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerStationRepository;

namespace PP.Application.PowerService.PowerStations.Queries.Search;

public class GetPowerStationHandler : IRequestHandler<GetPowerStationQuery, GetPowerStationResponse>
{
    private readonly IPowerStationRepository _powerStationRepository;

    public GetPowerStationHandler(IPowerStationRepository powerStationRepository) => _powerStationRepository = powerStationRepository;

    public async Task<GetPowerStationResponse> Handle(GetPowerStationQuery request, CancellationToken cancellationToken)
    {
        PowerStation powerStation = await _powerStationRepository.Get(request.id);

        return new GetPowerStationResponse(powerStation);
    }
}
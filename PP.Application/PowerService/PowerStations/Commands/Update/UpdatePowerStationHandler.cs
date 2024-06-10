using AutoMapper;
using MediatR;
using PP.Application.Mappers;
using PP.Application.PowerService.PowerStations.Commands.Update.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerStationRepository;

namespace PP.Application.PowerService.PowerStations.Commands.Update;

public class UpdatePowerStationHandler : IRequestHandler<UpdatePowerStationCommand, UpdatePowerStationResponse>
{
    private readonly IPowerStationRepository _powerStationRepository;

    public UpdatePowerStationHandler(IPowerStationRepository powerStationRepository) => _powerStationRepository = powerStationRepository;

    public async Task<UpdatePowerStationResponse> Handle(UpdatePowerStationCommand request, CancellationToken cancellationToken)
    {
        PowerStation? powerStation = PowerStationMapper.UpdatePowerStationCommandToPowerStation(request);

        await _powerStationRepository.Update(powerStation);

        return new UpdatePowerStationResponse();
    }
}
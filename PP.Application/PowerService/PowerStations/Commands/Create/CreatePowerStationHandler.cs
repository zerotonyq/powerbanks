using AutoMapper;
using MediatR;
using PP.Application.Mappers;
using PP.Application.PowerService.PowerStations.Commands.Create.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerStationRepository;

namespace PP.Application.PowerService.PowerStations.Commands.Create;

public class CreatePowerStationHandler : IRequestHandler<CreatePowerStationCommand, CreatePowerStationResponse >
{
    private readonly IPowerStationRepository _powerStationRepository;

    public CreatePowerStationHandler(IPowerStationRepository powerStationRepository) => _powerStationRepository = powerStationRepository;

    public async Task<CreatePowerStationResponse> Handle(CreatePowerStationCommand request, CancellationToken cancellationToken)
    {
        PowerStation? powerStation = PowerStationMapper.CreatePowerStationCommandToPowerStation(request);

        await _powerStationRepository.Add(powerStation);

        return new CreatePowerStationResponse();
    }
}
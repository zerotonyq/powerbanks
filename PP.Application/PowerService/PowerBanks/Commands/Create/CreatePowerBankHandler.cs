using AutoMapper;
using MediatR;
using PP.Application.Mappers;
using PP.Application.PowerService.PowerBanks.Commands.Create.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerBankRepository;

namespace PP.Application.PowerService.PowerBanks.Commands.Create;

public class CreatePowerBankHandler : IRequestHandler<CreatePowerBankCommand, CreatePowerBankResponse>
{
    private readonly IPowerBankRepository _powerBankRepository;

    public CreatePowerBankHandler(IPowerBankRepository powerBankRepository) => _powerBankRepository = powerBankRepository;

    public async Task<CreatePowerBankResponse> Handle(CreatePowerBankCommand request, CancellationToken cancellationToken)
    {
        PowerBank? powerBank = PowerBankMapper.CreatePowerBankCommandToPowerBank(request);

        await _powerBankRepository.Add(powerBank, new CancellationToken());

        return new CreatePowerBankResponse();
    }
}
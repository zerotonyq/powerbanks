using AutoMapper;
using MediatR;
using PP.Application.Mappers;
using PP.Application.PowerService.PowerBanks.Commands.Update.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerBankRepository;

namespace PP.Application.PowerService.PowerBanks.Commands.Update;

public class UpdatePowerBankHandler : IRequestHandler<UpdatePowerBankCommand, UpdatePowerBankResponse>
{
    private readonly IPowerBankRepository _powerBankRepository;

    public UpdatePowerBankHandler(IPowerBankRepository powerBankRepository) => _powerBankRepository = powerBankRepository;

    public async Task<UpdatePowerBankResponse> Handle(UpdatePowerBankCommand request, CancellationToken cancellationToken)
    {
        PowerBank? powerBank = PowerBankMapper.UpdatePowerBankCommandToPowerBank(request);

        await _powerBankRepository.Update(powerBank, new CancellationToken());

        return new UpdatePowerBankResponse();
    }
}
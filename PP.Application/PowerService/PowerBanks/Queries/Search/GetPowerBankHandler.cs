using AutoMapper;
using MediatR;
using PP.Application.PowerService.PowerBanks.Queries.Search.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerBankRepository;

namespace PP.Application.PowerService.PowerBanks.Queries.Search;

public class GetPowerBankHandler : IRequestHandler<GetPowerBankQuery, GetPowerBankResponse>
{
    private readonly IPowerBankRepository _powerBankRepository;

    public GetPowerBankHandler(IPowerBankRepository powerBankRepository) => _powerBankRepository = powerBankRepository;

    public async Task<GetPowerBankResponse> Handle(GetPowerBankQuery request, CancellationToken cancellationToken)
    {
        PowerBank powerBank = await _powerBankRepository.Get(request.id, new CancellationToken());

        return new GetPowerBankResponse(powerBank);
    }
}
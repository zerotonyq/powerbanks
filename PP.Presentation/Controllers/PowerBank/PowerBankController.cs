using MediatR;
using Microsoft.AspNetCore.Mvc;
using PP.Application.PowerService.PowerBanks.Commands.Create.Contracts;
using PP.Application.PowerService.PowerBanks.Commands.Update.Contracts;

namespace MEGAPETPROJECT.Controllers.PowerBank;

[ApiController]
[Route("[controller]")]
public class PowerBankController
{
    private readonly IMediator _mediator;

    public PowerBankController(IMediator mediator) => _mediator = mediator;

    [HttpPost(nameof(Create))]
    public async Task<CreatePowerBankResponse> Create(CreatePowerBankCommand createPowerBankCommand)
    {
        return await _mediator.Send(createPowerBankCommand);
    }

    [HttpPut(nameof(Update))]
    public async Task<UpdatePowerBankResponse> Update(UpdatePowerBankCommand updatePowerBankCommand)
    {
        return await _mediator.Send(updatePowerBankCommand);
    }
}
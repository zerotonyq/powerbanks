using MediatR;
using Microsoft.AspNetCore.Mvc;
using PP.Application.PowerService.PowerStations.Commands.Create.Contracts;
using PP.Application.PowerService.PowerStations.Commands.Update.Contracts;

namespace MEGAPETPROJECT.Controllers.PowerStation;

[ApiController]
[Route("[controller]")]
public class PowerStationController
{
    private readonly IMediator _mediator;

    public PowerStationController(IMediator mediator) => _mediator = mediator;

    [HttpPost(nameof(Create))]
    public async Task<CreatePowerStationResponse> Create(CreatePowerStationCommand createPowerStationCommand)
    {
        return await _mediator.Send(createPowerStationCommand);
    }

    [HttpPut(nameof(Update))]
    public async Task<UpdatePowerStationResponse> Update(UpdatePowerStationCommand updatePowerStationCommand)
    {
        return await _mediator.Send(updatePowerStationCommand);
    }
}
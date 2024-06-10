using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PP.Application.UserService.Commands.Users.Contracts;
using PP.Application.UserService.Commands.Users.Update.Contracts;

namespace MEGAPETPROJECT.Controllers.User;

[ApiController]
[Route("[controller]")]
public class UserController
{
    private readonly IMediator _mediator;

    public UserController(IMediator mediator) => _mediator = mediator;

    [HttpPost(nameof(Create))]
    public async Task<CreateUserResponse> Create(CreateUserCommand createUserCommand)
    {
        return await _mediator.Send(createUserCommand);
    }

    [HttpPut(nameof(Update))]
    public async Task<UpdateUserResponse> Update(UpdateUserCommand updateUserCommand)
    {
        return await _mediator.Send(updateUserCommand);
    }
    
}
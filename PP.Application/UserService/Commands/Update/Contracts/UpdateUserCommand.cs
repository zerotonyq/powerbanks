using MediatR;
using PP.Domain.Entities;

namespace PP.Application.UserService.Commands.Users.Update.Contracts;

public sealed record UpdateUserCommand(
    long Id,
    float Longitude,
    float Latitude,
    string UserName,
    string Password,
    string AvatarUrl,
    long? PowerBankId = null) : IRequest<UpdateUserResponse>;
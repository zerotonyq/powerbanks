using PP.Domain.Entities;
using MediatR;

namespace PP.Application.UserService.Commands.Users.Contracts;

public sealed record CreateUserCommand(
    float Longitude,
    float Latitude,
    string Username,
    string Password,
    string AvatarUrl) : IRequest<CreateUserResponse>;
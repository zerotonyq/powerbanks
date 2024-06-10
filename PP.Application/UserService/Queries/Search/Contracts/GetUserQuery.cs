using MediatR;

namespace PP.Application.UserService.Users.Queries.Search.Contracts;

public sealed record GetUserQuery(long id) : IRequest<GetUserResponse>;
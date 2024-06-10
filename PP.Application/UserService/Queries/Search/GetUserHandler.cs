using AutoMapper;
using MediatR;
using PP.Application.UserService.Users.Queries.Search.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.UserRepository;

namespace PP.Application.UserService.Users.Queries.Search;

public class GetUserHandler : IRequestHandler<GetUserQuery, GetUserResponse>
{
    private readonly IUserRepository _userRepository;

    public GetUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

    public async Task<GetUserResponse> Handle(GetUserQuery request, CancellationToken cancellationToken)
    {
        User user = await _userRepository.Get(request.id, new CancellationToken());

        return new GetUserResponse(user);
    }
}
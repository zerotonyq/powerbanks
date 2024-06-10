
using MediatR;
using PP.Application.Mappers;
using PP.Application.UserService.Commands.Users.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.UserRepository;

namespace PP.Application.UserService.Commands.Create;

public class CreateUserHandler : IRequestHandler<CreateUserCommand, CreateUserResponse>
{
    private readonly IUserRepository _userRepository;

    public CreateUserHandler(IUserRepository userRepository) => _userRepository = userRepository;

    public async Task<CreateUserResponse> Handle(CreateUserCommand request, CancellationToken cancellationToken)
    {
        User? user = UserMapper.CreateUserCommandToUser(request);
        
        await _userRepository.Add(user, new CancellationToken());

        return new CreateUserResponse();
    }
}
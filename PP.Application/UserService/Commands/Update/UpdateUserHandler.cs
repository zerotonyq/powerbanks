using AutoMapper;
using MediatR;
using PP.Application.Mappers;
using PP.Application.PowerService.PowerBanks.Queries.Search;
using PP.Application.PowerService.PowerBanks.Queries.Search.Contracts;
using PP.Application.UserService.Commands.Users.Update.Contracts;
using PP.Domain.Entities;
using PP.Infrastucture.PowerBankRepository;
using PP.Infrastucture.UserRepository;

namespace PP.Application.UserService.Commands.Users.Update;

public class UpdateUserHandler : IRequestHandler<UpdateUserCommand, UpdateUserResponse>
{
    private readonly IUserRepository _userRepository;
    private readonly GetPowerBankHandler _getPowerBankHandler;

    public UpdateUserHandler(IUserRepository userRepository, GetPowerBankHandler getPowerBankHandler)
    {
        _userRepository = userRepository;
        _getPowerBankHandler = getPowerBankHandler;
    }

    public async Task<UpdateUserResponse> Handle(UpdateUserCommand request, CancellationToken cancellationToken)
    {
        User? user = UserMapper.UpdateUserCommandToUser(request);

        var powerBank = await _getPowerBankHandler.Handle(new GetPowerBankQuery(request.PowerBankId ?? -1), new CancellationToken());
        
        user.PowerBank = powerBank.PowerBank;
        
        await _userRepository.Update(user, new CancellationToken());

        return new UpdateUserResponse();
    }
}
using PP.Application.UserService.Commands.Users.Contracts;
using PP.Application.UserService.Commands.Users.Update.Contracts;
using PP.Domain.Entities;
using Riok.Mapperly.Abstractions;

namespace PP.Application.Mappers;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
internal static partial class UserMapper
{
    public static partial CreateUserCommand UserToCreateUserCommand(User user);
    
    public static partial User CreateUserCommandToUser(CreateUserCommand createUserCommand);

    public static partial UpdateUserCommand UserToUpdateUserCommand(User user);

    public static partial User UpdateUserCommandToUser(UpdateUserCommand updateUserCommand);
}
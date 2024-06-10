using Dapper;
using PP.Domain.Entities;

namespace PP.Infrastucture.UserRepository.Command;

public class UserCommand
{
    public static CommandDefinition Create(User user, CancellationToken cancellationToken)
    {
        const string sqlQuery = @"
                INSERT INTO Users (
                    longitude,
                    latitude,
                    username,
                    password,
                    avatar_url
                )
                VALUES (
                    @Longitude,
                    @Latitude,
                    @Username,
                    @Password,
                    @AvatarUrl
                )";
        
        var parameters = new
        {
            user.Longitude,
            user.Latitude,
            user.Username,
            user.Password,
            user.AvatarUrl,
        };

        var commandDefinition = new CommandDefinition(
            sqlQuery,
            parameters,
            cancellationToken: cancellationToken);

        return commandDefinition;
    }

    public static CommandDefinition Update(User user, CancellationToken cancellationToken)
    {
        const string sqlQuery = @"
            UPDATE Users SET 
            longitude = @Longitude,
            latitude = @Latitude,
            username = @Username,
            password = @Password,
            avatar_url = @AvatarUrl,
            power_bank_id = @PowerBankId
            where id = @Id";
        
        var parameters = new
        {
            user.Longitude,
            user.Latitude,
            user.Username,
            user.Password,
            user.AvatarUrl,
            PowerBankId = user.PowerBank?.Id,
            user.Id
        };
        var command = new CommandDefinition(
            sqlQuery,
            parameters,
            cancellationToken: cancellationToken);

        return command;
    }
}
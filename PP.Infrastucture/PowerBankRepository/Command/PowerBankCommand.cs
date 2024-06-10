using Dapper;
using PP.Domain.Entities;

namespace PP.Infrastucture.PowerBankRepository.Command;

public class PowerBankCommand
{
    public static CommandDefinition Create(PowerBank powerBank, CancellationToken cancellationToken)
    {
        const string sqlQuery = @"
                INSERT INTO power_banks (
                    longitude,
                    latitude,
                    remaining_power
                )
                VALUES (
                    @Longitude,
                    @Latitude,
                    @RemainingPower
                )";

        var parameters = new
        {
            powerBank.Longitude,
            powerBank.Latitude,
            powerBank.RemainingPower
        };

        var commandDefinition = new CommandDefinition(
            sqlQuery,
            parameters,
            cancellationToken: cancellationToken);

        return commandDefinition;
    }

    public static CommandDefinition Update(PowerBank powerBank, CancellationToken cancellationToken)
    {
        const string sqlQuery = @"
            UPDATE power_banks set
            longitude = @Longitude,
            latitude = @Latitude,
            remaining_power = @RemainingPower
            where id = @Id
            ";

        var parameters = new
        {
            powerBank.Longitude,
            powerBank.Latitude,
            powerBank.RemainingPower,
            powerBank.Id
        };

        var command = new CommandDefinition(
            sqlQuery,
            parameters,
            cancellationToken: cancellationToken);

        return command;
    }
    
}
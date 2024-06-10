using Dapper;

namespace PP.Infrastucture.PowerBankRepository.Query;

public class PowerBankQuery
{
    public static CommandDefinition GetById(long id, CancellationToken cancellationToken)
    {
        const string sqlQuery = @"
                SELECT * FROM power_banks where id = @Id";

        var command = new CommandDefinition(
            sqlQuery,
            new
            {
                Id = id
            }, 
            cancellationToken: cancellationToken);

        return command;
    }
}
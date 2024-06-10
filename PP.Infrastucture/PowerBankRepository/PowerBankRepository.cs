using System.Data;
using Dapper;
using PP.Domain.Entities;
using PP.Domain.Exceptions;
using PP.Infrastucture.PowerBankRepository.Command;
using PP.Infrastucture.PowerBankRepository.Query;
using PP.Infrastucture.PowerBankRepository.Query.Contract;
using PP.Shared.DB;

namespace PP.Infrastucture.PowerBankRepository;

public class PowerBankRepository(DbConnectionFactory factory) : IPowerBankRepository
{
    
    private readonly IDbConnection _connection = factory.CreateConnection();
    public async Task<PowerBank> Get(long id, CancellationToken cancellationToken)
    {
        CommandDefinition queryResult = PowerBankQuery.GetById(id, cancellationToken);

        var powerBankResponse = await _connection.QueryFirstOrDefaultAsync<FindPowerBankResponse>(queryResult);

        if (powerBankResponse == null) throw new EntityNotFoundException("There is no such power bank to get");

        var powerBank = new PowerBank()
        {
            Id = powerBankResponse.Id,
            Longitude = powerBankResponse.Longitude,
            Latitude = powerBankResponse.Latitude,
            RemainingPower = powerBankResponse.RemainingPower
        };
        
        return powerBank;
    }

    public async Task Add(PowerBank newPowerBank, CancellationToken cancellationToken)
    {
        CommandDefinition commandDefinition = PowerBankCommand.Create(newPowerBank, cancellationToken);
        
        int rowsAffected = await _connection.ExecuteAsync(commandDefinition);

        if (rowsAffected == 0)
            throw new Exception("power bank creation failed.");
    }

    public async Task Update(PowerBank powerBank, CancellationToken cancellationToken)
    {
        CommandDefinition commandDefinition = PowerBankCommand.Update(powerBank, cancellationToken);
        
        int rowsAffected = await _connection.ExecuteAsync(commandDefinition);

        if (rowsAffected == 0)
            throw new Exception("power bank update failed");
    }
}
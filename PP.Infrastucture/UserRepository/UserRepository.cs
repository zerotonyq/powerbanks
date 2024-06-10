using System.Data;
using Dapper;
using PP.Domain.Entities;
using PP.Infrastucture.UserRepository.Command;
using PP.Shared.DB;

namespace PP.Infrastucture.UserRepository;

public class UserRepository(DbConnectionFactory factory) : IUserRepository
{
    
    private readonly IDbConnection _connection = factory.CreateConnection();
    public async Task<User> Get(long id, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
        
    }

    public async Task Add(User user, CancellationToken cancellationToken)
    {
        Console.WriteLine(user.Username + " -----------------");
        CommandDefinition commandDefinition = UserCommand.Create(user, cancellationToken);
        
        int rowsAffected = await _connection.ExecuteAsync(commandDefinition);

        if (rowsAffected == 0)
            throw new Exception("user creation failed.");
    }

    public async Task Update(User user, CancellationToken cancellationToken)
    {
        CommandDefinition commandDefinition = UserCommand.Update(user, cancellationToken);

        int rowsAffected = await _connection.ExecuteAsync(commandDefinition);

        if (rowsAffected == 0)
            throw new Exception("user update failed");
    }
}
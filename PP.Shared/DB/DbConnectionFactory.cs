using System.Data;
using Microsoft.Extensions.Options;
using Npgsql;
using PP.Shared.DB.Config;

namespace PP.Shared.DB;

public class DbConnectionFactory(IOptionsMonitor<DatabaseConfiguration> dbSettings)
{
	private static NpgsqlConnection? _existingConnection;

	public IDbConnection CreateConnection()
	{
		if (_existingConnection != null) { return _existingConnection; }

		string connectionString = CreateConnectionString(dbSettings.CurrentValue);

		var connection = new NpgsqlConnection(connectionString);

		_existingConnection = connection;

		return connection;
	}

	public static string CreateConnectionString(DatabaseConfiguration databaseConfiguration)
	{
		return $"Host={databaseConfiguration.Server}; " +
		       $"Database={databaseConfiguration.Database}; " +
		       $"Username={databaseConfiguration.Username}; " +
		       $"Password={databaseConfiguration.Password};";
	}
}
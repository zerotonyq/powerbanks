using System.Text.Json;
using System.Text.Json.Serialization;
using PP.Application;
using PP.Infrastucture;
using PP.Shared.DB;
using PP.Shared.DB.Config;

var builder = WebApplication.CreateBuilder(args);

var services = builder.Services;
var configuration = builder.Configuration;

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
services.AddEndpointsApiExplorer();
services.AddSwaggerGen();

services.AddMediatR
(
    serviceConfiguration =>
    {
        serviceConfiguration
            .RegisterServicesFromAssemblies
            (
                AppDomain
                    .CurrentDomain
                    .GetAssemblies()
            );
    }
);

DatabaseInjection.Configure(services, configuration);
ApplicationInjection.Configure(services, configuration);
InfrastructureInjection.Configure(services, configuration);


services.AddControllers()
    .AddJsonOptions
    (
        x =>
        {
            x.JsonSerializerOptions.Converters.Add(new JsonStringEnumConverter());
            x.JsonSerializerOptions.DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingNull;
            x.JsonSerializerOptions.PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower;
        }
    );





var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.MapControllers();


app.Run();
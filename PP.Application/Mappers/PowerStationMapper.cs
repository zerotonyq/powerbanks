using PP.Application.PowerService.PowerStations.Commands.Create.Contracts;
using PP.Application.PowerService.PowerStations.Commands.Update.Contracts;
using PP.Application.UserService.Commands.Users.Contracts;
using PP.Domain.Entities;
using Riok.Mapperly.Abstractions;
namespace PP.Application.Mappers;

[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
internal static partial class PowerStationMapper
{
    public static partial CreatePowerStationCommand PowerStationToCreatePowerStationCommand(PowerStation powerStation);
    
    public static partial PowerStation CreatePowerStationCommandToPowerStation(CreatePowerStationCommand createPowerStationCommand);

    public static partial UpdatePowerStationCommand PowerStationToUpdatePowerStationCommand(PowerStation powerStationl);

    public static partial PowerStation UpdatePowerStationCommandToPowerStation(
        UpdatePowerStationCommand updatePowerStationCommandl);
}
using PP.Application.PowerService.PowerBanks.Commands.Create.Contracts;
using PP.Application.PowerService.PowerBanks.Commands.Update.Contracts;
using PP.Application.UserService.Commands.Users.Contracts;
using PP.Domain.Entities;

namespace PP.Application.Mappers;
using Riok.Mapperly.Abstractions;


[Mapper(EnumMappingStrategy = EnumMappingStrategy.ByName, EnumMappingIgnoreCase = true)]
internal static partial class PowerBankMapper
{
    public static partial CreatePowerBankCommand PowerBankToCreatePowerBankCommand(PowerBank powerBank);
    
    public static partial PowerBank CreatePowerBankCommandToPowerBank(CreatePowerBankCommand createPowerBankCommand);

    public static partial UpdatePowerBankCommand PowerBankToUpdatePowerBankCommand(PowerBank powerBank);

    public static partial PowerBank UpdatePowerBankCommandToPowerBank(UpdatePowerBankCommand updatePowerBankCommand);
}
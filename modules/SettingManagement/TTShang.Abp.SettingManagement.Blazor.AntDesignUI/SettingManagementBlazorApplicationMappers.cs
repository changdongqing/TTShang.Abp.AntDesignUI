using Riok.Mapperly.Abstractions;
using Volo.Abp.Mapperly;
using Volo.Abp.SettingManagement;

namespace TTShang.Abp.SettingManagement.Blazor.AntDesignUI;

[Mapper(RequiredMappingStrategy = RequiredMappingStrategy.Target)]
public partial class SettingManagementBlazorMapper : MapperBase<EmailSettingsDto, UpdateEmailSettingsDto>
{
    public override partial UpdateEmailSettingsDto Map(EmailSettingsDto source);

    public override partial void Map(EmailSettingsDto source, UpdateEmailSettingsDto destination);
}

using Lsw.Abp.AntDesignUI;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;

namespace Lsw.Abp.PermissionManagement.Blazor.AntDesignUI;

[DependsOn(
    typeof(AbpAntDesignUIModule),
    typeof(AbpMapperlyModule),
    typeof(AbpPermissionManagementApplicationContractsModule)
)]
public class AbpPermissionManagementBlazorAntDesignModule : AbpModule
{

}

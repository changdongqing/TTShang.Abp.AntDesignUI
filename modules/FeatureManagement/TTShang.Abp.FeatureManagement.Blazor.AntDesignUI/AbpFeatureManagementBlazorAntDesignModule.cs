using TTShang.Abp.AspnetCore.Components.Web.AntDesignTheme;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Features;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;

namespace TTShang.Abp.FeatureManagement.Blazor.AntDesignUI;

[DependsOn(
    typeof(AbpAspNetCoreComponentsWebAntDesignThemeModule),
    typeof(AbpMapperlyModule),
    typeof(AbpFeatureManagementApplicationContractsModule),
    typeof(AbpFeaturesModule)
)]
public class AbpFeatureManagementBlazorAntDesignModule : AbpModule
{

}

using TTShang.Abp.AspnetCore.Components.Web.AntDesignTheme;
using TTShang.Abp.AspnetCore.Components.Web.AntDesignTheme.Routing;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using TTShang.Abp.SettingManagement.Blazor.AntDesignUI.Settings;
using Volo.Abp.SettingManagement;
using Volo.Abp.SettingManagement.Blazor;
using Volo.Abp.UI.Navigation;

namespace TTShang.Abp.SettingManagement.Blazor.AntDesignUI;

[DependsOn(
    typeof(AbpMapperlyModule),
    typeof(AbpSettingManagementApplicationContractsModule),
    typeof(AbpAspNetCoreComponentsWebAntDesignThemeModule)
)]
public class AbpSettingManagementBlazorAntDesignModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMapperlyObjectMapper<AbpSettingManagementBlazorAntDesignModule>();

        Configure<AbpNavigationOptions>(options =>
        {
            options.MenuContributors.Add(new SettingManagementMenuContributor());
        });

        Configure<AbpRouterOptions>(options =>
        {
            options.AdditionalAssemblies.Add(typeof(AbpSettingManagementBlazorAntDesignModule).Assembly);
        });

        Configure<SettingManagementComponentOptions>(options =>
        {
            options.Contributors.Add(new AntDesignSettingDefultPageContributor());
            options.Contributors.Add(new AntDesignTimeZonePageContributor());
        });
    }
}

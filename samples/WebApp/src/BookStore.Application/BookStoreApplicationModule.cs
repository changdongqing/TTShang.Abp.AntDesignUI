using Volo.Abp.PermissionManagement;
using Volo.Abp.SettingManagement;
using Volo.Abp.Account;
using Volo.Abp.Identity;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Mapperly;
using Volo.Abp.Modularity;
using Volo.Abp.TenantManagement;
using Microsoft.Extensions.DependencyInjection;

namespace BookStore;

[DependsOn(
    typeof(BookStoreDomainModule),
    typeof(BookStoreApplicationContractsModule),
    typeof(AbpPermissionManagementApplicationModule),
    typeof(AbpFeatureManagementApplicationModule),
    typeof(AbpIdentityApplicationModule),
    typeof(AbpAccountApplicationModule),
    typeof(AbpTenantManagementApplicationModule),
    typeof(AbpSettingManagementApplicationModule),
    typeof(AbpMapperlyModule)
    )]
public class BookStoreApplicationModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        context.Services.AddMapperlyObjectMapper<BookStoreApplicationModule>();
    }
}

using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloLibrary.Authorization;

namespace HelloLibrary
{
    [DependsOn(
        typeof(HelloLibraryCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class HelloLibraryApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<HelloLibraryAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(HelloLibraryApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

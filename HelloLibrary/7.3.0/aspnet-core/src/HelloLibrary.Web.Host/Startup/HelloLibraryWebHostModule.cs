using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloLibrary.Configuration;

namespace HelloLibrary.Web.Host.Startup
{
    [DependsOn(
       typeof(HelloLibraryWebCoreModule))]
    public class HelloLibraryWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public HelloLibraryWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HelloLibraryWebHostModule).GetAssembly());
        }
    }
}

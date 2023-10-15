using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using HelloLibrary.EntityFrameworkCore;
using HelloLibrary.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace HelloLibrary.Web.Tests
{
    [DependsOn(
        typeof(HelloLibraryWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class HelloLibraryWebTestModule : AbpModule
    {
        public HelloLibraryWebTestModule(HelloLibraryEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(HelloLibraryWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(HelloLibraryWebMvcModule).Assembly);
        }
    }
}
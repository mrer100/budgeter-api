using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using coresolution.EntityFrameworkCore;
using coresolution.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace coresolution.Web.Tests
{
    [DependsOn(
        typeof(coresolutionWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class coresolutionWebTestModule : AbpModule
    {
        public coresolutionWebTestModule(coresolutionEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coresolutionWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(coresolutionWebMvcModule).Assembly);
        }
    }
}
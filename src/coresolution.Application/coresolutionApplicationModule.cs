using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using coresolution.Authorization;

namespace coresolution
{
    [DependsOn(
        typeof(coresolutionCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class coresolutionApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<coresolutionAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(coresolutionApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}

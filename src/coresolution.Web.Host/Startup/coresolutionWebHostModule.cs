using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using coresolution.Configuration;

namespace coresolution.Web.Host.Startup
{
    [DependsOn(
       typeof(coresolutionWebCoreModule))]
    public class coresolutionWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public coresolutionWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(coresolutionWebHostModule).GetAssembly());
        }
    }
}

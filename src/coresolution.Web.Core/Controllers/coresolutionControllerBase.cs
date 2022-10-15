using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace coresolution.Controllers
{
    public abstract class coresolutionControllerBase: AbpController
    {
        protected coresolutionControllerBase()
        {
            LocalizationSourceName = coresolutionConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

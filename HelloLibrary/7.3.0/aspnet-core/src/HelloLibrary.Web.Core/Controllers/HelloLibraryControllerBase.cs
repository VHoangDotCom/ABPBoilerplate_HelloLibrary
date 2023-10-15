using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace HelloLibrary.Controllers
{
    public abstract class HelloLibraryControllerBase: AbpController
    {
        protected HelloLibraryControllerBase()
        {
            LocalizationSourceName = HelloLibraryConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}

using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using HelloLibrary.Configuration.Dto;

namespace HelloLibrary.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : HelloLibraryAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}

using System.Threading.Tasks;
using HelloLibrary.Configuration.Dto;

namespace HelloLibrary.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

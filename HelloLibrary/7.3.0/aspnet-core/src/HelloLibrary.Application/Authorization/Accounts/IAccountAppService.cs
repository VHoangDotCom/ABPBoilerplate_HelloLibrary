using System.Threading.Tasks;
using Abp.Application.Services;
using HelloLibrary.Authorization.Accounts.Dto;

namespace HelloLibrary.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}

using System.Threading.Tasks;
using Abp.Application.Services;
using HelloLibrary.Sessions.Dto;

namespace HelloLibrary.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

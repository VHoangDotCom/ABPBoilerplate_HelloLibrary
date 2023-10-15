using Abp.Application.Services;
using HelloLibrary.MultiTenancy.Dto;

namespace HelloLibrary.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


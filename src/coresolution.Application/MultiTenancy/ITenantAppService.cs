using Abp.Application.Services;
using coresolution.MultiTenancy.Dto;

namespace coresolution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}


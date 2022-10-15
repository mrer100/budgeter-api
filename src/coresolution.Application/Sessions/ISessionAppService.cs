using System.Threading.Tasks;
using Abp.Application.Services;
using coresolution.Sessions.Dto;

namespace coresolution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}

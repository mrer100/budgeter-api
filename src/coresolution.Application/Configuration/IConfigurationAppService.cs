using System.Threading.Tasks;
using coresolution.Configuration.Dto;

namespace coresolution.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}

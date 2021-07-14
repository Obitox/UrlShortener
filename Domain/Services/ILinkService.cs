using System.Threading.Tasks;
using Domain.ApiModel;

namespace Domain.Services
{
    public interface ILinkService
    {
        Task<bool> Save(long userId, SaveRequest model);
    }
}
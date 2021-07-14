using System.Threading.Tasks;
using Domain.ApiModel;

namespace Domain.Services
{
    public interface IUserService
    {
        Task<bool> Authenticate(AuthenticationRequest model);
    }
}
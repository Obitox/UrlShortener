using System.Threading.Tasks;
using Domain.Model;

namespace Domain.Repository
{
    public interface IUserRepository
    {
        Task<User> GetUserByUsername(string username);
    }
}
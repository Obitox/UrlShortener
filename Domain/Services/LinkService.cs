using System.Threading.Tasks;
using Domain.ApiModel;

namespace Domain.Services
{
    public class LinkService : ILinkService
    {
        public Task<bool> Save(long userId, SaveRequest model)
        {
            throw new System.NotImplementedException();
        }
    }
}
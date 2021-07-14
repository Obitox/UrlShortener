using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.ApiModel;

namespace Domain.Repository
{
    public interface ILinkRepository
    {
        Task<bool> SaveLinksWithUserId(long userId, List<Link> links);
    }
}
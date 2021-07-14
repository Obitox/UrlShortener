using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.ApiModel;
using Domain.Repository;

namespace DAL.MySQL.Repository
{
    public class LinkRepository : ILinkRepository
    {
        public Task<bool> SaveLinksWithUserId(long userId, List<Link> links)
        {
            throw new System.NotImplementedException();
        }
    }
}
using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer2.Model;

namespace FriendOrganizer2.UI.Data
{
    public interface IFriendLookUpDataService
    {
        Task<IEnumerable<LookUpItem>> GetFriendLookUpAsync();
    }
}
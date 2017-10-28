using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer2.DataAccess;
using FriendOrganizer2.Model;

namespace FriendOrganizer2.UI.Data
{
    public class LookUpDataService : IFriendLookUpDataService
    {
        private Func<FriendOrganizerDbContext> _contextCreator;

        public LookUpDataService(Func<FriendOrganizerDbContext> contextCreator)
        {
            _contextCreator = contextCreator;

        }

        public async Task<IEnumerable<LookUpItem>> GetFriendLookUpAsync()
        {
            using (var ctx = _contextCreator())
            {
                return await ctx.Friends.AsNoTracking().Select(f => new LookUpItem
                {
                    Id = f.Id,
                    DisplayMember = f.FirstName + " " + f.LastName
                }).ToListAsync();
            }
        }
    }
}

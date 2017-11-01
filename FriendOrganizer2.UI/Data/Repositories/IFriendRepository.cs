﻿using System.Collections.Generic;
using System.Threading.Tasks;
using FriendOrganizer2.Model;

namespace FriendOrganizer2.UI.Data.Repositories
{
    public interface IFriendRepository
    { 
        Task<Friend> GetBYIdAsync(int friendId);
        Task SaveAsync();
        bool HasChanges();
    }
}
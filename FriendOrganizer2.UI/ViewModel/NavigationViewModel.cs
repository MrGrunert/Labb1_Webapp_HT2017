using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FriendOrganizer2.Model;
using FriendOrganizer2.UI.Data;

namespace FriendOrganizer2.UI.ViewModel
{
     public class NavigationViewModel : INavigationViewModel
    {
        private IFriendLookUpDataService _friendLookUpService;
        public ObservableCollection<LookUpItem> Friends { get; }


        public NavigationViewModel(IFriendLookUpDataService friendLookUpService)
        {
            _friendLookUpService = friendLookUpService;
           Friends = new ObservableCollection<LookUpItem>(); 
        }

        public async Task LoadAsync()
        {
            var lookUp = await _friendLookUpService.GetFriendLookUpAsync();
            Friends.Clear();
            foreach (var item in lookUp)
            {
                Friends.Add(item);
            }
        }
    }
}

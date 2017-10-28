using System.Collections.ObjectModel;
using System.Threading.Tasks;
using FriendOrganizer2.Model;
using FriendOrganizer2.UI.Data;

namespace FriendOrganizer2.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private INavigationViewModel NavigationViewModel { get; }
        //Used before decoupling in Bootsrtapper...
        //private Friend _selectedFriend;
        //private IFriendDataService _friendDataService;

        //Used before decopling in Bootstrapper...
        //public ObservableCollection<Friend> Friends { get; set; }

        //public Friend SelectedFriend
        //{
        //    get { return _selectedFriend; }
        //    set
        //    {
        //        _selectedFriend = value;
        //        OnPropertyChanged();
        //    }

        //}

        public MainViewModel(INavigationViewModel navigationViewModel)
        {
            NavigationViewModel = navigationViewModel;
        }

        //Old constructor used befor decoulping in Bootstrapper...
        //public MainViewModel(IFriendDataService friendDataService)
        //{
        //    Friends = new ObservableCollection<Friend>();
        //    _friendDataService = friendDataService;
        //}

        public async Task LoadAsync()
        {
            await NavigationViewModel.LoadAsync();

            //Used before decoupling in Bootstrapper
            //var friends = await _friendDataService.GetallAsync();
            //Friends.Clear();
            //foreach (var friend in friends)
            //{
            //    Friends.Add(friend);
            //}
        }
    }
}

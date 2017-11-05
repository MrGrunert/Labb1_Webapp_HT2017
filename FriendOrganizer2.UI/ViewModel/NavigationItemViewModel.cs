﻿

using System.Windows.Input;
using FriendOrganizer2.UI.Event;
using Prism.Commands;
using Prism.Events;

namespace FriendOrganizer2.UI.ViewModel 
{
    public class NavigationItemViewModel :ViewModelBase
    {
        private string _displayMember;
        private IEventAggregator _eventAggregator;
        private string _detailViewModelName;
        public int Id { get; }

        public string DisplayMember
        {
            get
            {
                return _displayMember;
            }
            set
            {
                _displayMember = value;
                OnPropertyChanged();
            }
        }

        public ICommand OpenDetailViewCommand { get; }



        public NavigationItemViewModel(int id, string displayMember, 
            string detailViewModelName, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            Id = id;
            DisplayMember = displayMember;
            _detailViewModelName = detailViewModelName;
            OpenDetailViewCommand = new DelegateCommand(OnOpenDetailViewExecute);
        }

        private void OnOpenDetailViewExecute()
        {
            _eventAggregator.GetEvent<OpenDetailViewEvent>()
                .Publish(new OpenDetailViewEventArgs
                {
                    Id = Id,
                    ViewModelName = _detailViewModelName
                });
        }
    }
}

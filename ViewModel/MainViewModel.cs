using GongSolutions.Wpf.DragDrop;
using HowrseBot.Client;
using HowrseBot.DataModel;
using JetBrains.Annotations;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;

namespace HowrseBot.ViewModel
{
    public class MainViewModel : INotifyPropertyChanged, IDropTarget 
	{
		private DataCollection _data;
        private UserCollection _user;
        public ObservableCollection<User> _userList { get; set; } = new ObservableCollection<User>();

        public MainViewModel()
		{
            Data = new DataCollection();
            User = new UserCollection();
            _userList = LocalData.Instance.Load< ObservableCollection<User>>();
            
            if(_userList.Count == 0)
            {
                _userList.Add(new User("a", "b"));
                SaveSession();
            }
            else
            {
                this.User.Load(_userList[0]);
            }
        }

        private void saveSession()
        {
            int index = -1;
            foreach(User user in _userList)
            {
                if(user.Name == User.Name)
                {
                    index = _userList.IndexOf(user);
                }
            }
            if(index != -1)
            {

            }
            else
            {
                User user = new User(User);
            }
            LocalData.Instance.Save(_userList);
        }

        public DataCollection Data
		{
			get { return _data; }
			set
			{
				if (Equals(value, _data)) return;
				_data = value;
				OnPropertyChanged();
			}
		}
        public UserCollection User
        {
            get { return _user; }
            set
            {
                if (Equals(value, _user)) return;
                _user = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

		//Handle Hovering Items
		public void DragOver(IDropInfo dropInfo)
		{
			Item sourceItem = dropInfo.Data as Item;
			string target = (dropInfo.VisualTarget as FrameworkElement).Name;
			string source = (dropInfo.DragInfo.VisualSource as FrameworkElement).Name;

			if (target == "CommandBin")
			{
				dropInfo.Effects = DragDropEffects.Move;
			}
			else if (target == "CommandPanel" && source == "CommandSource")
			{
				dropInfo.DropTargetAdorner = DropTargetAdorners.Insert;
				dropInfo.Effects = DragDropEffects.Copy;
			}
			else if (target == "CommandPanel" && source == "CommandPanel")
			{
				dropInfo.DropTargetAdorner = DropTargetAdorners.Insert;
				dropInfo.Effects = DragDropEffects.Move;
			}
		}

		//Handle Dropping Items
		public void Drop(IDropInfo dropInfo)
		{
			List<Item> sourceItems = dropInfo.Data as List<Item>;
			if(sourceItems == null)
			{
				sourceItems = new List<Item>();
				sourceItems.Add(dropInfo.Data as Item);
			}
			string target = (dropInfo.VisualTarget as FrameworkElement).Name;
			string source = (dropInfo.DragInfo.VisualSource as FrameworkElement).Name;

			//Handling different Locations
			if(source == "CommandPanel" && target == "CommandBin")
			{
				foreach (Item _item in sourceItems)
				{
					(dropInfo.DragInfo.SourceCollection as ObservableCollection<Item>).Remove(_item);
				}
			}
			else if(source == "CommandSource" && target == "CommandPanel")
			{
				int newIndex = dropInfo.InsertIndex;
				if (newIndex == (dropInfo.TargetCollection as ObservableCollection<Item>).Count)
				{
					newIndex -= 1;
				}
				foreach (Item _item in sourceItems)
				{
					(dropInfo.TargetCollection as ObservableCollection<Item>).Insert(newIndex, _item);
				}
			}
			else if (source == "CommandPanel" && target == "CommandPanel")
			{
				int newIndex = dropInfo.InsertIndex;
				if(newIndex == (dropInfo.TargetCollection as ObservableCollection<Item>).Count)
				{
					newIndex -= 1;
				}
				foreach (Item _item in sourceItems)
				{
					int oldIndex = (dropInfo.TargetCollection as ObservableCollection<Item>).IndexOf(_item);
					(dropInfo.TargetCollection as ObservableCollection<Item>).Move(oldIndex, newIndex);
				}
				
			}
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

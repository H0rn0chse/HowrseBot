using HowrseBot.Bot;
using JetBrains.Annotations;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace HowrseBot.DataModel
{
    public class UserCollection : INotifyPropertyChanged
    {
        public ObservableCollection<BotProgram> BotProgramList { get; set; }

        private int _duration;
        private string _name;
        private string _password;
        private int _sort;
        private int _tarif;
        private bool _ufo;

        public UserCollection()
        {
            this.Name = "unknown";
            this.Duration = 1;
            this.Sort = 1;
            this.Tarif = 8;
            this.Ufo = true;

            this.BotProgramList = new ObservableCollection<BotProgram>();
        }

        public void Load(User user)
        {
            this.Duration = user.duration;
            this.Name = user.name;
            this.Password = user.password;
            this.Sort = user.sort;
            this.Tarif = user.tarif;
            this.Ufo = user.ufo;

            this.BotProgramList.Clear();
            foreach(BotProgram bp in user.BotProgramList)
            {
                this.BotProgramList.Add(bp);
            }
        }

        public int Duration
        {
            get { return _duration; }
            set
            {
                if (Equals(value, _duration)) return;
                _duration = value;
                OnPropertyChanged();
            }
        }
        public string Name
        {
            get { return _name; }
            set
            {
                if (Equals(value, _name)) return;
                _name = value;
                OnPropertyChanged();
            }
        }
        public string Password
        {
            get { return _password; }
            set
            {
                if (Equals(value, _password)) return;
                _password = value;
                OnPropertyChanged();
            }
        }
        public int Sort
        {
            get { return _sort; }
            set
            {
                if (Equals(value, _sort)) return;
                _sort = value;
                OnPropertyChanged();
            }
        }
        public int Tarif
        {
            get { return _tarif; }
            set
            {
                if (Equals(value, _tarif)) return;
                _tarif = value;
                OnPropertyChanged();
            }
        }
        public bool Ufo
        {
            get { return _ufo; }
            set
            {
                if (Equals(value, _ufo)) return;
                _ufo = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
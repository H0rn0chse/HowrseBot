using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.Bot
{
	public class BotProgram : INotifyPropertyChanged
    {
        private List<int> _commandList;
        private string _name;

        public BotProgram()
        {
            Name = "";

        }

        public BotProgram(string name, List<int> list) : this()
        {
            Name = name;
            CommandList = list;
        }

        public List<int>  CommandList
        {
            get { return _commandList; }
            set
            {
                if (Equals(value, _commandList)) return;
                _commandList = value;
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

        public override string ToString()
        {
            return this.Name;
        }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}

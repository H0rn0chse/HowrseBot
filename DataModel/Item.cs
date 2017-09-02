using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.DataModel
{
	public class Item : INotifyPropertyChanged
	{
		public Item()
		{
		}

		public Item(int itemIndex) : this()
        {
			this.Caption = $"Item {itemIndex}";
            this.Value = itemIndex;
            this.Text = "";
		}
        public Item(string text) : this()
        {
            this.Caption = text;
            this.Value = 0;
            this.Text = text;
        }
        public Item(int itemIndex, string text) : this()
        {
            this.Caption = $"Item {itemIndex}";
            this.Value = itemIndex;
            this.Text = text;
        }

        public string Caption { get; set; }
        public int Value { get; set; }
        public string Text { get; set; }

        public override string ToString()
		{
			return this.Caption;
		}

		public event PropertyChangedEventHandler PropertyChanged;

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
	}
}

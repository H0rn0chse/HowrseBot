using HowrseBot.Bot;
using HowrseBot.DataModel;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.DataModel
{
	public class DataCollection
	{
        public ObservableCollection<Item> CommandPool { get; set; } = new ObservableCollection<Item>();
        public ObservableCollection<Item> Duration { get; set; } = new ObservableCollection<Item>();
        public ObservableCollection<Item> Sort { get; set; } = new ObservableCollection<Item>();
        public ObservableCollection<Item> Tarif { get; set; } = new ObservableCollection<Item>();
        public ObservableCollection<Item> EditorProgramm { get; set; } = new ObservableCollection<Item>();
        
        public DataCollection()
		{
            CommandPool = StaticData.Instance.GetItemList("CommandPool");
            Duration = StaticData.Instance.GetItemList("Duration");
            Sort = StaticData.Instance.GetItemList("Sort");
            Tarif = StaticData.Instance.GetItemList("Tarif");
		}
	}
}
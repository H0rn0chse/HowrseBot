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

        public ObservableCollection<BotProgram> ProgramList = new ObservableCollection<BotProgram>();
        public ObservableCollection<Item> Prog1 { get; set; } = new ObservableCollection<Item>();
		public ObservableCollection<Test> Test { get; set; } = new ObservableCollection<Test>();
        
        
        /*
        public static List<Tarif> TarifList;
        public static List<Duration> DurationList;
        public static List<Sort> SortList;
        public static List<string> AcceptedUserNames;
        public static List<UriNamePair> UriList;
        */
        public DataCollection()
		{
            CommandPool = StaticData.Instance.GetItemList("CommandPool");
            Duration = StaticData.Instance.GetItemList("Duration");
            Sort = StaticData.Instance.GetItemList("Sort");
            Tarif = StaticData.Instance.GetItemList("Tarif");


            for (int i=1; i < 6; i++)
			{
				Item _item = new Item(i);
				Prog1.Add(_item);
				Test _test = new Test(i);
				Test.Add(_test);
			}

		}

	}

}

public class Test : INotifyPropertyChanged
{
	public Test()
	{
	}

	public Test(int itemIndex) : this()
    {
		this.Breed = $"Zucht {itemIndex}";
		this.Program = $"Programm {itemIndex}";
		this.Progress = itemIndex*16;
	}

	public string Breed { get; set; }
	public string Program { get; set; }
	public int Progress { get; set; }

	public event PropertyChangedEventHandler PropertyChanged;

	[NotifyPropertyChangedInvocator]
	protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
	{
		PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
	}
}
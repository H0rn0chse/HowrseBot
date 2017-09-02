using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.ViewModel
{
	public abstract class ListViewModelBase : ViewModelBase
	{
		public abstract string Name { get; }
	}
}

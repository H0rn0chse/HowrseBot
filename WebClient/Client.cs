using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HowrseBot.WebClient
{
	public sealed class Client : BaseClient
	{
		private static readonly Client instance = new Client();

		private Client() { }

		public static Client Instance
		{
			get
			{
				return instance;
			}
		}
	}
}

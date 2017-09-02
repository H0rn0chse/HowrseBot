using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowrseBot.Bot
{
	public sealed class BotClient
	{
		//Multithreaded Singleton
		//https://msdn.microsoft.com/en-us/library/ff650316.aspx

		private static volatile BotClient instance;
		private static object syncRoot = new Object();

		private BotClient() { }

		int p;

		public static BotClient Instance
		{
			get
			{
				if (instance == null)
				{
					lock (syncRoot)
					{
						if (instance == null)
							instance = new BotClient();
					}
				}

				return instance;
			}
		}

		public void Start(CancellationToken token)
		{
			p = 0;
			while (true)
			{
				MessageBox.Show("Hello World No" + p);
				p += 1;
				if (token.IsCancellationRequested)
				{
					break;
				}
			}
		}

		public void Incr()
		{
			p += 100;
		}
	}
}

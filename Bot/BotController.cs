using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HowrseBot.Bot
{

	public sealed class BotController
	{
		private static volatile BotController instance;
		private static object syncRoot = new Object();

		Task _BotTask;
		CancellationToken token;
		CancellationTokenSource tokenSource;

		private BotController()
		{
			tokenSource = new CancellationTokenSource();
			token = tokenSource.Token;

			_BotTask = Task.Factory.StartNew(() =>BotClient.Instance.Start(token));
		}

		

		public static BotController Instance
		{
			get
			{
				if (instance == null)
				{
					lock (syncRoot)
					{
						if (instance == null)
							instance = new BotController();
					}
				}

				return instance;
			}
		}

		public void Start()
		{
			//_BotTask.Start();
		}

		public void Stop()
		{
			MessageBox.Show("Controller und bot werden beendet");
			tokenSource.Cancel();
			_BotTask.Wait();
			tokenSource.Dispose();
			return;
		}
	}

}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HowrseBot.Bot;

namespace HowrseBot
{


	/// <summary>
	/// Interaction logic for StartUp.xaml
	/// </summary>
	public partial class StartUp : Window
	{
		public MainWindow _MainWindow;
		public LoginWindow _LoginWindow;

		bool closingAll = false;

		public StartUp()
		{
			InitializeComponent();
			this.Hide();

			_MainWindow = new MainWindow(this);
			_LoginWindow = new LoginWindow(this);

			BotController.Instance.Start();
			_LoginWindow.Show();
		}

		public void CloseAll()
		{
			if (!closingAll)
			{
				closingAll = true;
				BotController.Instance.Stop();
				if (_MainWindow.IsLoaded)
				{
					_MainWindow.Close();
				}

				if (_LoginWindow.IsLoaded)
				{
					_LoginWindow.Close();
				}

				this.Close();
				System.Windows.Application.Current.Shutdown();
			}
		}
	}
}

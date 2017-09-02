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
using System.Threading;

namespace HowrseBot
{
	/// <summary>
	/// Interaction logic for LoginWindow.xaml
	/// </summary>
	public partial class LoginWindow : Window
	{
        private App Context;

		public LoginWindow(App context)
		{
			InitializeComponent();
            Context = context;
        }

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			this.Hide();
			BotClient.Instance.Incr();
			context._MainWindow.Show();
		}

		private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
		{
			
		}

		private void Window_Closed(object sender, EventArgs e)
		{
			context.CloseAll();
		}
	}
}

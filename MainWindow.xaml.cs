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
using System.Windows.Navigation;
using System.Windows.Shapes;
using HowrseBot.ViewModel;
using HowrseBot.Bot;

namespace HowrseBot
{
	/// <summary>
	/// Interaktionslogik für MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private StartUp context;

		public MainWindow(StartUp c)
		{
			InitializeComponent();
			context = c;
			this.DataContext = new MainViewModel();
			//this.Hide();
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

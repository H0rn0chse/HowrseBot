using System;
using System.Windows;

namespace HowrseBot
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
	{
        private App Context;

		public MainWindow(App context)
		{
			InitializeComponent();
            Context = context;
		}

        private void Window_Closed(object sender, EventArgs e)
        {
            Context.CloseAll();
        }
    }
}

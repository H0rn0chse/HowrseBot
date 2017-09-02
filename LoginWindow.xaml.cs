using System;
using System.Windows;

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

        private void Window_Closed(object sender, EventArgs e)
        {
            Context.CloseAll();
        }

}

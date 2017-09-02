using HowrseBot.Bot;
using HowrseBot.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace HowrseBot
{
    /// <summary>
    /// Interaktionslogik für "App.xaml"
    /// </summary>
    public partial class App : Application
    {
        public MainWindow mainWindow;
        public LoginWindow loginWindow;
        public MainViewModel mainViewModel;

        bool closingAll;

        private void Application_StartUp(object sender, StartupEventArgs e)
        {
            BotController.Instance.Start();

            mainViewModel = new MainViewModel();
            mainWindow = new MainWindow(this);
            loginWindow = new LoginWindow(this);

            mainWindow.DataContext = mainViewModel;
            loginWindow.DataContext = mainViewModel;

            closingAll = false;

            loginWindow.Show();
        }

        public void CloseAll()
        {
            if (!closingAll)
            {
                closingAll = true;
                BotController.Instance.Stop();
                if (mainWindow.IsLoaded)
                {
                    mainWindow.Close();
                }

                if (loginWindow.IsLoaded)
                {
                    loginWindow.Close();
                }

                this.Shutdown();
                System.Windows.Application.Current.Shutdown();
            }
        }

	}
}

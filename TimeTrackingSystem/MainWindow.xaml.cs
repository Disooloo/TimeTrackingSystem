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
using System.Windows.Threading;
using TimeTrackingSystem.Assets.Helpers;
using TimeTrackingSystem.Assets.View.Pages;

namespace TimeTrackingSystem
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer timer;
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new UserHomePage());
            Manager.MainFrame = MainFrame;
            StartClock();
        }

        private void StartClock()
        {
            timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            CurrentTimeTextBlock.Text = DateTime.Now.ToString("HH:mm:ss");
            CurrentDateTextBlock.Text = DateTime.Now.ToString("dd.MM.yyyy");
        }

        private void productionByUser_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Manager.MainFrame.Navigate(new ProductionByUserPage());
        }
    }
}

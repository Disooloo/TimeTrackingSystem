using System;
using System.Linq;
using System.Windows;

namespace TimeTrackingSystem.Assets.View.Windows
{
    public partial class LoginWindows : Window
    {
        public LoginWindows()
        {
            InitializeComponent();
        }

        private void EnterLogin_Click(object sender, RoutedEventArgs e)
        {
            string login = loginTextBlock.Text; // Получаем логин из TextBox
            string password = passwordBoxUser.Password; // Получаем пароль из PasswordBox

            MessageBox.Show(login, password + "\nВы вошли");

            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void CompanyRegistration_MouseDown(object sender, RoutedEventArgs e)
        {
            // Действия при нажатии на текст "Регистрация компании"
            // Здесь можно реализовать логику регистрации новой компании
        }
    }
}

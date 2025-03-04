using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Animedia
{
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                OnLoginClick(sender, e);
        }

        private void OnLoginClick(object sender, RoutedEventArgs e)
        {

        }
        private void OnForgotClick(object sender, RoutedEventArgs e)
        {
            WindowsHelper.forgotWindow.Show();
            this.Hide();
        }
        private void OnRegistrationClick(object sender, RoutedEventArgs e)
        {
            WindowsHelper.registrationWindow.Show();
            this.Hide();
        }
        private void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        //Метод перетаскивания окна при помощи мышки
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }
        private void LoginPasswordPb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Регулярное выражение для проверки русских букв
            Regex regex = new Regex("[а-яА-Я]");
            // Если введенный символ является русской буквой, блокируем ввод
            if (regex.IsMatch(e.Text))
                e.Handled |= true; // Блокируем ввод
        }
        private void LoginUsernameTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Регулярное выражение для проверки русских букв
            Regex regex = new Regex("[а-яА-Я]");
            // Если введенный символ является русской буквой, блокируем ввод
            if (regex.IsMatch(e.Text))
                e.Handled |= true; // Блокируем ввод
        }
    }
}

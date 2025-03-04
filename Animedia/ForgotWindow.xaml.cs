using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    public partial class ForgotWindow : Window
    {
        public bool isDigitForgot;
        public ForgotWindow()
        {
            InitializeComponent();
        }
        private void OnBackClick(object sender, RoutedEventArgs e)
        {
            WindowsHelper.authorizationWindow.Show();
            this.Hide();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                OnForgotClick(sender, e);
        }
        private void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }
        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }


        private void OnForgotClick(object sender, RoutedEventArgs e)
        {

        }
        //Метод перетаскивания окна при помощи мышки
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void ForgotTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Устанавливаем фокус на TextBox для ввода номера телефона
            ForgotTb.Focus();
            // Устанавливаем курсор в конец текста, чтобы пользователь мог продолжить ввод
            ForgotTb.CaretIndex = ForgotTb.Text.Length;
            // Блокируем стандартное поведение клика, чтобы предотвратить выделение текста
            e.Handled = true;
        }

        private void ForgotTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой, если символ не цифра, блокируем его ввод
            if (char.IsDigit(e.Text[0]) && string.IsNullOrEmpty(ForgotTb.Text))
                isDigitForgot = true;
            // Регулярное выражение для проверки русских букв
            Regex regex = new Regex("[а-яА-Я]");
            // Если введенный символ является русской буквой, блокируем ввод
            if (regex.IsMatch(e.Text))
                e.Handled |= true; // Блокируем ввод
        }

        private void ForgotTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (isDigitForgot)
            {
                // Убираем все нецифровые символы из текста
                string text = new string(ForgotTb.Text.Where(char.IsDigit).ToArray());

                // Если текст пуст, очищаем TextBox и выходим
                if (string.IsNullOrEmpty(text))
                {
                    ForgotTb.Text = string.Empty;
                    return;
                }

                // Ограничиваем длину номера 11 цифрами (первая цифра "7" и 10 остальных)
                if (text.Length > 11)
                    text = text.Substring(0, 11);

                // Создаем StringBuilder для форматирования номера телефона
                StringBuilder result = new StringBuilder("+7 ");

                // Форматируем номер телефона, добавляя скобки и дефисы
                for (int i = 1; i < text.Length; i++)
                {
                    if (i == 1) result.Append("("); // Добавляем открывающую скобку после первой цифры
                    if (i == 4) result.Append(") "); // Добавляем закрывающую скобку и пробел после четвертой цифры
                    if (i == 7 || i == 9) result.Append("-"); // Добавляем дефисы после седьмой и девятой цифр
                    result.Append(text[i]); // Добавляем текущую цифру
                }

                // Устанавливаем отформатированный текст в TextBox
                ForgotTb.Text = result.ToString();

                // Устанавливаем курсор в конец текста, чтобы пользователь мог продолжить ввод
                ForgotTb.CaretIndex = ForgotTb.Text.Length;
            }
        }
        private void ForgotTb_PreviewKeyDown(object sender, KeyEventArgs e)
        {
            // Если текст пуст, очищаем TextBox и выходим
            if (ForgotTb.Text.Length <= 3 && e.Key==Key.Back && isDigitForgot)
            {
                ForgotTb.Text = string.Empty;
                e.Handled = true;
                isDigitForgot = false;
                return;
            }
        }
    }
}

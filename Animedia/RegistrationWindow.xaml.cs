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

namespace Animedia
{
    public partial class RegistrationWindow : Window
    {
        public RegistrationWindow()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                OnCreateAccountClick(sender, e);
        }
        private void OnCreateAccountClick(object sender, RoutedEventArgs e)
        {

        }
        private void OnLoginClick(object sender, RoutedEventArgs e)
        {
            WindowsHelper.authorizationWindow.Show();
            this.Hide();
        }
        private void OnCloseClick(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
        private void OnMinimizeClick(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        //Метод перетаскивания окна при помощи мышки
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DragMove();
        }

        private void PhoneNumberTextBox_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            // Устанавливаем фокус на TextBox для ввода номера телефона
            PhoneNumberTb.Focus();

            // Устанавливаем курсор в конец текста, чтобы пользователь мог продолжить ввод
            PhoneNumberTb.CaretIndex = PhoneNumberTb.Text.Length;

            // Блокируем стандартное поведение клика, чтобы предотвратить выделение текста
            e.Handled = true;
        }

        private void PhoneNumberTb_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            // Проверяем, является ли введенный символ цифрой
            // Если символ не цифра, блокируем его ввод
            e.Handled = !char.IsDigit(e.Text[0]);
        }

        private void PhoneNumberTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Убираем все нецифровые символы из текста
            string text = new string(PhoneNumberTb.Text.Where(char.IsDigit).ToArray());

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
            PhoneNumberTb.Text = result.ToString();

            // Устанавливаем курсор в конец текста, чтобы пользователь мог продолжить ввод
            PhoneNumberTb.CaretIndex = PhoneNumberTb.Text.Length;
        }

        // Устанавливаем курсор в начало ввода (на первую цифру после "+7 (")
        private void BirthDate_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            BirthDateDp.SelectedDate = null;
        }
    }
}

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

namespace Animedia
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
                login_btn_Click(sender, e);
        }

        private void login_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void forgot_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void registration_btn_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Button_DpiChanged(object sender, DpiChangedEventArgs e)
        {

        }
    }
}

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

namespace PlaneSysWpfApp.User
{
    /// <summary>
    /// UserWindow.xaml 的交互逻辑
    /// </summary>
    public partial class UserWindow : Window
    {
        public string userName;
        public UserWindow(string username)
        {
            InitializeComponent();
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            this.textUser.Text = username;
            userName = username;
            this.textTime.Text = DateTime.Now.ToLocalTime().ToString().Substring(0, 9);
        }

        private void Pg1_Click(object sender, RoutedEventArgs e)
        {
            this.frame1.Navigate(new Uri("User/UserPage1.xaml", UriKind.Relative));
        }

        private void Pg2_Click(object sender, RoutedEventArgs e)
        {
            Uri uri = new Uri("User/UserPage2.xaml", UriKind.Relative);
            UserPage2 pg2 = new UserPage2(userName);
            //this.frame1.Navigate(uri);
            this.frame1.Content = pg2;
        }

        private void Pg3_Click(object sender, RoutedEventArgs e)
        {
            this.frame1.Navigate(new Uri("User/UserPage3.xaml", UriKind.Relative));
        }
    }
}

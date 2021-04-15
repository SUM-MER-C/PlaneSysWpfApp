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

namespace PlaneSysWpfApp.Manager
{
    /// <summary>
    /// ManagerWindow.xaml 的交互逻辑
    /// </summary>
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            this.textTime.Text = DateTime.Now.ToLocalTime().ToString().Substring(0, 9);
            this.textUser.Text = "管理员";
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            this.frame1.Navigate(new Uri("Manager/AddLinePage.xaml", UriKind.Relative));
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            this.frame1.Navigate(new Uri("Manager/EditLinePage.xaml", UriKind.Relative));
        }
    }
}

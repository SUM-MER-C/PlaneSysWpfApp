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

namespace PlaneSysWpfApp.SignIn
{
    /// <summary>
    /// SignInWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SignInWindow : Window
    {
        public SignInWindow()
        {
            InitializeComponent();
            this.textTime.Text = DateTime.Now.ToLocalTime().ToString().Substring(0, 9);
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Sign2_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Sign1_Click(object sender, RoutedEventArgs e)
        {
            List<User.User> u = new List<User.User>();
            //u = Manager.TextUtil.LoadUser();
            string inputName = userNameTextBox.Text;
            string inputId = userIdTextBox.Text;
            string inputPd = userPdTextBox.Text;
            int flag = 0;
            for(int i= 0; i < u.ToArray().Length; i++)
            {
                if (inputId.Equals(u[i].getUserId()))
                {
                    MessageBox.Show("用户ID已存在！");
                    flag = 1;
                    break;
                }
            }
            if(flag == 0)
            {
                User.User uu = new User.User(inputName, inputId, 0, inputPd);
                u.Add(uu);
                Manager.TextUtil.writeUser(u);
                MessageBox.Show("用户注册成功！");
                this.Close();
            }
        }
    }
}

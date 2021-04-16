using PlaneSysWpfApp.SignIn;
using System;
using System.Collections.Generic;
using System.Windows;


namespace PlaneSysWpfApp
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            textTime.Text = DateTime.Now.ToLocalTime().ToString().Substring(0, 9);
            this.WindowStartupLocation = WindowStartupLocation.CenterScreen;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void SignIn_Click(object sender, RoutedEventArgs e)
        {
            SignInWindow signWin = new SignInWindow();
            signWin.Show();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            int flag = 0;
            string inputId = idTextBox.Text;
            string inputPd = pass.Password.ToString();

            List<User.User> users = new List<User.User>();
            users = Manager.TextUtil.LoadUser();

            // 管理员身份
            if(inputId.Equals("admin") && inputPd.Equals("123456"))
            {
                MessageBox.Show("管理员登陆成功！");
                flag = 1;
                Manager.ManagerWindow mgWin = new Manager.ManagerWindow();
                mgWin.Show();
            }

            //验证用户身份
            for(int i=0; i < users.ToArray().Length; i++)
            {
                if (inputId.Equals(users[i].getUserId()))
                {
                    if (inputPd.Equals(users[i].getPwd()))
                    {
                        MessageBox.Show("用户登陆成功！");
                        flag = 1;
                        User.UserWindow uw = new User.UserWindow(users[i].getUserName());
                        uw.Show();
                    }
                }
            }

            // 两者都不是
            if (flag == 0)
            {
                MessageBox.Show("账号或密码错误！");
            }
        }
    }
}

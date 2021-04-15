using PlaneSysWpfApp.Manager;
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

namespace PlaneSysWpfApp.User
{
    /// <summary>
    /// UserPage3.xaml 的交互逻辑
    /// </summary>
    public partial class UserPage3 : Page
    {
        public UserPage3()
        {
            InitializeComponent();
        }

        private void FreshBtn_Click(object sender, RoutedEventArgs e)
        {
            var window = (UserWindow)Window.GetWindow(this);
            List<User> ulist = new List<User>();
            ulist = TextUtil.LoadUser();
            string uName = window.userName;
            User uer = new User();
            foreach (var u in ulist)
            {
                if (uName.Equals(u.getUserName()))
                {
                    uer = u;
                }
            }
            textId.Content = uer.getUserId();
            textName.Text = uer.getUserName();
            textNum.Text = uer.getNumTic().ToString();
            pdbox.Password = uer.getPwd();
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            List<User> users = new List<User>();
            List<User> newlist = new List<User>();
            users = TextUtil.LoadUser();
            string uid = textId.Content.ToString();
            string newpd = pdbox.Password.ToString();
            foreach(var i in users)
            {
                if (!uid.Equals(i.getUserId())) newlist.Add(i);
                else
                {
                    i.setPasswd(newpd);
                    newlist.Add(i);
                }
            }
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            var window = (UserWindow)Window.GetWindow(this);
            window.Close();
        }
    }
}

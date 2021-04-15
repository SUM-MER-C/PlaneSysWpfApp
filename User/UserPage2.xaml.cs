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
    /// UserPage2.xaml 的交互逻辑
    /// </summary>
    public partial class UserPage2 : Page
    {
        public string username;
        public string uid;
        public UserPage2(string str)
        {
            username = str;
            InitializeComponent();
            List<Order> orders = new List<Order>();
            List<Order> olist = new List<Order>();
            List<User> ulist = new List<User>();
            ulist = TextUtil.LoadUser();
            foreach (var u in ulist)
            {
                if (str.Equals(u.getUserName()))
                {
                    uid = u.getUserId();
                }
            }

            orders = TextUtil.LoadOrder();
            foreach (var o in orders)
            {
                if (uid.Equals(o.UserId)) olist.Add(o);
            }
            datagrid1.ItemsSource = orders;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var btnRow = (Order)datagrid1.SelectedItem;
            PlaneLine p = new PlaneLine();
            List<PlaneLine> linelist = new List<PlaneLine>();
            linelist = TextUtil.LoadLine();
            foreach(var line in linelist)
            {
                if(btnRow.PlaneId.Equals(line.planeId))
                {
                    p = line;
                }
            }

            textOrderId.Text = btnRow.OrderId;
            textCity1.Text = p.city1;
            textCity2.Text = p.city2;
            textTime1.Text = p.time1.ToString();
            textTime2.Text = p.time2.ToString();
            textPrice.Text = p.price.ToString();
        }

        private void BtnTicket_Click(object sender, RoutedEventArgs e)
        {
            string tOid = textOrderId.Text;
            List<Order> ilist = new List<Order>();
            ilist = TextUtil.LoadOrder();
            List<Order> ulist = new List<Order>();
            foreach(var i in ilist)
            {
                if (!tOid.Equals(i.OrderId))
                {
                    ulist.Add(i);
                }
            }
            TextUtil.writeDeleteOrder(ulist);
            MessageBox.Show("退票成功");
        }

        private void Btn2_Click(object sender, RoutedEventArgs e)
        {
            var window = (UserWindow)Window.GetWindow(this);
            window.Close();
        }
    }
}

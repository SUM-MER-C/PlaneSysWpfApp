using PlaneSysWpfApp.Manager;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
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
    /// UserPage1.xaml 的交互逻辑
    /// </summary>
    public partial class UserPage1 : Page
    {
        
        public UserPage1()
        {
            InitializeComponent();
            List<PlaneLine> linelist = new List<PlaneLine>();
            linelist = TextUtil.LoadLine();
            dataGrid.ItemsSource = linelist;
        }

        private void Btn1_Click(object sender, RoutedEventArgs e)
        {
            string inputCity1 = tbox1.Text;
            string inputCity2 = tbox2.Text;
            List<PlaneLine> linelist = new List<PlaneLine>();
            List<PlaneLine> filterList = new List<PlaneLine>();
            linelist = TextUtil.LoadLine();
            if (inputCity1.Equals("") && inputCity2.Equals(""))
            {
                filterList = linelist;
            }else if (inputCity1.Equals(""))
            {
                foreach (var line in linelist)
                {
                    if (inputCity2.Equals(line.getcity2())){ filterList.Add(line); }
                }
            }
            else if (inputCity2.Equals(""))
            {
                foreach (var line in linelist)
                {
                    if (inputCity1.Equals(line.getcity1())) { filterList.Add(line); }
                }
            }
            else
            {
                foreach (var line in linelist)
                {
                    if (inputCity1.Equals(line.getcity1()) && inputCity2.Equals(line.getcity2()))
                    {
                        filterList.Add(line);
                    }
                }
            }
            dataGrid.ItemsSource = filterList;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var window = (UserWindow)Window.GetWindow(this);
            string uName = window.userName;
            string uId = null;
            List<User> ulist = new List<User>();
            ulist = TextUtil.LoadUser();
            foreach (var u in ulist)
            {
                if (uName.Equals(u.getUserName()))
                {
                    uId = u.getUserId();
                } 
            }

            var btnRow = (PlaneLine) dataGrid.SelectedItem;

            List<Order> orders = new List<Order>();
            List<Order> olist = new List<Order>();
            orders = TextUtil.LoadOrder();
            int length = orders.ToArray().Length;
            string id =  (int.Parse( orders[length-1].OrderId) + 1).ToString();
            olist.Add(new Order(id, uId, btnRow.planeId));
            TextUtil.writeOrder(olist);
            MessageBox.Show("购买成功！");
        }
    }
}

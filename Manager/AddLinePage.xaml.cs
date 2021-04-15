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
    /// AddLinePage.xaml 的交互逻辑
    /// </summary>
    public partial class AddLinePage : Page
    {
        public AddLinePage()
        {
            InitializeComponent();
        }

        private void Sign1_Click(object sender, RoutedEventArgs e)
        {
            List<PlaneLine> lineList = new List<PlaneLine>();
            string inPlaneId = plid.Text;
            DateTime inTime1 = DateTime.Parse(time1.Text);
            DateTime inTime2 = DateTime.Parse(time2.Text);
            string inCity1 = c1.Text;
            string inCity2 = c2.Text;
            double inPrice = double.Parse(price.Text);
            double inSale = double.Parse(sale.Text);
            PlaneLine pl = new PlaneLine(inPlaneId, inTime1, inTime2, inCity1, inCity2, inPrice, inSale);
            lineList.Add(pl);
            Manager.TextUtil.writeLine(lineList);
            MessageBox.Show("航线信息添加成功！");
        }

        private void Sign2_Click(object sender, RoutedEventArgs e)
        {
            var win = Window.GetWindow(this);
            win.Close();
        }

        private void Sign3_Click(object sender, RoutedEventArgs e)
        {
            var win = Window.GetWindow(this);
            win.Close();
        }
    }
}

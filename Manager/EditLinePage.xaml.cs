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
    /// EditLinePage.xaml 的交互逻辑
    /// </summary>
    public partial class EditLinePage : Page
    {
        public EditLinePage()
        {
            InitializeComponent();
        }

        private void Sign1_Click(object sender, RoutedEventArgs e)
        {
            List<PlaneLine> lineList = new List<PlaneLine>();
            List<PlaneLine> newList = new List<PlaneLine>();
            lineList = Manager.TextUtil.LoadLine();
            string inPlaneId = plid.Text;
            DateTime inTime1 = DateTime.Parse(time1.Text);
            DateTime inTime2 = DateTime.Parse(time2.Text);
            string inCity1 = c1.Text;
            string inCity2 = c2.Text;
            double inPrice = double.Parse(price.Text);
            double inSale = double.Parse(sale.Text);

            for(int i = 0; i<lineList.ToArray().Length; i++)
            {
                if (inPlaneId.Equals(lineList[i].getPlaneId()))
                {
                    MessageBox.Show("输入的航班号无效！", MessageBoxImage.Error.ToString());
                    return;
                }
            }

            PlaneLine pl = new PlaneLine(inPlaneId, inTime1, inTime2, inCity1, inCity2, inPrice, inSale);
            newList.Add(pl);
            Manager.TextUtil.writeLine(newList);
            MessageBox.Show("航线信息修改成功！");
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

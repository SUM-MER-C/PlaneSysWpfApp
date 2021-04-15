using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PlaneSysWpfApp.Manager
{
    class TextUtil
    {
        public static List<User.User> LoadUser()
        {
            //获取当前路径
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "UserInfo" + ".txt";
            List<User.User> UserList = new List<User.User>();
            //读取文件
            if (File.Exists(txtDir))
            {
                StreamReader streamReader = new StreamReader(txtDir);
                while (streamReader.Peek() != -1)
                {
                    //读取文件中的一行字符
                    string str = streamReader.ReadLine();
                    string[] i = str.Split(' ');
                    User.User u = new User.User(i[0], i[1], int.Parse(i[2]), i[3]);
                    UserList.Add(u);

                }
                streamReader.Close();
            }
            else
            {
                Console.WriteLine(txtDir + " 文件不存在！");
            }
            return UserList;
        }

        public static List<PlaneLine> LoadLine()
        {
            //获取当前路径
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "LineInfo" + ".txt";
            List<PlaneLine> lineList = new List<PlaneLine>();
            //读取文件
            if (File.Exists(txtDir))
            {
                StreamReader streamReader = new StreamReader(txtDir);
                while (streamReader.Peek() != -1)
                {
                    //读取文件中的一行字符
                    string str = streamReader.ReadLine();
                    string[] i = str.Split(' ');
                    PlaneLine line = new PlaneLine(i[0], DateTime.Parse(i[1]+" "+i[2]), DateTime.Parse(i[3]+" "+i[4]), i[5], i[6], double.Parse(i[7]), double.Parse(i[8]));
                    lineList.Add(line);

                }
                streamReader.Close();
            }
            else
            {
                Console.WriteLine(txtDir + " 文件不存在！");
            }
            return lineList;
        }

        public static List<Order> LoadOrder()
        {
            //获取当前路径
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "OrderInfo" + ".txt";
            List<Order> orderList = new List<Order>();
            //读取文件
            if (File.Exists(txtDir))
            {
                StreamReader streamReader = new StreamReader(txtDir);
                while (streamReader.Peek() != -1)
                {
                    //读取文件中的一行字符
                    string str = streamReader.ReadLine();
                    string[] i = str.Split(' ');
                    Order order = new Order(i[0], i[1], i[2]);
                    orderList.Add(order);

                }
                streamReader.Close();
            }
            else
            {
                Console.WriteLine(txtDir + " 文件不存在！");
            }
            return orderList;
        }

        public static void writeUser(List<User.User> list)
        {
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "UserInfo" + ".txt";
            StreamWriter wr = new StreamWriter(new FileStream(txtDir, FileMode.Append));
           
            for (int i = 0; i<list.ToArray().Length; i++)
            {
                string str = list[i].getUserName() + " " + list[i].getUserId() + " " + list[i].getNumTic().ToString() + " " + list[i].getPwd();
                wr.WriteLine(str);
            }
            wr.Flush();
            wr.Close();
        }

        public static void writeOrder(List<Order> list)
        {
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "OrderInfo" + ".txt";
            StreamWriter wr = new StreamWriter(new FileStream(txtDir, FileMode.Append));

            for (int i = 0; i < list.ToArray().Length; i++)
            {
                string str = list[i].OrderId.ToString() + " " + list[i].UserId.ToString() + " " + list[i].PlaneId.ToString() ;
                wr.WriteLine(str);
            }
            wr.Flush();
            wr.Close();
        }

        public static void writeLine(List<PlaneLine> list)
        {
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "LineInfo" + ".txt";
            StreamWriter wr = new StreamWriter(new FileStream(txtDir, FileMode.Append));

            for (int i = 0; i < list.ToArray().Length; i++)
            {
                string str = list[i].getPlaneId() +" " + list[i].getTime1().ToString() + " " + list[i].getTime2().ToString() + " " + list[i].getcity1() + " " + list[i].getcity2() + " " + list[i].getPrice().ToString() + " " + list[i].getSale().ToString();
                wr.WriteLine(str);
            }
            wr.Flush();
            wr.Close();
        }
        public static void writeDeleteOrder(List<Order> list)
        {
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "OrderInfo" + ".txt";
            File.WriteAllText(txtDir, string.Empty);

            StreamWriter wr = new StreamWriter(new FileStream(txtDir, FileMode.Append));

            for (int i = 0; i < list.ToArray().Length; i++)
            {
                string str = list[i].OrderId.ToString() + " " + list[i].UserId.ToString() + " " + list[i].PlaneId.ToString();
                wr.WriteLine(str);
            }
            wr.Flush();
            wr.Close();
        }

        public static void writeEditUser(List<User.User> list)
        {
            string url = (Directory.GetCurrentDirectory()).Replace("bin\\Debug", "");
            string txtDir = url + "res\\" + "UserInfo" + ".txt";
            File.WriteAllText(txtDir, string.Empty);
            StreamWriter wr = new StreamWriter(new FileStream(txtDir, FileMode.Append));

            for (int i = 0; i < list.ToArray().Length; i++)
            {
                string str = list[i].getUserName() + " " + list[i].getUserId() + " " + list[i].getNumTic().ToString() + " " + list[i].getPwd();
                wr.WriteLine(str);
            }
            wr.Flush();
            wr.Close();
        }
    }
}

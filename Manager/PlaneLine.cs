using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneSysWpfApp.Manager
{
    class PlaneLine
    {
        public string planeId { get; set; }
        public DateTime time1 { get; set; }
        public DateTime time2 { get; set; }
        public string city1 { get; set; }
        public string city2 { get; set; }
        public double price { get; set; }
        public double sale { get; set; }

        public PlaneLine() { }
        public PlaneLine(string planeId, DateTime time1, DateTime time2, string city1, string city2, double price, double sale)
        {
            this.planeId = planeId;
            this.time1 = time1;
            this.time2 = time2;
            this.city1 = city1;
            this.city2 = city2;
            this.price = price;
            this.sale = sale;
        }

        public string getPlaneId() { return this.planeId; }
        public DateTime getTime1() { return this.time1; }
        public DateTime getTime2() { return this.time2; }
        public string getcity1() { return this.city1; }
        public string getcity2() { return this.city2; }
        public double getPrice() { return this.price; }
        public double getSale() { return this.sale; }

        public void setPlaneId(string id) { this.planeId = id; }
        public void setTime1(DateTime time1) { this.time1 = time1; }
        public void setTime2(DateTime time2) { this.time2 = time2; }
        public void setCity1(string city1) { this.city1 = city1; }
        public void setCity2(string city2) { this.city2 = city2; }
        public void setPrice(double p) { this.price = p; }
        public void setSale(double s ) { this.sale = s; }

    }
}

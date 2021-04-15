using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlaneSysWpfApp.User
{
    class User
    {
        private string userName;
        private string userId;
        private int numTic;
        private string password;

        public User() { }
        public User(string name, string id, int num, string pd)
        {
            this.userName = name;
            this.userId = id;
            this.numTic = num;
            this.password = pd;
        }
        public string getUserName() { return this.userName; }
        public string getUserId() { return this.userId; }
        public int getNumTic() { return this.numTic; }
        public string getPwd() { return this.password; }
        public void setPasswd(string pd) { this.password = pd; }
        public void setUserName(string name) { this.userName = name; }
        public void setUserId(string id) { this.userId = id; }
        public void setNumTic(int num) { this.numTic = num; }
    }
}

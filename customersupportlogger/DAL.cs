using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customersupportlogger
{
    public class DAL
    {
        public bool login(int id,string password)
        {
            customerEntities context = new customerEntities();
         List<UserInfo> users = context.UserInfoes.ToList();
            UserInfo obj = users.Find(us=>us.UserId == id);
            if(password == obj.Password)
                return true;
            else
                return false;
        }

        public void complaint(CustLogInfo log)
        {
            customerEntities context = new customerEntities();
            context.CustLogInfoes.Add(log);
            context.SaveChanges();
        }
    }
}

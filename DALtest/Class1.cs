using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customersupportlogger;
using NUnit.Framework;

namespace DALtest
{
    [TestFixture]
    public class Test
    {
        DAL d = new DAL();
        public Test()
        {
            d = new DAL();
        }
        
        [TestCase(101,"password")]
        [TestCase(102, "login")]
        public void check(int id,string password)
        {
            UserInfo u = new UserInfo();
            u.UserId = id;
            u.Password = password;
            Assert.IsTrue(d.login(id,password));
        }
    }
}

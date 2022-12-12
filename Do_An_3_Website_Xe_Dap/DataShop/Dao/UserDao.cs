using DataShop.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataShop.Dao
{
    public class UserDao
    {
        WebsiteXeDapMVCEntities db = null;
        public UserDao()
        {
            db = new WebsiteXeDapMVCEntities();
        }
        //// User
        public long Insert(User user)
        {
            db.Users.Add(user);
            db.SaveChanges();
            return user.UserID;
        }
        public User GetById(string userName)
        {
            return db.Users.SingleOrDefault(x => x.UserName == userName);
        }
        public User GetById(long userid)
        {
            return db.Users.SingleOrDefault(x => x.UserID == userid);
        }
        public bool Login(string userName, string password)
        {
            var result = db.Users.Count(x => x.UserName == userName && x.Password == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //// Customer

        public long InsertCustomer(Customer cus)
        {
            db.Customers.Add(cus);
            db.SaveChanges();
            return cus.CusID;
        }
        public bool CheckUserName(string userName)
        {
            return db.Customers.Count(x => x.UserName == userName) > 0;
        }
        public bool CheckUserEmail(string email)
        {
            return db.Customers.Count(x => x.Email == email) > 0;
        }

        public Customer GetByIdCustomer(string userName)
        {
            return db.Customers.SingleOrDefault(x => x.UserName == userName);
        }
        public bool LoginCustomer(string userName, string password)
        {
            var result = db.Customers.Count(x => x.UserName == userName && x.Password == password);
            if (result > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

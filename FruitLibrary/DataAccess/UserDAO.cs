using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLibrary.DataAccess
{
    internal class UserDAO
    {
        private static UserDAO instance = null;
        private static readonly object instanceLock = new object();
        public static UserDAO Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new UserDAO();
                    }
                }
                return instance;
            }
        }

        public IEnumerable<User> GetAll()
        {
            var u = new List<User>();
            try
            {
                using var context = new FruitDbContext();
                u = context.Users.ToList();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
            return u;
        }

        public User GetUserbyID(int id)
        {
            User user = null;
            try
            {
                using var context = new FruitDbContext();
                user = context.Users.SingleOrDefault(c => c.Id == id);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return user;
        }

        public void AddUser(User u)
        {
            try
            {
                User user = GetUserbyID(u.Id);
                if (user == null)
                {
                    using var context = new FruitDbContext();
                    context.Users.Add(u);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void UpdateUser(User u)
        {
            try
            {
                User user = GetUserbyID(u.Id);
                if (user != null)
                {
                    using var context = new FruitDbContext();
                    context.Users.Update(u);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User is already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Remove(int id)
        {
            try
            {

                User user = GetUserbyID(id);
                if (user != null)
                {
                    using var context = new FruitDbContext();
                    context.Users.Remove(user);
                    context.SaveChanges();
                }
                else
                {
                    throw new Exception("User does not already exist.");
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public User GetUser(string acc, string pass) {

            User user = null;
            try
            {
                using var context = new FruitDbContext();
                user = context.Users.SingleOrDefault(c => c.Acc == acc && c.Pass == pass);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }

            return user;
        }

      


    
}
}

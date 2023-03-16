using FruitLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLibrary.Repository
{
    public class UserRepository : IUserRepository
    {
        public void DeleteUser(int id)=> UserDAO.Instance.Remove(id);
        

        public IEnumerable<User> GetUser()=> UserDAO.Instance.GetAll();

        public User GetUser(string acc, string pass)=>UserDAO.Instance.GetUser(acc, pass);
       

        public User GetUserbyID(int id)=> UserDAO.Instance.GetUserbyID(id);
        

        public void InsertUser(User user)=>UserDAO.Instance.AddUser(user);

       
        

        public void UpdateUser(User user)=>UserDAO.Instance.UpdateUser(user);
        
    }
}

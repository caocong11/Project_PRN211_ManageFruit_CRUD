using FruitLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitLibrary.Repository
{
    public interface IUserRepository
    {
        IEnumerable<User> GetUser();
       
        User GetUserbyID(int id);
        User GetUser(string acc, string pass);
        void InsertUser(User user);
        void UpdateUser(User user);
        void DeleteUser(int id);
    }
}

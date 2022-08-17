using LibraryManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.DAO
{
    public interface IUserDAO
    {
       UserModel GetUserListByUserNameAndPassword(string UserName, string Password);

       List<UserModel> GetUserList();

        void SaveUser(UserModel user);
    }
}

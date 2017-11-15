using Critter.Web.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Critter.Web.DataAccess
{
    public interface IUserDAL
    {
        User GetUser(string username, string password);
        User GetUser(string username);
        List<string> GetUsernames(string startsWith);

        bool CreateUser(User newUser);
        bool ChangePassword(string username, string newPassword);

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPE.Models
{
    public class AccountUser
    {
        public string UserID { get; set; }
        public string Password { get; set; }
        public string UserFullName { get; set; }
        public int UserRole { get; set; }

        public AccountUser(string userID, string password, string userFullName, int userRole)
        {
            UserID = userID;
            Password = password;
            UserFullName = userFullName;
            UserRole = userRole;
        }

        public AccountUser()
        {
        }
    }
}

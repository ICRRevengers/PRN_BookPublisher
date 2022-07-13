using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestPE.Models;

namespace ConsoleApplication.Data
{
    public class AccountUserRepository
    {
        public AccountUser login(string UserID, string UserPassword)
        {
            AccountUser user = null;
            SqlConnection con = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
                con = new SqlConnection(cs);
                if (cs != null)
                {
                    SqlCommand cmd = new SqlCommand(
                        "select UserID,UserPassword,UserFullName,UserFullName,UserRole from dbo.AccountUser " +
                        "where UserID = @UserID And UserPassword = @UserPassword",con);
                    cmd.Parameters.AddWithValue("@UserID", UserID);
                    cmd.Parameters.AddWithValue("@UserPassword", UserPassword);
                    con.Open();
                    using (SqlDataReader rs = cmd.ExecuteReader())
                    {
                        if (rs.Read())
                        {
                            user = new AccountUser(
                                rs.GetString("UserID"),
                                rs.GetString("UserPassword"),
                                rs.GetString("UserFullName"),
                                rs.GetInt32("UserRole"));
                        }
                    }
                }
            }catch(Exception e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return user;


        }
    }
}

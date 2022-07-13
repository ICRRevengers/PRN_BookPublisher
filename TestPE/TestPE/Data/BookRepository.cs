using ConsoleApplication.Models;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication.Data
{
    public class BookRepository
    {
        public void Add(Book b)
        {
            SqlConnection con = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
                con = new SqlConnection(cs);
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand("insert into " +
                   "dbo.Book(BookID,BookName,Quantity,AuthorName,PublisherID)" +
                   " values(@BookID,@BookName,@Quantity,@AuthorName,@PublisherID)", con);
                    cmd.Parameters.AddWithValue("@BookID", b.BookID);
                    cmd.Parameters.AddWithValue("@BookName", b.BookName);
                    cmd.Parameters.AddWithValue("@Quantity", b.Quantity);
                    cmd.Parameters.AddWithValue("@AuthorName", b.AuthorName);
                    cmd.Parameters.AddWithValue("@PublisherID", b.PublisherID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }


            }
            catch (Exception)
            {
                throw;
            }

        }
        public DataTable GetAllBooks()
        {
            DataTable table = new DataTable();
            SqlConnection con = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
                con = new SqlConnection(cs);
                if (cs != null)
                {
                    SqlCommand cmd = new SqlCommand(
                        "select BookID,BookName,Quantity,AuthorName,PublisherID from dbo.Book",con);
                    con.Open();
                    using (SqlDataReader myReader = cmd.ExecuteReader())
                    {
                        table.Load(myReader);
                        myReader.Close();
                    }
                }
            }
            catch(Exception e)
            {
                throw;
            }
            finally
            {
                con.Close();
            }
            return table;
        }
        public void Delete(string BookID)
        {
            SqlConnection con = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
                con = new SqlConnection(cs);
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand("Delete from dbo.Book where BookID= @BookID", con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
        public void Update(string BookID, Book b)
        {
            SqlConnection con = null;
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["ConnectDB"].ConnectionString;
                con = new SqlConnection(cs);
                if (con != null)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE dbo.Book" +
                        " SET BookName = @BookName," +
                        " Quantity= @Quantity," +
                        " AuthorName= @AuthorName," +
                        " PublisherID=@PublisherID" +
                        " WHERE BookID = @BookID", con);
                    cmd.Parameters.AddWithValue("@BookName", b.BookName);
                    cmd.Parameters.AddWithValue("@Quantity", b.Quantity);
                    cmd.Parameters.AddWithValue("@AuthorName", b.AuthorName);
                    cmd.Parameters.AddWithValue("@PublisherID", b.PublisherID);
                    cmd.Parameters.AddWithValue("@BookID", BookID);
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}

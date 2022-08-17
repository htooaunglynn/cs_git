using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace AdoDotNetDemo2
{
    public class CRUDOpreationForUser
    {
        public void GetUserList()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=azono";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            if (con != null)
            {
               // Console.WriteLine("Database is connected.");
                //Console.WriteLine($"Your connected dataname is {con.Database} \n\n");
                


                string query = "SELECT * FROM Users";

                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader reader = sqlCommand.ExecuteReader(); ;
                while (reader.Read())
                {
                    Console.Write(reader["Id"]);
                    Console.Write(reader["UserName"]);
                    Console.Write(reader["Email"]);
                    Console.Write(reader["IsDelete"]);
                    Console.Write(reader["CreateDate"]);
                    Console.WriteLine();
                }
                Console.WriteLine();
                reader.Close();
                con.Close();
            }
        }

        public void SaveUser(UserModel user)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=azono";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                if (con != null)
                {
                   
                    string query = $"insert into users values({user.Id},'{user.UserName}','{user.Email}','{user.Password}','{user.IsDelete}','{user.CreateDate}')";

                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("1 record saved to database successfully");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur "+ex.Message);
   
            }
        } // end of saveuser

        public void UpdateUser(UserModel user)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=azono";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                if (con != null)
                {

                    string query = $"update users set UserName='{user.UserName}',Email='{user.Email}' where Id={user.Id}";

                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("1 record saved to database successfully");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur " + ex.Message);

            }
        } // end of update

        public void  DeleteUser(int user)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=SimpleDB;User Id=sa;Password=azono";

                SqlConnection con = new SqlConnection(connectionString);
                con.Open();

                if (con != null)
                {

                    string query = $"delete from users where Id={user}";

                    SqlCommand sqlCommand = new SqlCommand(query, con);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine("1 record saved to database successfully");
                    }

                    con.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error occur " + ex.Message);

            }
        }

    }
}

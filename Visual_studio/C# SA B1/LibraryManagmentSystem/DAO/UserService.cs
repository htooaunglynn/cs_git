using LibraryManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagmentSystem.DAO
{
    internal class UserService : IUserDAO
    {
        public List<UserModel> GetUserList()
        {
            List<UserModel> userListData=new List<UserModel>();

            string connectionString = @"Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=azono";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            if (con != null)
            {
                string query = $"SELECT * FROM Users";

                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    UserModel userModel = new UserModel()
                    {
                        Id = reader["ID"].ToString(),
                        UserName = reader["Name"].ToString(),
                        Email = reader["Email"].ToString(),
                    };

                    //Console.Write(reader["Id"]);
                    //Console.Write(reader["UserName"]);
                    //Console.Write(reader["Email"]);
                }

                //Console.WriteLine();
                reader.Close();
                con.Close();

            } // end of if

            return userListData;

        } // end of GetUserList Method

        public UserModel GetUserListByUserNameAndPassword(string UserName, string Password)
        {
            UserModel userModel = new UserModel();

            string connectionString = @"Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=azono";

            SqlConnection con = new SqlConnection(connectionString);
            con.Open();

            if (con != null)
            {
                // Console.WriteLine("Database is connected.");
                //Console.WriteLine($"Your connected dataname is {con.Database} \n\n");



                string query = $"SELECT * FROM Users WHERE Name = '{UserName}' AND Password = '{Password}'";

                SqlCommand sqlCommand = new SqlCommand(query, con);
                SqlDataReader reader = sqlCommand.ExecuteReader();

                while (reader.Read())
                {
                    userModel.Id =reader["ID"].ToString();
                    userModel.UserName = reader["Name"].ToString();
                    userModel.Email = reader["Email"].ToString();
                }
                Console.WriteLine();
                reader.Close();
                con.Close();
            }

            return userModel;
        }

        public void SaveUser(UserModel user)
        {
            try
            {
                string connectionString = @"Data Source=localhost;Initial Catalog=LibraryMgtDB;User Id=sa;Password=azono";

                SqlConnection sqlConnection = new SqlConnection(connectionString);
                sqlConnection.Open();

                if (sqlConnection != null)
                {
                    string query = $"insert into Product values ('{user.Id}','{user.UserName}','{user.Email}','{user.Password}','{user.Role}')";

                    SqlCommand sqlCommand = new SqlCommand(query, sqlConnection);
                    int result = sqlCommand.ExecuteNonQuery();

                    if (result > 0)
                    {
                        Console.WriteLine($"\nCommands completed successfully. \nCompletion time: {DateTime.Now}\n");
                    }

                    sqlConnection.Close();
                }
            }
            catch (Exception error)
            {
                Console.WriteLine("Error occur " + error.Message);
            }
        }
    }
}

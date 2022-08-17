using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Assignment4
{
    public class DatabaseConnection
    {
        public virtual void ProductInformation()
        {
            string connectionString = @"Data Source=localhost;Initial Catalog=ShopMgtDB;User Id=sa;Password=azono";

            SqlConnection sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
        }
    }
}

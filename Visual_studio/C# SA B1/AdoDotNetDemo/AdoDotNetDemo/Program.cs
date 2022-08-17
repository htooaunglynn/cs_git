using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoDotNetDemo
{
    public class Program
    {
        public static void Main()
        {
            DatabaseConnection databaseConnection=new DatabaseConnection();
            databaseConnection.CheckDatabase();
        }
    }
}

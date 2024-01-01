using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Pharmacy_Menagment.Classes
{
    public class ConnectionDb
    {
        /// <summary>
        /// @"Data Source=.;Integrated Security=True;Initial Catalog=EmriBazesTeDhënave"
        /// Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MyMedicine;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False
        /// </summary>
        SqlConnection connection = new SqlConnection("Data Source=(localdb)\\Local;Initial Catalog=MyMedicine;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        public SqlConnection getConnection { get => connection; }

        public SqlConnection OpenConnection()
        {
            if (connection.State == System.Data.ConnectionState.Closed)
            {
               connection.Open();
              
            }
            return connection;
        }
        public SqlConnection CloseConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
            return connection;
        }
    }
}

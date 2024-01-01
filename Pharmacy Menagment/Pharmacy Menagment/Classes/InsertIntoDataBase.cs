using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pharmacy_Menagment.Classes
{
    public class CommandDatabase
    {
        ConnectionDb connection = new ConnectionDb();
        SqlCommand cmd = new SqlCommand();
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public int GetIdItem(string querry)
        {
            connection.OpenConnection();
            cmd = new SqlCommand(querry, connection.getConnection);
            int res = (int)cmd.ExecuteScalar();
            connection.CloseConnection();
            return res;
        }
        public void InsertDb(string querry) 
        {
            connection.OpenConnection();
            cmd = new SqlCommand(querry,connection.getConnection);
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.ExecuteNonQuery();
            connection.CloseConnection();
        }
        public DataTable GetDataTable(string querry)
        {
            connection.OpenConnection();
            adapter = new SqlDataAdapter(querry, connection.getConnection);
            dt = new DataTable();
            adapter.Fill(dt);
            connection.CloseConnection();

            return dt;
        }

    }
}

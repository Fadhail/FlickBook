using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Controllers
{
    internal class Koneksi
    {
        string connectionstring = "Server=localhost;Database=flickbook;Uid=root;Pwd=;";
        MySqlConnection connection;

        public SqlConnection Connection { get; internal set; }

        public void OpenConnection()
        {
            connection = new MySqlConnection(connectionstring);
            connection.Open();
        } 

        public void CloseConnection()
        {
            connection.Close();
        }

        public void ExecuteQueries(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, connection);
            cmd.ExecuteNonQuery();
        }

        public object ShowData(string Query_)
        {
            MySqlDataAdapter adapter = new MySqlDataAdapter(Query_, connectionstring);
            DataSet data = new DataSet();

            adapter.Fill(data);
            object datatable = data.Tables[0];
            return datatable;
        }

        public MySqlDataReader reader(string Query_)
        {
            MySqlCommand cmd = new MySqlCommand(Query_, connection);
            MySqlDataReader reader = cmd.ExecuteReader();
            return reader;
        }

        internal void ExecuteQuery(string v)
        {
            throw new NotImplementedException();
        }
    }
}

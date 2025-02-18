using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
using System.Windows.Forms;


namespace FlickBook.Controllers
{
    internal class RegisterController
    {
        private MySqlConnection conn;

        public RegisterController()
        {
            conn = new MySqlConnection("Server=localhost;Database=flickbook;Uid=root;Pwd=;");
        }

        public bool RegisterUser(RegisterModel user)
        {
            try
            {
                conn.Open();

                // Periksa apakah username sudah ada
                string checkQuery = "SELECT COUNT(*) FROM users WHERE username = @username";
                MySqlCommand checkCmd = new MySqlCommand(checkQuery, conn);
                checkCmd.Parameters.AddWithValue("@username", user.Username);
                int count = Convert.ToInt32(checkCmd.ExecuteScalar());

                if (count > 0)
                {
                    conn.Close();
                    return false; // Username sudah terdaftar
                }

                // Query untuk menambahkan user baru
                string query = "INSERT INTO users (username, password, name, email) VALUES (@username, @password, @name, @email)";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                cmd.Parameters.AddWithValue("@name", user.Name);
                cmd.Parameters.AddWithValue("@email", user.Email);
                cmd.Parameters.AddWithValue("@username", user.Username);
                cmd.Parameters.AddWithValue("@password", user.Password);

                cmd.ExecuteNonQuery();
                conn.Close();
                return true; // Registrasi berhasil
            }
            catch (Exception ex)
            {
                conn.Close();
                throw new Exception("Error: " + ex.Message);
            }
        }
    }
}

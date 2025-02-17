using FlickBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Controllers
{
    internal class TheaterController
    {
        Koneksi koneksi = new Koneksi();
        public bool status;

        public bool Insert(TheaterModel theater)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "INSERT INTO theater (theater_id, name, location) VALUES ('" + theater.Theater_id + "', '" + theater.Name + "', '" + theater.Location + "')";
                koneksi.ExecuteQueries(query);
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public bool Update(TheaterModel theater)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "UPDATE theater SET name = '" + theater.Name + "', location = '" + theater.Location + "' WHERE theater_id = '" + theater.Theater_id + "'";
                koneksi.ExecuteQueries(query);
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }

        public bool Delete(TheaterModel theater)
        {
            try
            {
                koneksi.OpenConnection();
                string query = "DELETE FROM theater WHERE theater_id = '" + theater.Theater_id + "'";
                koneksi.ExecuteQueries(query);
                status = true;
            }
            catch (Exception)
            {
                status = false;
            }
            finally
            {
                koneksi.CloseConnection();
            }
            return status;
        }
    }
}

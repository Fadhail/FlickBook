using FlickBook.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                koneksi.ExecuteQuery("INSERT INTO theater (theater_id, theater_name, location) VALUES('" + theater.Theater_id + "', '" + theater.Name + "','" + theater.Location + "')");
                status = true;
                MessageBox.Show("Insert Data Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                koneksi.CloseConnection();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Insert Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                status = false;
            }
            return status;
        }

        public bool Update(TheaterModel theater)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("UPDATE theater SET theater_name = '" + theater.Name + "', location = '" + theater.Location + "' WHERE theater_id = '" + theater.Theater_id + "'");
                status = true;
                MessageBox.Show("Update Data Success", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Update Data Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }

        public bool Delete(string Theater_id)
        {
            bool status = false;
            try
            {
                koneksi.OpenConnection();
                koneksi.ExecuteQuery("DELETE FROM theater WHERE theater_id = '" + Theater_id + "'");
                MessageBox.Show("Delete Data Success");
                koneksi.CloseConnection();
                status = true;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Failed Delete Data", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return status;
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FlickBook.Controllers;
using FlickBook.Models;

namespace FlickBook.Views
{
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Login Login = new Login();
            this.Hide();
            Login.Show();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            if (tbName.Text == "" || tbRegisterPassword.Text == "" || tbName.Text == "" || tbEmail.Text == "")
            {
                MessageBox.Show("Username, Password, Nama, dan Email tidak boleh kosong!", "Peringatan");
                return;
            }

            // Membuat instance RegisterModel dengan nama dan email
            RegisterModel newUser = new RegisterModel(tbName.Text, tbRegisterPassword.Text, tbName.Text, tbEmail.Text);

            // Membuat instance RegisterController
            RegisterController registerController = new RegisterController();

            // Memanggil metode RegisterUser
            bool success = registerController.RegisterUser(newUser);

            if (success)
            {
                MessageBox.Show("Registrasi Berhasil! Silakan Login.", "Berhasil");
                Login loginForm = new Login();
                this.Hide();
                loginForm.Show();
            }
            else
            {
                MessageBox.Show("Registrasi Gagal! Username sudah digunakan.", "Gagal");
            }
        }
    }
}

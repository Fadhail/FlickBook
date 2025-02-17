using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Controllers
{
    internal class RegisterModel
    {
        public string Username { get; set; }
        public string Name{ get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public RegisterModel(string username, string name, string email, string password)
        {
            Name = name;
            Username = username;
            Email = email;
            Password = password;
        }
    }
}

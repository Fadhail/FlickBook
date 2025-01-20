using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlickBook.Models
{
    internal class TheaterModels
    {
        string theater_id, name, location;

        public TheaterModels()
        {

        }
        public TheaterModels(string theater_id, string name, string location)
        {
            this.Theater_id = theater_id;
            this.Name = name;
            this.Location = location;
        }

        public string Theater_id { get => theater_id; set => theater_id = value; }
        public string Name { get => name; set => name = value; }
        public string Location { get => location; set => location = value; }
    }
}

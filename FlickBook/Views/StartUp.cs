using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlickBook.Views
{
    public partial class StartUp : Form
    {
        public StartUp()
        {
            InitializeComponent();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            Parent frm = new Parent();
            progressBar1.Value += 10;
            if (progressBar1.Value == 100)
            {
                timer1.Dispose();
                Close();
            }
        }
    }
}

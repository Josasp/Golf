using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class soktavling : Form
    {
        public soktavling()
        {
            InitializeComponent();
        }

        private void avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            infotavling infotavling = new infotavling();
            infotavling.Show(); 
        }
    }
}

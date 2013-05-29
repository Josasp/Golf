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
    public partial class visaspelare : Form
    {
        public visaspelare()
        {
            InitializeComponent();
        }

        private void action_button_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void medlem_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            medlem_groupBox.Visible = true;
        }

        private void ickemedlem_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            medlem_groupBox.Visible = false;
        }

        private void visaspelare_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                // en av flera val.
                visatavlingmedlem visatavlingmedlem = new visatavlingmedlem();
                visatavlingmedlem.Show(); 
            
        }
    }
}

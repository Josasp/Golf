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
    public partial class VisaSpelare : Form
    {
        public VisaSpelare()
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

        private void visaspelare_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                // en av flera val.
                VisaTavlingMedlem visatavlingmedlem = new VisaTavlingMedlem();
                visatavlingmedlem.Show(); 
            
        }
    }
}

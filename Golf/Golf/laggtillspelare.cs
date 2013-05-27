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
    public partial class laggtillspelare : Form
    {
        public laggtillspelare()
        {
            InitializeComponent();
        }

        private void laggtillspelare_Load(object sender, EventArgs e)
        {

        }

        private void medlem_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            medlem_groupBox.Visible = true;
        }

        private void ickemedlem_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            medlem_groupBox.Visible = false;
        }
    }
}

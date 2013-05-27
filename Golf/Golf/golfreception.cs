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
    public partial class golfreception : Form
    {
        public golfreception()
        {
            InitializeComponent();
        }

        private void läggTillSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            laggtillspelare laggtillspelare = new laggtillspelare();
            laggtillspelare.Show();
        }
    }
}

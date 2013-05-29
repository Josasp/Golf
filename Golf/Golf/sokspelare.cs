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
    public partial class sokspelare : Form
    {
        public sokspelare()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            visaspelare visaspelare = new visaspelare();
            visaspelare.Show();  
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            visaspelare visaspelare = new visaspelare();
            visaspelare.Show();  
        }
    }
}

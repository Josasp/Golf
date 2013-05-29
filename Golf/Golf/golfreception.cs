using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; 

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

        private void seAllaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sealla sealla = new sealla();
            sealla.Show();
        }

        private void sökSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sokspelare sokspelare = new sokspelare();
            sokspelare.Show();
        }

        private void registreraTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registreratavling registreratavling = new registreratavling();
            registreratavling.Show();
        }

        private void sökTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            soktavling soktavling = new soktavling();
            soktavling.Show();
        }

        private void golfreception_Load(object sender, EventArgs e)
        {
            // Bara lite test.... 
            int tid = 0; 


            while (tid < 30)
            {
                listView1.Items.Add(Convert.ToString(tid));
                tid = tid + 1; 
            }

        }
    }
}

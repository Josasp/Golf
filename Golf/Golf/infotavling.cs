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
    public partial class infotavling : Form
    {
        public infotavling()
        {
            InitializeComponent();
        }

        private void infotavling_Load(object sender, EventArgs e)
        {

        }

        private void avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {

        }

        private void anmälSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            anmalspelare anmalspelare = new anmalspelare();
            anmalspelare.Show();
        }

        private void seAnmäldaSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seanmaldaspelare seanmaldaspelare = new seanmaldaspelare();
            seanmaldaspelare.Show();
        }

        private void registreraResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            registreraresultat registreraresultat = new registreraresultat();
            registreraresultat.Show();
        }

        private void seResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            seresultat seresultat = new seresultat();
            seresultat.Show();
        }

        private void lottaStarttiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lottastarttider lottastarttider = new lottastarttider();
            lottastarttider.Show();
        }

        private void seStarttiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sestarttider sestarttider = new sestarttider();
            sestarttider.Show();
        }
    }
}

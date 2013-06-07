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
    public partial class InfoTavling : Form
    {
        public InfoTavling()
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
            AnmalSpelare anmalspelare = new AnmalSpelare();
            anmalspelare.Show();
        }

        private void seAnmäldaSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeAnmaldaSpelare seanmaldaspelare = new SeAnmaldaSpelare();
            seanmaldaspelare.Show();
        }

        private void registreraResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraResultat registreraresultat = new RegistreraResultat();
            registreraresultat.Show();
        }

        private void seResultatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeResultat seresultat = new SeResultat(GetTävling_id());
            seresultat.Show();
        }

        private void lottaStarttiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LottaStarttider lottastarttider = new LottaStarttider();
            lottastarttider.Show();
        }

        private void seStarttiderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeStarttider sestarttider = new SeStarttider();
            sestarttider.Show();
        }

        private int GetTävling_id()
        {
            return int.Parse(tävling_id_textBox.Text);
        }
    }
}

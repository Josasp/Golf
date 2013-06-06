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
    public partial class RegistreraResultat : Form
    {
        public RegistreraResultat()
        {
            InitializeComponent();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {

        }

        private void beräkna_button_Click(object sender, EventArgs e)
        {
            int hål1 = Convert.ToInt32(textBox1.Text);
            int hål2 = Convert.ToInt32(textBox2.Text);
            int hål3 = Convert.ToInt32(textBox3.Text);
            int hål4 = Convert.ToInt32(textBox4.Text);
            int hål5 = Convert.ToInt32(textBox5.Text);
            int hål6 = Convert.ToInt32(textBox6.Text);
            int hål7 = Convert.ToInt32(textBox7.Text);
            int hål8 = Convert.ToInt32(textBox8.Text);
            int hål9 = Convert.ToInt32(textBox9.Text);
            int hål10 = Convert.ToInt32(textBox10.Text);
            int hål11 = Convert.ToInt32(textBox11.Text);
            int hål12 = Convert.ToInt32(textBox12.Text);
            int hål13 = Convert.ToInt32(textBox13.Text);
            int hål14 = Convert.ToInt32(textBox14.Text);
            int hål15 = Convert.ToInt32(textBox15.Text);
            int hål16 = Convert.ToInt32(textBox16.Text);
            int hål17 = Convert.ToInt32(textBox17.Text);
            int hål18 = Convert.ToInt32(textBox18.Text);

            int resultat = hål1 + hål2 + hål3 + hål4 + hål5 + hål6 + hål7 + hål8 + hål9 + hål10 + hål11 + hål12 + hål13 + hål14 + hål15 + hål16 + hål17 + hål18;

            string resultatet = Convert.ToString(resultat);
            resultat_textBox.Text = resultatet;
        }

    }
}

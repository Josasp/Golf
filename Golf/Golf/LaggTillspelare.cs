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
    public partial class LaggTillspelare : Form
    {
        public LaggTillspelare()
        {
            InitializeComponent();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            int kon = 0;

            if (kon_comboBox.Text == "Kvinna")
            {
                kon = 1; 
            }
            else if (kon_comboBox.Text == "Man")
            {
                kon = 0; 
            }

            int status = 1;

            if (medlemsstatus_comboBox.Text == "Aktiv")
            {
                status = 1; 
            }
            else if (medlemsstatus_comboBox.Text == "Vilande")
            {
                status = 2; 
            }
            else if (medlemsstatus_comboBox.Text == "Greenfee")
            {
                status = 3;
            }
            else if (medlemsstatus_comboBox.Text == "Junior")
            {
                status = 4;
            }
            else if (medlemsstatus_comboBox.Text == "Ickemedlem")
            {
                status = 5;
            }

            string inimedlem = "insert into medlem (golf_id, \"förnamn\", efternamn, \"kön_id\", adress, postnummer, stad, telefonnummer, epost, handicap, status_id, \"betaltÅr\") values(" + golfid_textBox.Text + ", '" + fornamn_textBox.Text + "', '" + efternamn_textBox.Text + "', " + kon + ", '" + adress_textBox.Text + "', " + postnummer_textBox.Text + ", '" + postort_textBox.Text + "', '" + telefonnummer_textBox.Text + "', '" + epost_textBox.Text + "', " + handicap_textBox.Text + ", " + status + ", " + betalt_textBox.Text + ";)";
            NpgsqlCommand command_medlem = new NpgsqlCommand(inimedlem, GolfReception.conn);
            MessageBox.Show(inimedlem); 
            command_medlem.ExecuteNonQuery();

            

            MessageBox.Show("Spelare tillagd."); 
            this.Close(); 
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void medlemsstatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

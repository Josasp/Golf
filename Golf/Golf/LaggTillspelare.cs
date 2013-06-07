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

        private void medlem_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            medlem_groupBox.Visible = true;
        }

        private void ickemedlem_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            medlem_groupBox.Visible = false;
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            // Kolla största värdet för kontaktid
            NpgsqlCommand command1 = new NpgsqlCommand("select max(kontaktid) from kontakt;", GolfReception.conn);
            int kontaktid = 0;
            kontaktid = (Int32)command1.ExecuteScalar();
            kontaktid = kontaktid + 1;

            string inikontakt = "insert into kontakt (kontaktid, postadress, postnummer, postort, telefonnummer, epost) values (" + kontaktid + ", '" + adress_textBox.Text + "', " + postnummer_textBox.Text + ", '" + postort_textBox.Text + "', '" + telefonnummer_textBox.Text + "', '" + epost_textBox.Text + "')";
            NpgsqlCommand command = new NpgsqlCommand(inikontakt, GolfReception.conn);
            command.ExecuteNonQuery();

            string iniperson = "insert into person (golfid, kon, handicap, fornamn, efternamn, kontaktid) values(" + golfid_textBox.Text + ", '" + kon_comboBox.Text + "', " + handicap_textBox.Text + ", '" + fornamn_textBox.Text + "', '" + efternamn_textBox.Text + "', " + kontaktid + ")";
            NpgsqlCommand command2 = new NpgsqlCommand(iniperson, GolfReception.conn);
            command2.ExecuteNonQuery();

            // Lägger in information i medlem om medlem är ikryssad. 
            if (medlem_radioButton.Checked == true)
            {
                string inimedlem = "insert into medlem (golfid, medlemsstatus, betalt) values(" + golfid_textBox.Text + ", '" + medlemsstatus_comboBox.Text + "', " + betalat_checkBox.Checked + ")";
                NpgsqlCommand command3 = new NpgsqlCommand(inimedlem, GolfReception.conn);
                command3.ExecuteNonQuery();
            }
            
            // Kön ej tillagt i persontabellen i databasen? 

            MessageBox.Show("Spelare tillagd."); 
            this.Close(); 
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}

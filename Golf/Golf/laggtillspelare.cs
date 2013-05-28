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
    public partial class laggtillspelare : Form
    {
        public laggtillspelare()
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
            // Ansluter till databasen. 
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp6vt13;User Id=grp6vt13;Password=gOMMObmEP;SSL=true");
            conn.Open();

            // Lägg in information i databasen. 
            int kontaktid = 1; // Hur kolla vilket som är det största i tabellen och sätta till nästa? 
            string inikontakt = "insert into kontakt (kontaktid, postadress, postnummer, postort, telefonnummer, epost) values (" + kontaktid + ", '" + adress_textBox.Text + "', " + postnummer_textBox.Text + ", '" + postort_textBox.Text + "', '" + telefonnummer_textBox.Text + "', '" + epost_textBox.Text + "')";
            NpgsqlCommand command = new NpgsqlCommand(inikontakt, conn);
            command.ExecuteNonQuery();

            string iniperson = "insert into person (golfid, handicap, fornamn, efternamn, kontaktid) values(" + golfid_textBox.Text + ", " + handicap_textBox.Text + ", '" + fornamn_textBox.Text + "', '" + efternamn_textBox.Text + "', " + kontaktid + ")";
            NpgsqlCommand command2 = new NpgsqlCommand(iniperson, conn);
            command2.ExecuteNonQuery();

            if (medlem_radioButton.Checked == true)
            {
                string inimedlem = "insert into medlem (golfid, medlemsstatus, betalt) values(" + golfid_textBox.Text + ", '" + medlemsstatus_comboBox.Text + "', " + betalat_checkBox.Checked + ")";
                NpgsqlCommand command3 = new NpgsqlCommand(inimedlem, conn);
                command3.ExecuteNonQuery();
            }
            
            // Kön ej tillagt i persontabellen i databasen? 

            // Stäng anslutning till databasen. 
            conn.Close();

        }
    }
}

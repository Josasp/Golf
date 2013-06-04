using Npgsql;
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
    public partial class RegistreraTavling : Form
    {
        public RegistreraTavling()
        {
            InitializeComponent();
        }

        private void avbryt_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ok_button_Click(object sender, EventArgs e)
        {
            // Lägg in information om tävling i databasen.  
            DateTime tävlingsdatum = this.dateTimePicker1.Value.Date;
            DateTime sistaAnmälningsdatum = this.dateTimePicker2.Value.Date;
            DateTime sistaAvanmälningsdatum = this.dateTimePicker3.Value.Date;
            string initavling = "insert into tavling (tavlingid, tavlingnamn, datum, sistaanmalningsdatum, sistaavanmalningsdatum, maxdeltagare) values (" + tavlingid_textBox.Text + ", " + tavlingsnamn_textBox.Text + ", " + tävlingsdatum + ", " + sistaAnmälningsdatum + ", " + sistaAvanmälningsdatum + ", " + maxantaldeltagare_textBox.Text + ")";
            NpgsqlCommand command = new NpgsqlCommand(initavling, GolfReception.conn);
            command.ExecuteNonQuery();

            
            // Hur göra med kön?

            // Hur göra med handicapgränser?

            // Hur göra med klass?

            // Hur göra med tävlingstyp?

            // Hur göra med boka upp starttider? 

            // Stäng anslutning till databasen. 

        }
    }
}

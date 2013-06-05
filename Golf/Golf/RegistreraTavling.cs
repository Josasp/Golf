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
            String sql = "SELECT * FROM bokning;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();
            while (ndr.Read())
            {
                MessageBox.Show(this, ndr["bokning_id"].ToString());
            }


            // Lägg in information om tävling i databasen, tabell tävling.  
            DateTime tävlingsdatum = this.dateTimePicker1.Value.Date;
            DateTime sistaAnmälningsdatum = this.dateTimePicker2.Value.Date;
            string initavling = "insert into \"tävling\" (\"namn\", \"sistaAnmälan\", \"maxDeltagare\") values ('" + tavlingsnamn_textBox.Text + "', " + tävlingsdatum + ", " + sistaAnmälningsdatum + ", " + maxantaldeltagare_textBox.Text + "); SELECT CURRVAL(pg_get_serial_sequence('\"tävling\"','tävling_id'))";
            NpgsqlCommand command_tavling = new NpgsqlCommand(initavling, GolfReception.conn);
            NpgsqlDataReader t = command_tavling.ExecuteReader();
            t.Read();
            int tävling_id = Convert.ToInt32(t["currval"]);
            t.Close();


            // Lägg in information om tävling i databasen, tabell klass. 
            //string iniklassa = "insert into \"klass\" (\"klassnamn\", \"startvärde\", \"slutvärde\", \"tävling_id\") values ('A', " + a_fran_textBox.Text + ", " + a_till_textBox.Text + ", " + tävling_id.ToString() + ")";
            //NpgsqlCommand command_klass_a = new NpgsqlCommand(iniklassa, golfreception.conn);
            //command_klass_a.ExecuteNonQuery();




            // Stäng anslutning till databasen?. 

        }
    }
}

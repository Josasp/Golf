﻿using Npgsql;
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
            // Lägger in information om tävling i databasen, tabell tävling.  
            DateTime sistaAnmälningsdatum = this.dateTimePicker2.Value.Date;
            string in_i_tävling = "insert into \"tävling\" (\"namn\", \"sistaAnmälan\", \"maxDeltagare\") values ('" + tavlingsnamn_textBox.Text + "', '" + sistaAnmälningsdatum + "', " + maxantaldeltagare_textBox.Text + "); SELECT CURRVAL(pg_get_serial_sequence('\"tävling\"','tävling_id'))";
            NpgsqlCommand command_tavling = new NpgsqlCommand(in_i_tävling, GolfReception.conn);
            NpgsqlDataReader id_tävling = command_tavling.ExecuteReader();
            id_tävling.Read();
            int tävling_id = Convert.ToInt32(id_tävling["currval"]);
            id_tävling.Close();


            // Lägger in information om tävlingsklass A i databasen, tabell klass. 
            string in_i_klass_a = "insert into \"klass\" (\"klassnamn\", \"startvärde\", \"slutvärde\", \"tävling_id\") values ('A', " + a_fran_textBox.Text + ", " + a_till_textBox.Text + ", " + tävling_id.ToString() + ")";
            NpgsqlCommand command_klass_a = new NpgsqlCommand(in_i_klass_a, GolfReception.conn);
            command_klass_a.ExecuteNonQuery();

            // Lägger in information om tävlingsklass B i databasen, tabell klass. 
            string in_i_klass_b = "insert into \"klass\" (\"klassnamn\", \"startvärde\", \"slutvärde\", \"tävling_id\") values ('B', " + b_fran_textBox.Text + ", " + b_till_textBox.Text + ", " + tävling_id.ToString() + ")";
            NpgsqlCommand command_klass_b = new NpgsqlCommand(in_i_klass_b, GolfReception.conn);
            command_klass_b.ExecuteNonQuery();

            // Lägger in information om tävlingsklass C i databasen, tabell klass. 
            string in_i_klass_c = "insert into \"klass\" (\"klassnamn\", \"startvärde\", \"slutvärde\", \"tävling_id\") values ('C', " + c_fran_textBox.Text + ", " + c_till_textBox.Text + ", " + tävling_id.ToString() + ")";
            NpgsqlCommand command_klass_c = new NpgsqlCommand(in_i_klass_c, GolfReception.conn);
            command_klass_c.ExecuteNonQuery();

            // Lägger in information om kön i databasen, tabell tävling_kön.
            string in_i_tävling_kön_0 = "insert into \"tävling_kön\" (\"tävling_id\", \"kön_id\") values (" + tävling_id.ToString() + ", '" + 0 + "')";
            NpgsqlCommand command_kon_0 = new NpgsqlCommand(in_i_tävling_kön_0, GolfReception.conn);

            if (man_checkBox.Checked)
                command_kon_0.ExecuteNonQuery();


            string in_i_tävling_kön_1 = "insert into \"tävling_kön\" (\"tävling_id\", \"kön_id\") values (" + tävling_id.ToString() + ", '" +  1 + "')";
            NpgsqlCommand command_kon_1 = new NpgsqlCommand(in_i_tävling_kön_1, GolfReception.conn);

            if (kvinnor_checkBox.Checked)
                command_kon_1.ExecuteNonQuery();


            string in_i_tävling_kön_2 = "insert into \"tävling_kön\" (\"tävling_id\", \"kön_id\") values (" + tävling_id.ToString() + ", '" + 2 + "')";
            NpgsqlCommand command_kon_2 = new NpgsqlCommand(in_i_tävling_kön_2, GolfReception.conn);

            if (kvinnor_checkBox.Checked && man_checkBox.Checked)
                command_kon_2.ExecuteNonQuery();


            MessageBox.Show("Tävlingen är registrerad!"); 
            this.Close();

        }

        private void kvinnor_checkBox_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

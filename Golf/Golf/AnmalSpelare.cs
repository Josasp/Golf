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
    public partial class AnmalSpelare : Form
    {
        public AnmalSpelare()
        {
            InitializeComponent();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            // Lägger in information om anmälda spelare i databasen, tabell tävling_medlem.
            string in_i_tävling_medlem_reg = "insert into \"tävling_medlem\" (\"tävling_id\", \"golf_id\") values (" + tävling_id_textBox.Text + ", '" + golfid_textBox.Text + "')";
            NpgsqlCommand command_tävling_medlem_reg = new NpgsqlCommand(in_i_tävling_medlem_reg, GolfReception.conn);
            command_tävling_medlem_reg.ExecuteNonQuery();

            MessageBox.Show("Spelare är anmäld till tävling!");
            this.Close();
        }

        private void AnmalSpelare_Load(object sender, EventArgs e)
        {

        }
    }
}

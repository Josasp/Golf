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
    public partial class sealla : Form
    {
        public sealla()
        {
            InitializeComponent();
        }

        private void sealla_Load(object sender, EventArgs e)
        {
            // Ansluter till databasen. 
            NpgsqlConnection conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp6vt13;User Id=grp6vt13;Password=gOMMObmEP;SSL=true");
            conn.Open();

            NpgsqlCommand command = new NpgsqlCommand("select golfid, fornamn, efternamn from person", conn);
            NpgsqlDataReader dr = command.ExecuteReader();
            while (dr.Read())
            {
                listBox1.Items.Add(dr[0] + " " + dr[1] + " " + dr[2]);
            }

            // Kollar state på anslutningen. 
            //MessageBox.Show(conn.State.ToString());

            // Stäng anslutning till databasen. 
            conn.Close();

            }


        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

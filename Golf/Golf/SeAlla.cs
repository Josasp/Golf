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
    public partial class SeAlla : Form
    {
        public SeAlla()
        {
            InitializeComponent();
        }

        private void sealla_Load(object sender, EventArgs e)
        {
            NpgsqlCommand command1 = new NpgsqlCommand("select golf_id, medlem.\"förnamn\", medlem.efternamn, medlem.handicap, status.namn, medlem.\"betaltÅr\", \"kön\".namn, medlem.adress, medlem.postnummer, medlem.stad, medlem.telefonnummer, medlem.epost from medlem, status, \"kön\" where medlem.status_id = status.status_id and \"kön\".\"kön_id\" = medlem.\"kön_id\";", GolfReception.conn);
            NpgsqlDataReader dr = command1.ExecuteReader();

            while (dr.Read())
            {
                listBox1.Items.Add(dr[0] + " " + dr[1] + " " + dr[2] + " " + dr[3] + " " + dr[4] + " " + dr[5] + " " + dr[6] + " " + dr[7] + " " + dr[8] + " " + dr[9] + " " + dr[10] + " " + dr[11]);
            }

            dr.Close();
            }


        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

    }
}

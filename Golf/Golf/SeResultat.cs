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
    public partial class SeResultat : Form
    {
        private int tävling_id;

        public SeResultat(int tävling_id)
        {
            this.tävling_id = tävling_id;
            InitializeComponent();
            UpdateTable();
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdateTable()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tävling_id", typeof(string));
            dt.Columns.Add("namn", typeof(string));
            dt.Columns.Add("resultat", typeof(string));

            String sql = "SELECT    \"tävling_medlem\".\"tävling_id\",    \"tävling_medlem\".resultat,    (medlem.\"förnamn\" || ' ' || medlem.efternamn) as namn FROM    public.\"tävling_medlem\",    public.medlem WHERE    \"tävling_medlem\".golf_id = medlem.golf_id AND   \"tävling_medlem\".\"tävling_id\" = '" + tävling_id.ToString() + "';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow row = dt.NewRow();
                row["tävling_id"] = ndr["tävling_id"].ToString();
                row["namn"] = ndr["namn"].ToString();
                row["resultat"] = ndr["resultat"].ToString();

                dt.Rows.Add(row);
            }
            ndr.Close();

            //Set the component data
            DataView dv = new DataView(dt);
            dataGridView.DataSource = dv;

            //Set column header text
            //dataGridView.Columns[0].HeaderText = "Tid";
            //dataGridView.Columns[1].HeaderText = "Spelare 1";
            //dataGridView.Columns[2].HeaderText = "Spelare 2";
            //dataGridView.Columns[3].HeaderText = "Spelare 3";
            //dataGridView.Columns[4].HeaderText = "Spelare 4";
            //dataGridView.Columns[5].HeaderText = "Tävling";
            //dataGridView.Columns[6].HeaderText = "Upptagen";
        }
    }
}

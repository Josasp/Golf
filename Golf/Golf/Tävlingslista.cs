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
    public partial class Tävlingslista : Form
    {
        public Tävlingslista()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tävling_id", typeof(string));
            dt.Columns.Add("namn", typeof(string));
            dt.Columns.Add("kön", typeof(string));
            dt.Columns.Add("maxDeltagare", typeof(string));
            dt.Columns.Add("anmäldadeltagare", typeof(string));
            dt.Columns.Add("könsfördelning", typeof(string));
            dt.Columns.Add("tävlingsdatum", typeof(string));
            dt.Columns.Add("sistaAnmälan", typeof(string));

            String sql = "SELECT    \"tävling\".\"tävling_id\",    \"tävling\".namn,    \"tävling\".\"sistaAnmälan\",    \"tävling\".\"maxDeltagare\",   (SELECT COUNT(\"golf_id\") FROM \"tävling_medlem\" WHERE \"tävling_medlem\".\"tävling_id\" = \"tävling\".\"tävling_id\") AS anmäldaDeltagare, (SELECT COUNT(\"kön_id\") FROM \"tävling_medlem\", \"medlem\" WHERE \"tävling_medlem\".\"tävling_id\" = \"tävling\".\"tävling_id\" AND \"tävling_medlem\".\"golf_id\" = medlem.golf_id AND medlem.kön_id = 0) AS män, (SELECT COUNT(\"kön_id\") FROM \"tävling_medlem\", \"medlem\" WHERE \"tävling_medlem\".\"tävling_id\" = \"tävling\".\"tävling_id\" AND \"tävling_medlem\".\"golf_id\" = medlem.golf_id AND medlem.kön_id = 1) AS kvinnor, (SELECT \"namn\" FROM \"tävling_kön\", \"kön\" WHERE \"tävling\".\"tävling_id\" = \"tävling_kön\".\"tävling_id\" AND \"kön\".\"kön_id\" = \"tävling_kön\".\"kön_id\" LIMIT 1) AS kön,   (SELECT \"datumtid\" FROM \"bokning\" WHERE \"tävling\".\"tävling_id\" = \"bokning\".\"tävling_id\" LIMIT 1) AS tävlingsdatum FROM    public.\"tävling\";";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow row = dt.NewRow();
                String könsfördelning = "";
                if (!System.DBNull.Value.Equals(ndr["män"]))
                {
                    if (!ndr["män"].ToString().Equals("0"))
                    {
                        könsfördelning = könsfördelning + "Män: " + ndr["män"].ToString() + " "; 
                    }
                }
                if (!System.DBNull.Value.Equals(ndr["kvinnor"]))
                {
                    if (!ndr["kvinnor"].ToString().Equals("0"))
                    {
                        könsfördelning = könsfördelning + "Damer: " + ndr["kvinnor"].ToString();
                    }
                }
                row["tävling_id"] = ndr["tävling_id"].ToString();
                row["namn"] = ndr["namn"].ToString();
                row["kön"] = ndr["kön"].ToString();
                row["maxDeltagare"] = ndr["maxDeltagare"].ToString();
                row["anmäldadeltagare"] = ndr["anmäldadeltagare"].ToString();
                row["könsfördelning"] = könsfördelning;
                row["tävlingsdatum"] = ndr["tävlingsdatum"].ToString();
                row["sistaAnmälan"] = ndr["sistaAnmälan"].ToString();

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

        private void reg_button_Click(object sender, EventArgs e)
        {
            RegistreraTavling registreratavling = new RegistreraTavling();
            registreratavling.ShowDialog();
            UpdateTable();
        }

        private void anm_button_Click(object sender, EventArgs e)
        {
            AnmälDeltagare ad = new AnmälDeltagare(GetTävling_id());
            ad.ShowDialog();
            UpdateTable();
        }

        private int GetTävling_id()
        {
            return int.Parse(dataGridView["tävling_id", dataGridView.CurrentRow.Index].Value.ToString());
        }

        private void res_button_Click(object sender, EventArgs e)
        {
            SeResultat sr = new SeResultat(GetTävling_id());
            sr.ShowDialog();
        }

        private void lag_button_Click(object sender, EventArgs e)
        {
            Lag l = new Lag(GetTävling_id());
            l.ShowDialog();
        }

        private void rem_button_Click(object sender, EventArgs e)
        {
            int tävling_id = GetTävling_id();
            String sql = "DELETE FROM lag WHERE \"tävling_id\" = " + tävling_id + "; DELETE FROM \"tävling_medlem\" WHERE \"tävling_id\" = " + tävling_id + "; DELETE FROM klass WHERE \"tävling_id\" = " + tävling_id + "; DELETE FROM bokning WHERE \"tävling_id\" = " + tävling_id + "; DELETE FROM \"tävling_kön\" WHERE \"tävling_id\" = " + tävling_id + "; DELETE FROM \"tävling\" WHERE \"tävling_id\" = " + tävling_id + ";";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();
            ndr.Read();
            ndr.Close();
            UpdateTable();
        }
    }
}

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
    public partial class Lag : Form
    {
        private int tävling_id;

        public Lag(int tävling_id)
        {
            this.tävling_id = tävling_id;
            InitializeComponent();
            UpdateTid();
            //UpdateMembers();
        }

        private void UpdateMembers()
        { 
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("golf_id", typeof(string));
            dt.Columns.Add("förnamn", typeof(string));
            dt.Columns.Add("efternamn", typeof(string));

            String sql = "SELECT    \"tävling_medlem\".\"tävling_id\",    medlem.golf_id,    medlem.\"förnamn\",    medlem.efternamn FROM    public.\"tävling_medlem\",    public.medlem WHERE    \"tävling_medlem\".golf_id = medlem.golf_id AND   \"tävling_medlem\".\"tävling_id\" = '" + tävling_id.ToString() + "';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow row = dt.NewRow();
                row["golf_id"] = ndr["golf_id"].ToString();
                row["förnamn"] = ndr["förnamn"].ToString();
                row["efternamn"] = ndr["efternamn"].ToString();
                dt.Rows.Add(row);
            }
            ndr.Close();

            DataView dv = new DataView(dt);

            //Set the component data
            noTeam_dataGridView.DataSource = dv;

            tid_dataGridView.Columns[0].HeaderText = "Golf-ID";
            tid_dataGridView.Columns[1].HeaderText = "Förnamn";
            tid_dataGridView.Columns[2].HeaderText = "Efternamn";
        }

        private void UpdateTid()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tid", typeof(string));
            dt.Columns.Add("lag_id", typeof(string));
            dt.Columns.Add("spelare_1", typeof(string));
            dt.Columns.Add("spelare_2", typeof(string));
            dt.Columns.Add("spelare_3", typeof(string));
            dt.Columns.Add("spelare_4", typeof(string));
            dt.Columns.Add("använd", typeof(bool));

            String sql = "SELECT \"bokning\".\"bokning_id\", \"bokning\".\"tävling_id\", datumtid, lag_id, \"lag\".spelare_1, \"lag\".spelare_2, \"lag\".spelare_3, \"lag\".spelare_4 FROM \"bokning\" LEFT JOIN \"lag\" ON (\"bokning\".\"bokning_id\" = \"lag\".\"bokning_id\") WHERE \"bokning\".\"tävling_id\" = " + tävling_id + ";";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                //dr["golfId"] = ndr["Golf-ID"];
                DateTime dateTime = (DateTime)ndr["datumtid"];
                DataRow row = dt.NewRow();
                DateTime datumtid = (DateTime) ndr["datumtid"];
                row["tid"] = datumtid.Hour.ToString().PadLeft(2, '0') + ":" + datumtid.Minute.ToString().PadLeft(2, '0');
                row["lag_id"] = ndr["lag_id"];
                row["spelare_1"] = ndr["spelare_1"];
                row["spelare_2"] = ndr["spelare_2"];
                row["spelare_3"] = ndr["spelare_3"];
                row["spelare_4"] = ndr["spelare_4"];
                row["använd"] = ndr["lag_id"].ToString().Length > 0;
                dt.Rows.Add(row);
            }
            ndr.Close();

            //Återställ time_comboBox selectedIndex
            //time_comboBox.SelectedIndex = time_index;

            //dt.Columns.RemoveAt(3);

            DataView dv = new DataView(dt);

            //Set the component data
            tid_dataGridView.DataSource = dv;

            //Set column header text
            tid_dataGridView.Columns[0].HeaderText = "Tid";
            tid_dataGridView.Columns[1].HeaderText = "Lag";
            tid_dataGridView.Columns[2].HeaderText = "Spelare 1";
            tid_dataGridView.Columns[3].HeaderText = "Spelare 2";
            tid_dataGridView.Columns[4].HeaderText = "Spelare 3";
            tid_dataGridView.Columns[5].HeaderText = "Spelare 4";
            tid_dataGridView.Columns[6].HeaderText = "Använd";

            //Färglägg rader
            foreach (DataGridViewRow row in tid_dataGridView.Rows)
            {
                String[] playerLines = new String[4];
                playerLines[0] = "spelare_1";
                playerLines[1] = "spelare_2";
                playerLines[2] = "spelare_3";
                playerLines[3] = "spelare_4";
                foreach (String s in playerLines)
                {
                    if (row.Cells[s].Value.ToString().Length > 1)
                    {
                        row.DefaultCellStyle.BackColor = Color.PowderBlue;
                    }
                }

                //String[] redlines = new String[2];
                //redlines[0] = "använd";
                //foreach (String s in redlines)
                //{
                //    if (row.Cells[s].Value.ToString().Length > 1)
                //    {
                //        if ((bool)row.Cells[s].Value)
                //        {
                //            row.DefaultCellStyle.BackColor = Color.Pink;
                //        }
                //    }
                //}
            }
        }
    }
}

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
            //Hämta klasser
            /*
             * Object klass
             * 0: Klassnamn
             * 1: Startvärde
             * 2: Slutvärde
             */
            List<object[]> klass = new List<object[]>();

            String sql = "SELECT    klass.klassnamn,    klass.\"startvärde\",    klass.\"slutvärde\" FROM    public.klass WHERE    klass.\"tävling_id\" = " + tävling_id + ";";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();
            while (ndr.Read())
            {
                object[] o = new object[3];

                o[0] = (string) ndr["klassnamn"];
                o[1] = (decimal) ndr["startvärde"];
                o[2] = (decimal) ndr["slutvärde"];

                klass.Add(o);
            }
            ndr.Close();

            //Create the empty table data
            DataTable dt = new DataTable("Table");
            if (singel_radioButton.Checked)
            {
                dt.Columns.Add("tävling_id", typeof(string));
                dt.Columns.Add("golf_id", typeof(string));
                dt.Columns.Add("namn", typeof(string));
                dt.Columns.Add("kön", typeof(string));
                dt.Columns.Add("klass", typeof(string));
                dt.Columns.Add("resultat", typeof(string));

                sql = "SELECT    \"tävling_medlem\".\"tävling_id\", \"tävling_medlem\".\"golf_id\", medlem.handicap,\"tävling_medlem\".resultat,    (medlem.\"förnamn\" || ' ' || medlem.efternamn) as namn, (SELECT namn FROM \"kön\" WHERE medlem.\"kön_id\" = \"kön\".\"kön_id\") as kön FROM    public.\"tävling_medlem\",    public.medlem WHERE    \"tävling_medlem\".golf_id = medlem.golf_id AND   \"tävling_medlem\".\"tävling_id\" = " + tävling_id + ";";
                command = new NpgsqlCommand(sql, GolfReception.conn);
                ndr = command.ExecuteReader();

                while (ndr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["tävling_id"] = ndr["tävling_id"].ToString();
                    row["golf_id"] = ndr["golf_id"].ToString();
                    row["namn"] = ndr["namn"].ToString();
                    row["kön"] = ndr["kön"].ToString();
                    row["resultat"] = ndr["resultat"].ToString();
                    row["klass"] = "";

                    foreach (object[] o in klass)
                    {
                        decimal h = (decimal) ndr["handicap"];
                        decimal start = (decimal) o[1];
                        decimal slut = (decimal) o[2];
                        if (h > start && h <= slut)
                        {
                            row["klass"] = o[0].ToString();
                        }
                    }


                    dt.Rows.Add(row);
                }
                ndr.Close();
            }
            else
            {
                dt.Columns.Add("lag_id", typeof(string));
                dt.Columns.Add("resultat", typeof(string));
                dt.Columns.Add("spelare_1", typeof(string));
                dt.Columns.Add("spelare_2", typeof(string));
                dt.Columns.Add("spelare_3", typeof(string));
                dt.Columns.Add("spelare_4", typeof(string));

                sql = "SELECT    \"lag\".\"tävling_id\",   lag.lag_id,   lag.resultat,   (SELECT (förnamn || ' ' || efternamn) FROM medlem WHERE medlem.golf_id = lag.spelare_1) AS spelare_1,   (SELECT (förnamn || ' ' || efternamn) FROM medlem WHERE medlem.golf_id = lag.spelare_2) AS spelare_2,   (SELECT (förnamn || ' ' || efternamn) FROM medlem WHERE medlem.golf_id = lag.spelare_3) AS spelare_3,   (SELECT (förnamn || ' ' || efternamn) FROM medlem WHERE medlem.golf_id = lag.spelare_4) AS spelare_4 FROM    public.lag WHERE    lag.\"tävling_id\" = "+tävling_id+";";
                command = new NpgsqlCommand(sql, GolfReception.conn);
                ndr = command.ExecuteReader();

                while (ndr.Read())
                {
                    DataRow row = dt.NewRow();
                    row["lag_id"] = ndr["lag_id"].ToString();
                    row["resultat"] = ndr["resultat"].ToString();
                    row["spelare_1"] = ndr["spelare_1"].ToString();
                    row["spelare_2"] = ndr["spelare_2"].ToString();
                    row["spelare_3"] = ndr["spelare_3"].ToString();
                    row["spelare_4"] = ndr["spelare_4"].ToString();

                    dt.Rows.Add(row);
                }
                ndr.Close();
            }

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

        private void singel_radioButton_CheckedChanged(object sender, EventArgs e)
        {
            UpdateTable();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            res_textBox.Text = dataGridView["resultat", dataGridView.CurrentRow.Index].Value.ToString();
        }

        private void save_button_Click(object sender, EventArgs e)
        {
            string sql = "";
            if (singel_radioButton.Checked)
            {
                sql = "UPDATE \"tävling_medlem\" SET(resultat) = (" + int.Parse(res_textBox.Text) + ") WHERE \"tävling_medlem\".\"tävling_id\" = " + tävling_id + " AND \"tävling_medlem\".\"golf_id\" = '" + dataGridView["golf_id", dataGridView.CurrentRow.Index].Value.ToString() + "';";
            }
            else
            {
                sql = "UPDATE \"lag\" SET(resultat) = (" + int.Parse(res_textBox.Text) + ") WHERE lag.lag_id = " + dataGridView["lag_id", dataGridView.CurrentRow.Index].Value.ToString() + ";";
            }
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);

            command.ExecuteNonQuery();
            UpdateTable();
        }
    }
}

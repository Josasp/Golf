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
            UpdateAll();
        }

        private void UpdateAll()
        {
            UpdateTid();
            UpdateNoTeam();
            UpdateLag();
            UpdateInTeam();
        }

        private void UpdateLag()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tid", typeof(string));
            dt.Columns.Add("lag_id", typeof(string));
            dt.Columns.Add("spelare_1", typeof(string));
            dt.Columns.Add("spelare_2", typeof(string));
            dt.Columns.Add("spelare_3", typeof(string));
            dt.Columns.Add("spelare_4", typeof(string));

            String sql = "SELECT    lag.\"tävling_id\",    lag.lag_id,    lag.spelare_1,    lag.spelare_2,    lag.spelare_3,    lag.spelare_4,    lag.bokning_id,    bokning.datumtid FROM    public.lag,    public.bokning WHERE    lag.bokning_id = bokning.bokning_id AND lag.\"tävling_id\" = '" + tävling_id.ToString() + "' ORDER BY datumtid ASC;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow row = dt.NewRow();
                DateTime datumtid = (DateTime) ndr["datumtid"];
                row["tid"] = datumtid.Hour.ToString().PadLeft(2, '0') + ":" + datumtid.Minute.ToString().PadLeft(2, '0');
                row["lag_id"] = ndr["lag_id"];
                row["spelare_1"] = ndr["spelare_1"];
                row["spelare_2"] = ndr["spelare_2"];
                row["spelare_3"] = ndr["spelare_3"];
                row["spelare_4"] = ndr["spelare_4"];
                dt.Rows.Add(row);
            }
            ndr.Close();

            DataView dv = new DataView(dt);

            //Set the component data
            lag_dataGridView.DataSource = dv;

            lag_dataGridView.Columns[0].HeaderText = "Tid";
            lag_dataGridView.Columns[1].HeaderText = "Lag";
            lag_dataGridView.Columns[2].HeaderText = "Spelare 1";
            lag_dataGridView.Columns[3].HeaderText = "Spelare 2";
            lag_dataGridView.Columns[4].HeaderText = "Spelare 3";
            lag_dataGridView.Columns[5].HeaderText = "Spelare 4";
        }

        private void UpdateNoTeam()
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

            //Ta bort de som är med i ett lag
            for (int i = 0; i < tid_dataGridView.RowCount; i++)
            {
                //Lista med de som ska tas bort
                LinkedList<DataRow> removeList = new LinkedList<DataRow>();

                //För varje lag
                foreach (DataRow row in dt.Rows)
                {
                    String s1 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_1", i].Value))
                    {
                        s1 = (String)tid_dataGridView["spelare_1", i].Value;
                    }

                    String s2 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_2", i].Value))
                    {
                        s1 = (String)tid_dataGridView["spelare_2", i].Value;
                    }

                    String s3 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_3", i].Value))
                    {
                        s3 = (String)tid_dataGridView["spelare_3", i].Value;
                    }

                    String s4 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_4", i].Value))
                    {
                        s4 = (String)tid_dataGridView["spelare_4", i].Value;
                    }

                    //Om spelaren finns med i laget
                    if (
                        row["golf_id"].ToString().Equals(s1) ||
                        row["golf_id"].ToString().Equals(s2) ||
                        row["golf_id"].ToString().Equals(s3) ||
                        row["golf_id"].ToString().Equals(s4))
                    {
                        //Lägg till på borttagningslistan
                        removeList.AddLast(row);
                    }
                }

                //Ta bort alla i borttagninslistan från tabellen
                foreach (DataRow row in removeList)
	            {
		            dt.Rows.Remove(row);
	            }
            }

            DataView dv = new DataView(dt);

            //Set the component data
            noTeam_dataGridView.DataSource = dv;

            noTeam_dataGridView.Columns[0].HeaderText = "Golf-ID";
            noTeam_dataGridView.Columns[1].HeaderText = "Förnamn";
            noTeam_dataGridView.Columns[2].HeaderText = "Efternamn";


        }

        private void UpdateInTeam()
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

            //Lista med de som ska tas bort
            LinkedList<DataRow> removeList = new LinkedList<DataRow>();
            foreach (DataRow row in dt.Rows)
            {
                bool hasTeam = false;
                for (int i = 0; i < tid_dataGridView.RowCount; i++)
                {
                    String s1 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_1", i].Value))
                    {
                        s1 = (String)tid_dataGridView["spelare_1", i].Value;
                    }

                    String s2 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_2", i].Value))
                    {
                        s2 = (String)tid_dataGridView["spelare_2", i].Value;
                    }

                    String s3 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_3", i].Value))
                    {
                        s3 = (String)tid_dataGridView["spelare_3", i].Value;
                    }

                    String s4 = "";
                    if (!System.DBNull.Value.Equals(tid_dataGridView["spelare_4", i].Value))
                    {
                        s4 = (String)tid_dataGridView["spelare_4", i].Value;
                    }

                    if (
                        s1.Equals(row["golf_id"]) ||
                        s2.Equals(row["golf_id"]) ||
                        s3.Equals(row["golf_id"]) ||
                        s4.Equals(row["golf_id"])
                        )
                    {
                        hasTeam = true;
                    }
                }

                if (hasTeam == false)
                {
                    removeList.AddLast(row);
                }
            }

            //Ta bort alla i borttagninslistan från tabellen
            foreach (DataRow row in removeList)
            {
                dt.Rows.Remove(row);
            }

            DataView dv = new DataView(dt);

            //Set the component data
            inTeam_dataGridView.DataSource = dv;

            inTeam_dataGridView.Columns[0].HeaderText = "Golf-ID";
            inTeam_dataGridView.Columns[1].HeaderText = "Förnamn";
            inTeam_dataGridView.Columns[2].HeaderText = "Efternamn";
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

            String sql = "SELECT \"bokning\".\"bokning_id\", \"bokning\".\"tävling_id\", datumtid, lag_id, \"lag\".spelare_1, \"lag\".spelare_2, \"lag\".spelare_3, \"lag\".spelare_4 FROM \"bokning\" LEFT JOIN \"lag\" ON (\"bokning\".\"bokning_id\" = \"lag\".\"bokning_id\") WHERE \"bokning\".\"tävling_id\" = " + tävling_id + " ORDER BY datumtid ASC;";
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
                //String[] playerLines = new String[4];
                //playerLines[0] = "spelare_1";
                //playerLines[1] = "spelare_2";
                //playerLines[2] = "spelare_3";
                //playerLines[3] = "spelare_4";
                //foreach (String s in playerLines)
                //{
                //    if (row.Cells[s].Value.ToString().Length > 1)
                //    {
                //        row.DefaultCellStyle.BackColor = Color.PowderBlue;
                //    }
                //}

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

                Boolean använd = (bool) row.Cells["använd"].Value;
                if (använd == false)
                {
                    row.DefaultCellStyle.BackColor = Color.Pink;
                }
            }

            tid_dataGridView.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* [0] lag_id
             * [1] spelare_1
             * [2] spelare_2
             * [3] spelare_3
             * [4] spelare_4
             */
            //LinkedList<string[]> lag = new LinkedList<string[]>();

            ////Hämta lag
            //for (int i = 0; i < lag_dataGridView.Rows.Count; i++)
            //{

            //    String[] l = {"", "", "", "", ""};

            //    if (!System.DBNull.Value.Equals(lag_dataGridView["lag_id", i].Value))
            //    {
            //        l[0] = (String)lag_dataGridView["lag_id", i].Value;
            //    }

            //    if (!System.DBNull.Value.Equals(lag_dataGridView["spelare_1", i].Value))
            //    {
            //        l[1] = (String)lag_dataGridView["spelare_1", i].Value;
            //    }

            //    if (!System.DBNull.Value.Equals(lag_dataGridView["spelare_2", i].Value))
            //    {
            //        l[2] = (String)lag_dataGridView["spelare_2", i].Value;
            //    }

            //    if (!System.DBNull.Value.Equals(lag_dataGridView["spelare_3", i].Value))
            //    {
            //        l[3] = (String)lag_dataGridView["spelare_3", i].Value;
            //    }

            //    if (!System.DBNull.Value.Equals(lag_dataGridView["spelare_4", i].Value))
            //    {
            //        l[4] = (String)lag_dataGridView["spelare_4", i].Value;
            //    }

            //    lag.AddLast(l);
            //}

            List<string> spelare = new List<string>();
            for (int i = 0; i < noTeam_dataGridView.Rows.Count; i++)
            {
                if (noTeam_dataGridView["golf_id", i].Selected)
                {
                    spelare.Add((String)noTeam_dataGridView["golf_id", i].Value); 
                }
            }

            Random ran = new Random();
            int count = spelare.Count;

            List<List<string>> team = new List<List<string>>();

            while (count > 1)
            {
                count = count - 1;
                int next = ran.Next(count + 1);
                string s = spelare[next];
                spelare[next] = spelare[count];
                spelare[count] = s;
            }

            List<string> row = new List<string>();
            foreach (string s in spelare)
            {
                row.Add(s);
                if (row.Count > 3)
                {
                    team.Add(row);
                    row = new List<string>();
                }
            }
            team.Add(row);


            for (int r = 0; r < team.Count; r++)
            {
                String sql = "INSERT INTO lag (\"tävling_id\", \"bokning_id\") VALUES (" + tävling_id + ", " + GetNextFreeTime() + "); SELECT CURRVAL(pg_get_serial_sequence('\"lag\"','lag_id'))";
                NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
                NpgsqlDataReader ndr = command.ExecuteReader();
                ndr.Read();
                int lag_id = Convert.ToInt32(ndr["currval"]);
                ndr.Close();
                for (int c = 0; c < team[r].Count; c++)
                {
                    sql = "UPDATE lag SET (spelare_" + (c+1) +") = ('" + team[r][c] + "') WHERE lag_id = " + lag_id + ";";
                    command = new NpgsqlCommand(sql, GolfReception.conn);
                    ndr = command.ExecuteReader();
                    ndr.Read();
                    ndr.Close();
                    UpdateAll();
                }
            }

        }

        private int GetNextFreeTime()
        {
            String sql = "SELECT \"bokning\".\"bokning_id\", \"bokning\".\"tävling_id\", datumtid, lag_id, \"lag\".spelare_1, \"lag\".spelare_2, \"lag\".spelare_3, \"lag\".spelare_4 FROM \"bokning\" LEFT JOIN \"lag\" ON (\"bokning\".\"bokning_id\" = \"lag\".\"bokning_id\") WHERE \"bokning\".\"tävling_id\" = " + tävling_id + " AND lag_id IS NULL ORDER BY datumtid ASC LIMIT 1;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();
            ndr.Read();
            int value = (int)ndr["bokning_id"];
            ndr.Close();
            return value;
        }

        private void all_button_Click(object sender, EventArgs e)
        {
            noTeam_dataGridView.SelectAll();
        }
    }
}

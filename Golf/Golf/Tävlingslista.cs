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
        }

        private void UpdateTable()
        {
            ////Create the empty table data
            //DataTable dt = new DataTable("Table");
            //dt.Columns.Add("tid", typeof(string));
            //dt.Columns.Add("spelare_1", typeof(string));
            //dt.Columns.Add("spelare_2", typeof(string));
            //dt.Columns.Add("spelare_3", typeof(string));
            //dt.Columns.Add("spelare_4", typeof(string));
            //dt.Columns.Add("tävling", typeof(bool));
            //dt.Columns.Add("övrigtUpptagen", typeof(bool));

            String sql = "SELECT    \"tävling\".\"tävling_id\",    \"tävling\".namn,    \"tävling\".\"sistaAnmälan\",    \"tävling\".\"maxDeltagare\",   (SELECT COUNT(\"golf_id\") FROM \"tävling_medlem\" WHERE \"tävling_medlem\".\"tävling_id\" = \"tävling\".\"tävling_id\") AS anmäldaDeltagare,   (SELECT \"namn\" FROM \"tävling_kön\", \"kön\" WHERE \"tävling\".\"tävling_id\" = \"tävling_kön\".\"tävling_id\" AND \"kön\".\"kön_id\" = \"tävling_kön\".\"kön_id\" LIMIT 1) AS kön,   (SELECT \"datumtid\" FROM \"bokning\" WHERE \"tävling\".\"tävling_id\" = \"bokning\".\"tävling_id\" LIMIT 1) AS tävlingsdatum FROM    public.\"tävling\";";
            //NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            //NpgsqlDataReader ndr = command.ExecuteReader();

            //while (ndr.Read())
            //{
            //    //dr["golfId"] = ndr["Golf-ID"];
            //    DateTime dateTime = (DateTime)ndr["datumtid"];
            //    String filter = "tid = '" + dateTime.Hour.ToString().PadLeft(2, '0') + ":" + dateTime.Minute.ToString().PadLeft(2, '0') + "'";
            //    DataRow[] row = dt.Select(filter);
            //    if (row.Length > 0)
            //    {
            //        row[0]["spelare_1"] = ndr["spelare_1"];
            //        row[0]["spelare_2"] = ndr["spelare_2"];
            //        row[0]["spelare_3"] = ndr["spelare_3"];
            //        row[0]["spelare_4"] = ndr["spelare_4"];
            //        row[0]["tävling"] = ndr["tävling_id"].ToString().Length > 0;
            //        row[0]["övrigtUpptagen"] = ndr["notering"].ToString().Length > 0;
            //    }
            //}
            //ndr.Close();

            ////Set the component data
            //dataGridView.DataSource = dv;

            ////Set column header text
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

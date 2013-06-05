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
    public partial class BookingWindow : Form
    {
        public BookingWindow()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tid", typeof(string));
            dt.Columns.Add("spelare_1", typeof(string));
            dt.Columns.Add("spelare_2", typeof(string));
            dt.Columns.Add("spelare_3", typeof(string));
            dt.Columns.Add("spelare_4", typeof(double));
            dt.Columns.Add("tävling", typeof(bool));
            dt.Columns.Add("övrigtUpptagen", typeof(bool));

            int openTime = 8;
            int closeTime = 16;

            for (int h = openTime; h < closeTime; h++)
            {
                for (int m = 0; m < 6; m++)
                {
                    DataRow dr = dt.NewRow();
                    dr["tid"] = h.ToString().PadLeft(2, '0') + ':' + m.ToString().PadRight(2, '0');
                    dt.Rows.Add(dr);
                }
            }

            //NpgsqlCommand command = new NpgsqlCommand("SELECT    \"Medlem\".\"Golf-ID\",    \"Medlem\".\"Förnamn\",    \"Medlem\".\"Efternamn\",    \"Status\".\"Namn\" AS Status,    \"Medlem\".\"BetalatÅr\",    \"Medlem\".\"Handicap\" FROM    public.\"Medlem\",    public.\"Status\" WHERE    \"Medlem\".\"Status_id\" = \"Status\".\"Status_id\";", dbConnection);
            //NpgsqlDataReader ndr = command.ExecuteReader();

            //while (ndr.Read())
            //{
            //    DataRow dr = dt.NewRow();
            //    dr["golfId"] = ndr["Golf-ID"];
            //    dr["firstName"] = ndr["Förnamn"];
            //    dr["lastName"] = ndr["Efternamn"];
            //    dr["membership"] = ndr["Status"];
            //    dr["handicap"] = ndr["Handicap"];
            //    dr["paid"] = (2013 == (int)ndr["BetalatÅr"]);
            //    dt.Rows.Add(dr);
            //}
            //ndr.Close();

            //dt.Columns.RemoveAt(3);

            DataView dv = new DataView(dt);
            //TODO Fix this filter, only golfId working
            //dv.RowFilter = "golfId LIKE '" + golfId_textBox.Text + "*' AND firstName LIKE '" + firstName_textBox.Text + "*' AND lastName LIKE '" + lastName_textBox.Text + "*'";

            //Set the component data
            dataGridView.DataSource = dv;

            //Set column header text
            dataGridView.Columns[0].HeaderText = "Tid";
            dataGridView.Columns[1].HeaderText = "Spelare 1";
            dataGridView.Columns[2].HeaderText = "Spelare 2";
            dataGridView.Columns[3].HeaderText = "Spelare 3";
            dataGridView.Columns[4].HeaderText = "Spelare 4";
            dataGridView.Columns[5].HeaderText = "Tävling";
            dataGridView.Columns[6].HeaderText = "Upptagen";
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            var bf = new BookingForm();
            bf.Date = monthCalendar.SelectionStart;
            bf.ShowDialog();
        }
    }
}

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
        private String filter = "";

        public BookingWindow()
        {
            InitializeComponent();
            UpdateTable();
        }

        private void UpdateTable()
        {
            //Remeber index
            int selIndex = -1;
            if (dataGridView.SelectedRows.Count > 0)
            {
                selIndex = dataGridView.SelectedRows[0].Index; 
            }

            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tid", typeof(string));
            dt.Columns.Add("spelare_1", typeof(string));
            dt.Columns.Add("spelare_2", typeof(string));
            dt.Columns.Add("spelare_3", typeof(string));
            dt.Columns.Add("spelare_4", typeof(string));
            dt.Columns.Add("tävling", typeof(bool));
            dt.Columns.Add("övrigtUpptagen", typeof(bool));

            //Öppettider
            int openTime = 8;
            int closeTime = 18;

            //Spara vald index från time_comboBox
            //int time_index = time_comboBox.SelectedIndex;

            //Fyll alla tider i tabellen
            for (int h = openTime; h < closeTime; h++)
            {
                for (int m = 0; m < 6; m++)
                {
                    //Ny rad
                    DataRow dr = dt.NewRow();
                    
                    //Skapa tider
                    String hour = h.ToString().PadLeft(2, '0');
                    String minute = m.ToString().PadRight(2, '0');
                    String tid = hour + ':' + minute;
                    dr["tid"] = tid;

                    dt.Rows.Add(dr);
                }
            }

            //Hämta datum
            DateTime datum = new DateTime(
                monthCalendar.SelectionStart.Year,
                monthCalendar.SelectionStart.Month,
                monthCalendar.SelectionStart.Day,
                0,
                0,
                0);

            String sql = "SELECT * FROM \"bokning\" WHERE datumtid::text LIKE '" + datum.Year.ToString() + "-" + datum.Month.ToString().PadLeft(2, '0') + "-" + datum.Day.ToString().PadLeft(2, '0') + "%';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                //dr["golfId"] = ndr["Golf-ID"];
                DateTime dateTime = (DateTime) ndr["datumtid"];
                String filter = "tid = '" + dateTime.Hour.ToString().PadLeft(2, '0') + ":" + dateTime.Minute.ToString().PadLeft(2, '0') + "'";
                DataRow[] row = dt.Select(filter);
                if (row.Length > 0)
                {
                    row[0]["spelare_1"] = ndr["spelare_1"];
                    row[0]["spelare_2"] = ndr["spelare_2"];
                    row[0]["spelare_3"] = ndr["spelare_3"];
                    row[0]["spelare_4"] = ndr["spelare_4"];
                    row[0]["tävling"] = ndr["tävling_id"].ToString().Length > 0;
                    row[0]["övrigtUpptagen"] = ndr["notering"].ToString().Length > 0;
                }
            }
            ndr.Close();
        
            //Återställ time_comboBox selectedIndex
            //time_comboBox.SelectedIndex = time_index;

            //dt.Columns.RemoveAt(3);

            DataView dv = new DataView(dt);
            dv.RowFilter = this.filter;

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

            //Färglägg rader
            foreach (DataGridViewRow row in dataGridView.Rows)
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

                String[] redlines = new String[2];
                redlines[0] = "tävling";
                redlines[1] = "övrigtUpptagen";
                foreach (String s in redlines)
                {
                    if (row.Cells[s].Value.ToString().Length > 1)
                    {
                        if ((bool)row.Cells[s].Value)
                        {
                            row.DefaultCellStyle.BackColor = Color.Pink;
                        }
                    } 
                }
            }

            //Restore index
            if (selIndex > 0)
            {
                dataGridView.Rows[0].Selected = false; 
                dataGridView.Rows[selIndex].Selected = true; 
            }
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            var bf = new BookingForm();
            bf.Date = monthCalendar.SelectionStart;
            bf.Time = (String)dataGridView["tid", dataGridView.CurrentRow.Index].Value;
            var data = dataGridView["spelare_1", dataGridView.CurrentRow.Index].Value;
            if (!System.DBNull.Value.Equals(data))
            {
                bf.Player_1 = (String)data; 
            }
            data = dataGridView["spelare_2", dataGridView.CurrentRow.Index].Value;
            if (!System.DBNull.Value.Equals(data))
            {
                bf.Player_2 = (String)data;
            }
            data = dataGridView["spelare_3", dataGridView.CurrentRow.Index].Value;
            if (!System.DBNull.Value.Equals(data))
            {
                bf.Player_3 = (String)data;
            }
            data = dataGridView["spelare_4", dataGridView.CurrentRow.Index].Value;
            if (!System.DBNull.Value.Equals(data))
            {
                bf.Player_4 = (String)data;
            }
            bf.ShowDialog();
            UpdateTable();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            UpdateTable();
        }

        private void players_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FilterChanged();
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            FilterChanged();
        }

        private void FilterChanged()
        {
            DateTime datum = new DateTime(
                monthCalendar.SelectionStart.Year,
                monthCalendar.SelectionStart.Month,
                monthCalendar.SelectionStart.Day,
                int.Parse(dataGridView["tid", dataGridView.CurrentRow.Index].Value.ToString().Substring(0, 2)),
                int.Parse(dataGridView["tid", dataGridView.CurrentRow.Index].Value.ToString().Substring(3, 2)),
                0);

            //Clear bolded dates
            monthCalendar.RemoveAllBoldedDates();

            String sql = "SELECT bokning.bokning_id, bokning.datumtid, bokning.spelare_1, bokning.spelare_2, bokning.spelare_3, bokning.spelare_4, bokning.tävling_id, bokning.notering  FROM public.bokning WHERE datumtid::TEXT LIKE '%" + datum.Hour.ToString().PadLeft(2, '0') + ":" + datum.Minute.ToString().PadLeft(2, '0') + ":00';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();
            LinkedList<DateTime> upptagnaDatum = new LinkedList<DateTime>();
            int spelare = players_comboBox.SelectedIndex > 0 ? players_comboBox.SelectedIndex + 1 : 1;
            while (ndr.Read())
            {
                int lediga = 0;
                if (ndr["tävling_id"].ToString().Length > 0 && ndr["notering"].ToString().Length > 0)
                {
                    if (ndr["spelare_1"].ToString().Equals(""))
                    {
                        lediga++;
                    }
                    if (ndr["spelare_2"].ToString().Equals(""))
                    {
                        lediga++;
                    }
                    if (ndr["spelare_3"].ToString().Equals(""))
                    {
                        lediga++;
                    }
                    if (ndr["spelare_4"].ToString().Equals(""))
                    {
                        lediga++;
                    } 
                }
                if (lediga < spelare)
                {
                    upptagnaDatum.AddLast((DateTime)ndr["datumtid"]);
                }
            }

            int ahead = 180;
            //Set bolded dates
            DateTime d = datum;
            for (int i = 0; i < ahead; i++)
            {
                monthCalendar.AddBoldedDate(d);
                d = d.AddDays(1);
            }

            //Remove not free
            foreach (DateTime ud in upptagnaDatum)
            {
                monthCalendar.RemoveBoldedDate(ud);
            }

            monthCalendar.UpdateBoldedDates();
            ndr.Close();
        }
    }
}

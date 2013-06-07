using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class BookingForm : Form
    {
        public DateTime Date
        {
            get { return monthCalendar.SelectionStart; }
            set 
            { 
                monthCalendar.SetDate(value);
                DateChanged();
            }
        }

        public String Player_1
        {
            set
            {
                player1_findPlayer.GolfId = value;
            }
        }

        public String Player_2
        {
            set
            {
                player2_findPlayer.GolfId = value;
            }
        }

        public String Player_3
        {
            set
            {
                player3_findPlayer.GolfId = value;
            }
        }

        public String Player_4
        {
            set
            {
                player4_findPlayer.GolfId = value;
            }
        }

        public String Time
        {
            get { return time_comboBox.Items[time_comboBox.SelectedIndex].ToString(); }
            set
            {
                for (int i = 0; i < time_comboBox.Items.Count; i++)
                {
                    if (time_comboBox.Items[i].ToString().Equals(value))
                    {
                        time_comboBox.SelectedIndex = i;
                    }
                }
            }
        }

        public BookingForm()
        {
            InitializeComponent();
        }


        private void player3_findPlayer_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_Enter(object sender, EventArgs e)
        {

        }

        private void date_textBox_Enter(object sender, EventArgs e)
        {
            monthCalendar.Visible = true;
        }

        private void date_textBox_Leave(object sender, EventArgs e)
        {
            monthCalendar.Visible = false;
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            string spelare_1 = player1_findPlayer.GolfId.Length == 10 ? player1_findPlayer.GolfId : null;
            string spelare_2 = player2_findPlayer.GolfId.Length == 10 ? player2_findPlayer.GolfId : null;
            string spelare_3 = player3_findPlayer.GolfId.Length == 10 ? player3_findPlayer.GolfId : null;
            string spelare_4 = player4_findPlayer.GolfId.Length == 10 ? player4_findPlayer.GolfId : null;

            DateTime datumtid = monthCalendar.SelectionStart;
            TimeSpan ts = new TimeSpan(int.Parse(time_comboBox.Text.Substring(0, 2)), int.Parse(time_comboBox.Text.Substring(3, 2)), 0);
            datumtid = datumtid.Date + ts;

            String sql = "SELECT 1 FROM bokning WHERE datumtid = :date;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            command.Parameters.Add(new NpgsqlParameter("date", DbType.DateTime));
            command.Prepare();
            command.Parameters[0].Value = datumtid;
            NpgsqlDataReader ndr = command.ExecuteReader();
            bool update = ndr.Read();
            if (update)
            {
                sql = "UPDATE bokning SET (spelare_1, spelare_2, spelare_3, spelare_4) = (:spelare_1, :spelare_2, :spelare_3, :spelare_4) WHERE \"datumtid\" = '" + datumtid.ToString(CultureInfo.CreateSpecificCulture("sv-SE")) + "' ;";
            }
            else
            {
                sql = "INSERT INTO bokning (spelare_1, spelare_2, spelare_3, spelare_4, datumtid) VALUES (:spelare_1, :spelare_2, :spelare_3, :spelare_4, :date);";
            }
            ndr.Close();

            command = new NpgsqlCommand(sql, GolfReception.conn);
            command.Parameters.Add(new NpgsqlParameter("spelare_1", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("spelare_2", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("spelare_3", DbType.String));
            command.Parameters.Add(new NpgsqlParameter("spelare_4", DbType.String));
            if (!update)
            {
                command.Parameters.Add(new NpgsqlParameter("date", DbType.DateTime)); 
            }
            command.Prepare();
            command.Parameters[0].Value = spelare_1;
            command.Parameters[1].Value = spelare_2;
            command.Parameters[2].Value = spelare_3;
            command.Parameters[3].Value = spelare_4;
            if (!update)
            {
                command.Parameters[4].Value = datumtid; 
            }
            command.ExecuteNonQuery();

            this.Close();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            DateChanged();
        }

        private void DateChanged()
        {
            date_textBox.Text = monthCalendar.SelectionStart.ToLongDateString();
            monthCalendar.Visible = false;
        }

        private void time_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}

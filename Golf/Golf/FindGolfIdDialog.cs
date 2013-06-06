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
    public partial class FindGolfIdDialog : Form
    {
        private TextBox tb;

        public FindGolfIdDialog(ref TextBox tb)
        {
            this.tb = tb;
            InitializeComponent();
            golfId_textBox.Text = this.tb.Text;
            UpdateTable();
        }

        private void UpdateTable()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("GolfID", typeof(string));
            dt.Columns.Add("Förnamn", typeof(string));
            dt.Columns.Add("Efternamn", typeof(string));

            String sql = "SELECT golf_id, förnamn, efternamn FROM medlem;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow row = dt.NewRow();
                row["GolfID"] = ndr["golf_id"];
                row["Förnamn"] = ndr["förnamn"];
                row["Efternamn"] = ndr["efternamn"];
                dt.Rows.Add(row);
            }
            ndr.Close();

            DataView dv = new DataView(dt);
            //TODO Fix this filter, only golfId working
            dv.RowFilter = "GolfID LIKE '" + golfId_textBox.Text + "*' AND Förnamn LIKE '" + firstName_textBox.Text + "*' AND Efternamn LIKE '" + lastName_textBox.Text + "*'";

            //Set the component data
            dataGridView.DataSource = dv;

            //Set column header text
            dataGridView.Columns[0].HeaderText = "Golf-ID";
            dataGridView.Columns[1].HeaderText = "Förnamn";
            dataGridView.Columns[2].HeaderText = "Efternamn";
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            //TODO Replace with golfId fron dataGridView
            this.tb.Text = (string)dataGridView.SelectedRows[0].Cells[0].Value;
            this.Close();
        }

        private void golfId_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            UpdateTable();
        }
    }
}

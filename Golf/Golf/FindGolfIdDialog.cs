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
            /*DataTable dt = MainWindow.GetMemberTable();
            dt.Columns.RemoveAt(3);
            dt.Columns.RemoveAt(3);
            dt.Columns.RemoveAt(3);

            DataView dv = new DataView(dt);
            //TODO Fix this filter, only golfId working
            dv.RowFilter = "golfId LIKE '" + golfId_textBox.Text + "*' AND firstName LIKE '" + firstName_textBox.Text + "*' AND lastName LIKE '" + lastName_textBox.Text + "*'";

            //Set the component data
            dataGridView.DataSource = dv;

            //Set column header text
            dataGridView.Columns[0].HeaderText = "Golf-ID";
            dataGridView.Columns[1].HeaderText = "Förnamn";
            dataGridView.Columns[2].HeaderText = "Efternamn";*/
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

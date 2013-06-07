using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace Golf
{
    public partial class FindPlayerComponent : UserControl
    {
        [Description("Title of the control"), Category("Apperance")]
        public string TitleText
        {
            get { return groupBox.Text; }
            set { groupBox.Text = value; }
        }

        [Description("GolfId in this control"), Category("Data")]
        public string GolfId
        {
            get { return golfId_textBox.Text; }
            set { golfId_textBox.Text = value; update(); }
        }

        /**
         * This is a custom component for finding players based on Golf-ID
         */
        public FindPlayerComponent()
        {
            InitializeComponent();
        }

        /**
         * Updates the data fields based on golfId_textBox.text
         */
        private void update()
        {
            if (golfId_textBox.Text.Length == 10)
            {
                String sql = "SELECT medlem.\"förnamn\", medlem.efternamn, \"kön\".namn AS kön, medlem.golf_id, medlem.handicap FROM public.medlem, public.\"kön\" WHERE medlem.\"kön_id\" = \"kön\".\"kön_id\" AND medlem.golf_id = '" + golfId_textBox.Text + "';";
                NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
                NpgsqlDataReader ndr = command.ExecuteReader();
                ndr.Read();

                name_textBox.Text = ndr["förnamn"] + " " + ndr["efternamn"];
                gender_textBox.Text = (string)ndr["kön"];
                handicap_textBox.Text = ndr["handicap"].ToString();

                DateTime resultDate;
                DateTime.TryParse(ndr["golf_id"].ToString().Substring(2, 2) + "/" + ndr["golf_id"].ToString().Substring(2, 2) + "/" + ndr["golf_id"].ToString().Substring(0, 2), out resultDate);

                DateTime today = DateTime.Today;
                int age = today.Year - resultDate.Year;
                if (resultDate > today.AddYears(-age)) age--;

                age_textBox.Text = age.ToString();

                ndr.Close(); 
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            var fgd = new FindGolfIdDialog(ref golfId_textBox);
            fgd.ShowDialog();
        }

        private void golfId_textBox_TextChanged(object sender, EventArgs e)
        {
            update();
        }

        private void golfId_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            update();
        }
    }
}

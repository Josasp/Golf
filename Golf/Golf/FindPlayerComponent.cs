using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class FindPlayerComponent : UserControl
    {
        private Member m;

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
            set { golfId_textBox.Text = value; findMember(); }
        }

        public Member Member
        {
            get { return m; }
            set { m = value; update(); }
        }

        /**
         * This is a custom component for finding players based on Golf-ID
         */
        public FindPlayerComponent()
        {
            InitializeComponent();
        }

        /**
         * Find the member object with that golfId
         */
        private void findMember()
        { 
            //Code for getting a Member object with that golfId
            //this.m = MemberlistWindow.FindMember(GolfId);
            update();
        }

        /**
         * Updates the data fields based on golfId_textBox.text
         */
        private void update()
        {
            //TODO Fixa det här, ingenting händer
            //If m is empty, no member set
            if (m != null)
            {
                DateTime dt = DateTime.Now;
                name_textBox.Text = m.FirstName + " " + m.LastName;
                gender_textBox.Text = m.Gender;
                if (m.GolfId.Length > 1)
                {
                    int year = System.Threading.Thread.CurrentThread.CurrentCulture.Calendar.ToFourDigitYear(int.Parse(m.GolfId.Substring(0, 2)));
                    age_textBox.Text = (dt.Year - year).ToString();
                }
                handicap_textBox.Text = m.Handicap; 
            }
        }

        private void find_button_Click(object sender, EventArgs e)
        {
            var fgd = new FindGolfIdDialog(ref golfId_textBox);
            fgd.ShowDialog();
        }

        private void golfId_textBox_TextChanged(object sender, EventArgs e)
        {
            findMember();
        }

        private void golfId_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            findMember();
        }
    }
}

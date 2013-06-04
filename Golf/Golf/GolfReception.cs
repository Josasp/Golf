using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql; 

namespace Golf
{
    public partial class GolfReception : Form
    {
        public static NpgsqlConnection conn;

        public GolfReception()
        {
            InitializeComponent();
            Connect();
        }

        private static void Connect()
        {
            conn = new NpgsqlConnection("Server=webblabb.miun.se;Port=5432;Database=grp6vt13;User Id=grp6vt13;Password=gOMMObmEP;SSL=true");
            conn.Open();
        }

        private void läggTillSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LaggTillspelare laggtillspelare = new LaggTillspelare();
            laggtillspelare.ShowDialog();
        }

        private void seAllaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeAlla sealla = new SeAlla();
            sealla.ShowDialog();
        }

        private void sökSpelareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SokSpelare sokspelare = new SokSpelare();
            sokspelare.ShowDialog();
        }

        private void registreraTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraTavling registreratavling = new RegistreraTavling();
            registreratavling.ShowDialog();
        }

        private void sökTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SokTavling soktavling = new SokTavling();
            soktavling.ShowDialog();
        }

        private void golfreception_Load(object sender, EventArgs e)
        {
            // Bara lite test... 

            listView1.View = View.SmallIcon; // SmallIcon / LargeIcon
            //listView1.CheckBoxes = true;

            string[] tid = { "08:00", "08:10", "08:20", "08:30", "08:40", "08.50", "09:00", "09:10", "09:20" }; //osv. 

            int raknare = 0; 

            while (raknare < 9) 
            {
                // if tid finns i databasen, lägg i item antal spelare bokade = prickar.
                listView1.Items.Add(tid[raknare]);

                raknare = raknare + 1; 
            }



            //Add the items to the ListView.
            /*ListViewItem item1 = new ListViewItem("item1", 0);
            ListViewItem item2 = new ListViewItem("item2", 0);
            ListViewItem item3 = new ListViewItem("item3", 0);
            listView1.Items.AddRange(new ListViewItem[] { item1, item2, item3 });*/

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}

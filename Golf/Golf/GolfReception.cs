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

        private void registreraTävlingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistreraTavling registreratavling = new RegistreraTavling();
            registreratavling.ShowDialog();
        }

        private void golfreception_Load(object sender, EventArgs e)
        {

        }

        private void medlemsregisterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SeAlla sealla = new SeAlla();
            sealla.ShowDialog();
        }

        private void tävlingsverksamhetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tävlingslista tl = new Tävlingslista();
            tl.ShowDialog();
        }

        private void tidsbokningToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BookingWindow bw = new BookingWindow();
            bw.ShowDialog();
        }
    }
}

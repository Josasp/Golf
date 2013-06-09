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
    public partial class SeAlla : Form
    {
        public SeAlla()
        {
            InitializeComponent();
            uppdateralista();
        }

        public void uppdateralista()
        {
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("golf_id", typeof(string));
            dt.Columns.Add("förnamn", typeof(string));
            dt.Columns.Add("efternamn", typeof(string));
            dt.Columns.Add("handicap", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("betaltÅr", typeof(string));
            dt.Columns.Add("adress", typeof(string));
            dt.Columns.Add("stad", typeof(string));
            dt.Columns.Add("telefonnummer", typeof(string));
            dt.Columns.Add("epost", typeof(string));

            String sql = "select    medlem.golf_id,     medlem.\"förnamn\",     medlem.efternamn,   medlem.handicap,    status.namn,   medlem.\"betaltÅr\",      medlem.adress,      medlem.stad,    medlem.postnummer,      medlem.telefonnummer,    medlem.epost    from    medlem, status    where   medlem.status_id = status.status_id;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader drv = command.ExecuteReader();

            while (drv.Read())
            {
                DataRow row = dt.NewRow();
                row["golf_id"] = drv["golf_id"].ToString();
                row["förnamn"] = drv["förnamn"].ToString();
                row["efternamn"] = drv["efternamn"].ToString();
                row["handicap"] = drv["handicap"].ToString();
                row["status"] = drv["namn"].ToString();
                row["betaltÅr"] = drv["betaltÅr"].ToString();
                row["adress"] = drv["adress"].ToString();
                row["stad"] = drv["stad"].ToString();
                row["telefonnummer"] = drv["telefonnummer"].ToString();
                row["epost"] = drv["epost"].ToString();

                dt.Rows.Add(row);
            }
            drv.Close();

            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
        }



        private void ok_button_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = hamtaid(); 


            String sql2 = "delete from medlem where golf_id = '" + id + "';";
            NpgsqlCommand command4 = new NpgsqlCommand(sql2, GolfReception.conn);
            command4.ExecuteNonQuery();

            uppdateralista();

        }

        public string hamtaid()
        {
            int nummer = dataGridView1.CurrentRow.Index;

            String sql = "select golf_id from medlem;";
            NpgsqlCommand command3 = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader drg = command3.ExecuteReader();

            string idet = "";
            int raknare = 0;
            while (drg.Read())
            {
                if (raknare == nummer)
                {
                    idet = drg["golf_id"].ToString();
                }
                raknare = raknare + 1;
            }

            drg.Close();

            return idet; 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LaggTillspelare laggtillspelare = new LaggTillspelare();
            laggtillspelare.ShowDialog();

            uppdateralista(); 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string id = hamtaid(); 
            String sql3 = "select    medlem.golf_id,     medlem.\"förnamn\",     medlem.efternamn,   medlem.handicap,    status.namn,   medlem.\"betaltÅr\",      medlem.adress,      medlem.stad,    medlem.postnummer,      medlem.telefonnummer,    medlem.epost,   medlem.\"kön_id\"    from    medlem, status     where    medlem.status_id = status.status_id      and     medlem.golf_id ='" + id + "';";
            NpgsqlCommand command5 = new NpgsqlCommand(sql3, GolfReception.conn);
            NpgsqlDataReader drx = command5.ExecuteReader();

            while (drx.Read())
            {
                golfid_textBox.Text = drx["golf_id"].ToString();
                fornamn_textBox.Text = drx["förnamn"].ToString();
                efternamn_textBox.Text = drx["efternamn"].ToString();
                handicap_textBox.Text = drx["handicap"].ToString();
                betalt_textBox.Text = drx["betaltÅr"].ToString();
                adress_textBox.Text = drx["adress"].ToString();
                postnummer_textBox.Text = drx["postnummer"].ToString();
                postort_textBox.Text = drx["stad"].ToString();
                telefonnummer_textBox.Text = drx["telefonnummer"].ToString();
                epost_textBox.Text = drx["epost"].ToString();
                medlemsstatus_comboBox.Text = drx["namn"].ToString();

                if (drx["kön_id"].ToString() == "0")
                {
                    kon_comboBox.Text = "Man"; 
                }
                else if (drx["kön_id"].ToString() == "1")
                {
                    kon_comboBox.Text = "Kvinna"; 
                }
                    
            }
            drx.Close();


            groupBox1.Visible = true; 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int kon = 0;

            if (kon_comboBox.Text == "Kvinna")
            {
                kon = 1;
            }
            else if (kon_comboBox.Text == "Man")
            {
                kon = 0;
            }

            int status = 1;

            if (medlemsstatus_comboBox.Text == "Aktiv")
            {
                status = 1;
            }
            else if (medlemsstatus_comboBox.Text == "Vilande")
            {
                status = 2;
            }
            else if (medlemsstatus_comboBox.Text == "Greenfee")
            {
                status = 3;
            }
            else if (medlemsstatus_comboBox.Text == "Junior")
            {
                status = 4;
            }
            else if (medlemsstatus_comboBox.Text == "Ickemedlem")
            {
                status = 5;
            }

            string updateramedlem = "update medlem set   \"förnamn\" ='" + fornamn_textBox.Text + "', efternamn = '" + efternamn_textBox.Text + "', \"kön_id\" = " + kon + ", adress = '" + adress_textBox.Text + "', postnummer = " + postnummer_textBox.Text + ", stad = '" + postort_textBox.Text + "', telefonnummer = '" + telefonnummer_textBox.Text + "', epost = '" + epost_textBox.Text + "', handicap = " + handicap_textBox.Text + ", status_id = " + status + ", betaltÅr = " + betalt_textBox.Text + " where golf_id ='" + golfid_textBox.Text + "';";
            NpgsqlCommand command_medlem2 = new NpgsqlCommand(updateramedlem, GolfReception.conn);
            command_medlem2.ExecuteNonQuery();

            MessageBox.Show("Spelare ändrad."); 
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string id = textBox1.Text; 

            DataTable dt = new DataTable("Table");
            dt.Columns.Add("golf_id", typeof(string));
            dt.Columns.Add("förnamn", typeof(string));
            dt.Columns.Add("efternamn", typeof(string));
            dt.Columns.Add("handicap", typeof(string));
            dt.Columns.Add("status", typeof(string));
            dt.Columns.Add("betaltÅr", typeof(string));
            dt.Columns.Add("adress", typeof(string));
            dt.Columns.Add("stad", typeof(string));
            dt.Columns.Add("telefonnummer", typeof(string));
            dt.Columns.Add("epost", typeof(string));

            String sql = "select    medlem.golf_id,     medlem.\"förnamn\",     medlem.efternamn,   medlem.handicap,    status.namn,   medlem.\"betaltÅr\",      medlem.adress,      medlem.stad,    medlem.postnummer,      medlem.telefonnummer,    medlem.epost    from    medlem, status    where   medlem.status_id = status.status_id and medlem.golf_id ='" + id + "';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader drv = command.ExecuteReader();

            while (drv.Read())
            {
                DataRow row = dt.NewRow();
                row["golf_id"] = drv["golf_id"].ToString();
                row["förnamn"] = drv["förnamn"].ToString();
                row["efternamn"] = drv["efternamn"].ToString();
                row["handicap"] = drv["handicap"].ToString();
                row["status"] = drv["namn"].ToString();
                row["betaltÅr"] = drv["betaltÅr"].ToString();
                row["adress"] = drv["adress"].ToString();
                row["stad"] = drv["stad"].ToString();
                row["telefonnummer"] = drv["telefonnummer"].ToString();
                row["epost"] = drv["epost"].ToString();

                dt.Rows.Add(row);
            }
            drv.Close();

            DataView dv = new DataView(dt);
            dataGridView1.DataSource = dv;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            uppdateralista(); 
        }


    }
}

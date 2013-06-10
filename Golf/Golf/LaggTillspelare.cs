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
using System.Text.RegularExpressions;

namespace Golf
{
    public partial class LaggTillspelare : Form
    {
        public LaggTillspelare()
        {
            InitializeComponent();
            medlemsstatus_comboBox.SelectedIndex = 0;
            kon_comboBox.SelectedIndex = 0;
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            if (validateAll())
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

                string inimedlem = "insert into medlem (golf_id, \"förnamn\", efternamn, \"kön_id\", adress, postnummer, stad, telefonnummer, epost, handicap, status_id, \"betaltÅr\") values('" + golfid_textBox.Text + "-" + golfid2_textBox.Text + "', '" + fornamn_textBox.Text + "', '" + efternamn_textBox.Text + "', " + kon + ", '" + adress_textBox.Text + "', " + postnummer_textBox.Text + ", '" + postort_textBox.Text + "', '" + telefonnummer_textBox.Text + "', '" + epost_textBox.Text + "', " + handicap_textBox.Text + ", " + status + ", " + betalt_textBox.Text + ");";
                NpgsqlCommand command_medlem = new NpgsqlCommand(inimedlem, GolfReception.conn);
                command_medlem.ExecuteNonQuery();

                MessageBox.Show("Spelare tillagd.");
                this.Close(); 
            }
        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void medlemsstatus_comboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void golfid_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            golfid2_textBox.Text = GetGolfIDSerial(golfid_textBox.Text);
            validateAll();
        }

        private bool validateAll()
        {
            Color invalid = Color.Pink;
            Color valid = Color.LightGreen;

            bool value = true;

            if (golfid_textBox.Text.Length != 6)
            {
                golfid_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                golfid_textBox.BackColor = valid;
            }

            double d;
            if ((double.TryParse(handicap_textBox.Text, out d) && handicap_textBox.Text.Length > 0) == false)
            {
                handicap_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                handicap_textBox.BackColor = valid;
            }

            if (fornamn_textBox.Text.Length < 2)
            {
                fornamn_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                fornamn_textBox.BackColor = valid;
            }

            if (efternamn_textBox.Text.Length < 2)
            {
                efternamn_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                efternamn_textBox.BackColor = valid;
            }

            if (adress_textBox.Text.Length < 2)
            {
                adress_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                adress_textBox.BackColor = valid;
            }

            Match postnummer = Regex.Match(postnummer_textBox.Text, "^[0-9]+");
            if (!postnummer.Success)
            {
                postnummer_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                postnummer_textBox.BackColor = valid;
            }

            if (postort_textBox.Text.Length < 2)
            {
                postort_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                postort_textBox.BackColor = valid;
            }

            Match telenr = Regex.Match(telefonnummer_textBox.Text, "^[0-9]{5,}");
            if (!telenr.Success)
            {
                telefonnummer_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                telefonnummer_textBox.BackColor = valid;
            }

            if (epost_textBox.Text.Length < 4)
            {
                epost_textBox.BackColor = invalid;
                value = false;
            }
            else
            {
                epost_textBox.BackColor = valid;
            }

            if (betalt_textBox.Text.Length == 1 || betalt_textBox.Text.Length == 4)
            {
                betalt_textBox.BackColor = valid;
            }
            else
            {
                betalt_textBox.BackColor = invalid;
                value = false;
            }

            return value;
        }

        private String GetGolfIDSerial(String date)
        {
            Match match = Regex.Match(date, "^[0-9]{2}[0-9]{2}[0-9]{2}$");
            if (match.Success)
            {
                String sql = "SELECT \"golf_id\" FROM public.\"medlem\" WHERE \"golf_id\" ~ '^" + date + "+';";
                NpgsqlCommand Command = new NpgsqlCommand(sql, GolfReception.conn);
                NpgsqlDataReader result = Command.ExecuteReader();
                int value = 0;
                while (result.Read())
                {
                    String s = result.GetString(result.GetOrdinal("golf_id"));
                    int foo;
                    foo = int.Parse(s.Substring(7, 3));
                    if (foo > value)
                    {
                        value = foo;
                    }
                }
                value++;
                return value.ToString().PadLeft(3, '0');
            }
            else return "";
        }

        private void handicap_textBox_KeyUp(object sender, KeyEventArgs e)
        {
            validateAll();
        }
    }
}

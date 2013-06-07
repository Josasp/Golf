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
    public partial class SeAnmaldaSpelare : Form
    {
        public SeAnmaldaSpelare()
        {
            InitializeComponent();
        }

        private void SeAnmaldaSpelare_Load(object sender, EventArgs e)
        {

        }

        private void cancel_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void action_button_Click(object sender, EventArgs e)
        {
            if (alla_checkBox.Checked == true)
            {
                //NpgsqlCommand command_deltagare_alla = new NpgsqlCommand("SELECT \"tävling_medlem\".\"tävling_id\",\"tävling_medlem\".golf_id FROM public.\"tävling_medlem\" WHERE \"tävling_medlem\".\"tävling_id\" = '1'", GolfReception.conn);
                //NpgsqlDataReader alla = command_deltagare_alla.ExecuteReader();
                //while (alla.Read())
                // {
                //  listBox1.Items.Add(alla);
                // }
            }

            this.Close();
            }
            }

        }

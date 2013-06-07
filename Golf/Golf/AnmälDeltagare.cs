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
    public partial class AnmälDeltagare : Form
    {
        private int tävling_id;
        public AnmälDeltagare(int tävling_id)
        {
            this.tävling_id = tävling_id;
            InitializeComponent();
        }

        private void can_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void anm_button_Click(object sender, EventArgs e)
        {
            string sql = "INSERT INTO \"tävling_medlem\" (tävling_id, golf_id) VALUES (:tävling_id, :golf_id);";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            command.Parameters.Add(new NpgsqlParameter("tävling_id", DbType.Int32));
            command.Parameters.Add(new NpgsqlParameter("golf_id", DbType.String));

            command.Prepare();
            command.Parameters[0].Value = tävling_id;
            command.Parameters[1].Value = findPlayerComponent1.GolfId;

            command.ExecuteNonQuery();
            this.Close();
        }
    }
}

using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Golf
{
    public partial class BusyForm : Form
    {
        private DateTime datumtid;
        public BusyForm(DateTime datumtid)
        {
            this.datumtid = datumtid;
            InitializeComponent();
        }

        private void book_button_Click(object sender, EventArgs e)
        {
            String sql = "SELECT 1 FROM bokning WHERE datumtid = :date;";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            command.Parameters.Add(new NpgsqlParameter("date", DbType.DateTime));
            command.Prepare();
            command.Parameters[0].Value = datumtid;
            NpgsqlDataReader ndr = command.ExecuteReader();
            bool update = ndr.Read();
            if (update)
            {
                sql = "UPDATE bokning SET (notering) = (:notering) WHERE \"datumtid\" = '" + datumtid.ToString(CultureInfo.CreateSpecificCulture("sv-SE")) + "' ;";
            }
            else
            {
                sql = "INSERT INTO bokning (notering, datumtid) VALUES (:notering, :date);";
            }

            ndr.Close();

            command = new NpgsqlCommand(sql, GolfReception.conn);
            command.Parameters.Add(new NpgsqlParameter("notering", DbType.String));
            if (!update)
            {
                command.Parameters.Add(new NpgsqlParameter("date", DbType.DateTime));
            }
            command.Prepare();
            command.Parameters[0].Value = note_textBox.Text;
            if (!update)
            {
                command.Parameters[1].Value = datumtid;
            }
            command.ExecuteNonQuery();

            this.Close();
        }
    }
}

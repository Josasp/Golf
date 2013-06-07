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
    public partial class Lag : Form
    {
        private int tävling_id;

        public Lag(int tävling_id)
        {
            InitializeComponent();
        }

        private void UpdateMembers()
        { 
            //Create the empty table data
            DataTable dt = new DataTable("Table");
            dt.Columns.Add("tävling_id", typeof(string));
            dt.Columns.Add("golf_id", typeof(string));
            dt.Columns.Add("namn", typeof(string));
            dt.Columns.Add("resultat", typeof(string));

            String sql = "SELECT    \"tävling_medlem\".\"tävling_id\", \"tävling_medlem\".\"golf_id\",   \"tävling_medlem\".resultat,    (medlem.\"förnamn\" || ' ' || medlem.efternamn) as namn FROM    public.\"tävling_medlem\",    public.medlem WHERE    \"tävling_medlem\".golf_id = medlem.golf_id AND   \"tävling_medlem\".\"tävling_id\" = '" + tävling_id.ToString() + "';";
            NpgsqlCommand command = new NpgsqlCommand(sql, GolfReception.conn);
            NpgsqlDataReader ndr = command.ExecuteReader();

            while (ndr.Read())
            {
                DataRow row = dt.NewRow();
                row["tävling_id"] = ndr["tävling_id"].ToString();
                row["golf_id"] = ndr["golf_id"].ToString();
                row["namn"] = ndr["namn"].ToString();
                row["resultat"] = ndr["resultat"].ToString();

                dt.Rows.Add(row);
            }
            ndr.Close();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace Connection
{
    public partial class Form1 : Form
    {
        OracleConnection conn; 
        OracleCommand comm; 
        OracleDataAdapter da; 
        DataSet ds;
        DataTable dt; 
        DataRow dr; 
        int i = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1_Click();
            comm = new OracleCommand();
            comm.CommandText = "select regno from participated";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "participated");
            dt = ds.Tables["participated"];
            int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            comboBox1.DataSource = dt.DefaultView;
            comboBox1.DisplayMember = "regno";
            conn.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oradb = "Data Source=172.16.54.24:1524/ict031;User ID=it031;Password=student";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        
    }
}

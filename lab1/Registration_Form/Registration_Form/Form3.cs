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

namespace Registration_Form
{
    public partial class Form3 : Form
    {
        OracleConnection conn; 
        OracleCommand comm; 
        OracleDataAdapter da; 
        DataSet ds;
        DataTable dt; 
        DataRow dr; 
        int i = 0; 
        public Form3()
        {
            InitializeComponent();
        }

        void connect()
        {
            String oradb = "Data Source=172.16.54.24:1521/ictorcl;User ID=it031;Password=student";
            conn = new OracleConnection(oradb); // C# conn.Open();
        }

       
       

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            connect();
            comm = new OracleCommand();
            comm = new OracleCommand(); 
            comm.CommandText = "select * from PARTICIPATED";
            comm.CommandType = CommandType.Text;
            ds = new DataSet();
            da = new OracleDataAdapter(comm.CommandText, conn);
            da.Fill(ds, "PARTICIPATED");
            dt = ds.Tables["PARTICIPATED"]; int t = dt.Rows.Count;
            MessageBox.Show(t.ToString());
            dr = dt.Rows[i];
            textBox6.Text = dr["REGNO"].ToString();
            textBox7.Text = dr["REPORT_NUMBER"].ToString();
            textBox8.Text = dr["DAMAGE_AMOUNT"].ToString();
            conn.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            i++;
            if (i >= dt.Rows.Count) i = 0;
            dr = dt.Rows[i];
            textBox5.Text = dr["DRIVER_ID#"].ToString();
            textBox6.Text = dr["REGNO"].ToString();
            textBox7.Text = dr["REPORT_NUMBER"].ToString();
            textBox8.Text = dr["DAMAGE_AMOUNT"].ToString();
        }

        
    }
}

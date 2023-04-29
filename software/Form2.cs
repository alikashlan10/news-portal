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
namespace software
{
    public partial class Form2 : Form
    {
        string ordb = "Data Source=ORCL;User Id=admin;Password=admin;";
        OracleConnection dbconn;

        private OracleDataAdapter adapter;
        private DataSet ds = new DataSet();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
           
                string connection = "Data Source=ORCL;User Id=admin;Password=admin;";

                string allnews = " select username ,password, f_name, l_name, followers_cnt from jornalist";
                adapter = new OracleDataAdapter(allnews, connection);
                
                adapter.Fill(ds);
                dg.DataSource = ds.Tables[0];

        }

        private void button2_Click(object sender, EventArgs e)
        {

            OracleCommandBuilder b = new OracleCommandBuilder(adapter);
            adapter.Update(ds.Tables[0]);
            MessageBox.Show("Updated succesfully !");
        }
    }
}

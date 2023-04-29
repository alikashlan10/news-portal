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
    public partial class Form1 : Form
    {
        string ordb = "Data Source=ORCL;User Id=admin;Password=admin;";
        OracleConnection dbconn;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //dbconn = new OracleConnection(ordb);
            //dbconn.Open();
            //OracleCommand cmd = new OracleCommand();
            //cmd.Connection = dbconn;
            //cmd.CommandText = "select ACTORID from ACTORS";
            //OracleDataReader dr = cmd.ExecuteReader();
            //while (dr.Read())
            //{
            //    comboBox4.Items.Add(dr[0]);
            //}
            //dr.Close();
        }
      



        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            dbconn.Dispose();
        }

        private void Form1_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            dbconn.Dispose();
        }

        private void register_Click(object sender, EventArgs e)
        {
            dbconn = new OracleConnection(ordb);
            OracleCommand cmd = new OracleCommand();
            cmd.Connection = dbconn;
            dbconn.Open();
            bool taken=false;
            cmd.CommandText = "SELECT * FROM reader WHERE username =: un";
            cmd.Parameters.Add("un", usernameTB.Text.ToString());
            OracleDataReader dr = cmd.ExecuteReader();
            //int count =(int) cmd.ExecuteScalar();
            while (dr.Read())
            {
                taken = true;
            }
            dr.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM JORNALIST WHERE username =: un";
            cmd.Parameters.Add("un", usernameTB.Text.ToString());
            OracleDataReader drr = cmd.ExecuteReader();
            //int count =(int) cmd.ExecuteScalar();
            while (drr.Read())
            {
                taken = true;
            }
            drr.Close();
            cmd.Parameters.Clear();
            cmd.CommandText = "SELECT * FROM moderator WHERE username =: un";
            cmd.Parameters.Add("un", usernameTB.Text.ToString());
            OracleDataReader drrr = cmd.ExecuteReader();
            //int count =(int) cmd.ExecuteScalar();
            while (drrr.Read())
            {
                taken = true;
            }
            drrr.Close();
            cmd.Parameters.Clear();
            if (taken==true)
            {
                MessageBox.Show("username is taken!!");
            }
            else
            {
                cmd.CommandText = "insert into reader (username,password,f_name,l_name,age,gender) values(:username ,:password ,:firstname , :lastname ,:age ,:gender)";               
                cmd.Parameters.Add("username",usernameTB.Text.ToString());
                cmd.Parameters.Add("password", passwordTB.Text.ToString());
                cmd.Parameters.Add("firstname", firstnameTB.Text.ToString());
                cmd.Parameters.Add("lastname", lastnameTB.Text.ToString());
                cmd.Parameters.Add("age", ageTB.Text.ToString());
                if (male.Checked)
                    cmd.Parameters.Add("gender", "m");
                else if (female.Checked)
                    cmd.Parameters.Add("gender", "f");
                cmd.ExecuteNonQuery();
                MessageBox.Show("you are now registered!");
                //then they go straight to their home page
                loginpanel.BringToFront();
            }
        }

        private void loginpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ageTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void firstnameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameTB_TextChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void loginlinkbtn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            loginpanel.BringToFront();
        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            bool reader = false, mod = false;

            dbconn = new OracleConnection(ordb);

            OracleCommand cmnd = new OracleCommand();
            cmnd.Connection = dbconn;
            dbconn.Open();
            cmnd.CommandText = "SELECT * FROM reader WHERE username =: un";
            cmnd.Parameters.Add("un", unloginTB.Text.ToString());
            OracleDataReader reader_dr = cmnd.ExecuteReader();

            OracleCommand cmnd2 = new OracleCommand();
            cmnd2.Connection = dbconn;
            cmnd2.CommandText = "SELECT * FROM MODERATOR WHERE username =: un";
            cmnd2.Parameters.Add("un", unloginTB.Text.ToString());
            OracleDataReader mod_dr = cmnd2.ExecuteReader();


           // dbconn.Open();

            if (reader_dr.Read())
                reader = true;

            if (mod_dr.Read())
                mod = true;

            if (reader == true)
            {
                string pass = passloginTB.Text.ToString();
                if (pass.Equals(reader_dr[2].ToString()))
                {
                    readermain.BringToFront();
                    readerfunctions(); 
                }
                else
                MessageBox.Show("password is wrong!");
            }
            else if (mod == true)
            {
                string pass2 = passloginTB.Text.ToString();
                if (pass2.Equals(mod_dr[2].ToString()))
                {
                    moderator.BringToFront();
                    Form2 modr = new Form2();
                    modr.Show();
                }
                else
                    MessageBox.Show("password is wrong!");
            }
            else if (reader==false && mod == false)
                MessageBox.Show("username doesnt exist!");

           

            reader_dr.Close();
            mod_dr.Close();


        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            searchpanel.BringToFront();
            string connection = "Data Source=ORCL;User Id=admin;Password=admin;";
            string search_cmd = "SELECT n.newsid, n.title, n.article " +
                               "FROM news n " +
                               "JOIN NEWS_keyword k ON n.newsid = k.newsid " +
                               "WHERE k.keyword =: keyword ";
            //OracleCommand searchcmnd = new OracleCommand();

            OracleDataAdapter adapter = new OracleDataAdapter(search_cmd, connection);
            adapter.SelectCommand.Parameters.Add("keyword" , serachbarTB.Text.ToString() );
            //DataTable dataTable = new DataTable();
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            foreach (DataRow r in ds.Tables[0].Rows)
            {
                Panel newsPanel = new Panel();
                newsPanel.BorderStyle = BorderStyle.None;
                newsPanel.BackColor = Color.AliceBlue ;
                newsPanel.Dock = DockStyle.Top;
                newsPanel.Margin = new Padding(10);
                // Create a PictureBox for the news image
                //PictureBox newsImage = new PictureBox();
                //newsImage.SizeMode = PictureBoxSizeMode.Zoom;
                //newsImage.Image = Image.FromFile(row["images"].ToString());
                //newsImage.Dock = DockStyle.Left;
                //newsImage.Width = 200;

                // Create a Label for the news title
                Label newsTitle = new Label();
                //newsTitle.Text = row.GetString(row.GetOrdinal("title"));
                newsTitle.Text = r["title"].ToString();
                newsTitle.Font = new Font("Arial", 12, FontStyle.Bold);
                newsTitle.Dock = DockStyle.Top;
                newsTitle.ForeColor = Color.White;
                newsTitle.Margin = new Padding(10);

                // Create a Label for the news article
                Label newsArticle = new Label();
                //newsArticle.Text = row.GetString(row.GetOrdinal("ARTICLE"));
                newsArticle.Text = r["article"].ToString();
                newsArticle.Dock = DockStyle.Fill;
                newsArticle.AutoSize = false;
                newsArticle.MaximumSize = new Size(0, 200);
                newsTitle.ForeColor = Color.White;

                // Add the controls to the newsPanel
                newsPanel.Controls.Add(newsArticle);
                newsPanel.Controls.Add(newsTitle);
                //newsPanel.Controls.Add(newsImage);

                // Add the newsPanel to the form or a container control
                searchpanel.Controls.Add(newsPanel);
                
            }
        }
        private void readerfunctions()
        {
            //////// loading news into reader main page
            ///------------------------------------------------------
            //dbconn = new OracleConnection(ordb);

            //retrieving news using stored procedure
            OracleCommand ncmnd = new OracleCommand();
            ncmnd.Connection = dbconn;
            //bconn.Open();
            ncmnd.CommandText = "getnews";
            ncmnd.CommandType = CommandType.StoredProcedure;
            //OracleParameter inputParam = new OracleParameter("getnews", OracleDbType.Varchar2);
            //inputParam.Value = "news";
            //inputParam.Direction = ParameterDirection.Input;
            //ncmnd.Parameters.Add(inputParam);
            OracleParameter outputParam = new OracleParameter("output_cursor", OracleDbType.RefCursor);
            outputParam.Direction = ParameterDirection.Output;
            ncmnd.Parameters.Add(outputParam);
            //ncmnd.ExecuteNonQuery();

            //putting news in a data table
            //OracleDataAdapter adapter = new OracleDataAdapter(ncmnd);
            //DataTable dataTable = new DataTable();
            //adapter.Fill(dataTable);











            OracleDataReader row = ncmnd.ExecuteReader();
            while (row.Read())
            {
                Panel newsPanel = new Panel();
                newsPanel.BorderStyle = BorderStyle.None;
                //newsPanel.BackColor = ;
                newsPanel.Dock = DockStyle.Top;
                newsPanel.Margin = new Padding(10);
                // Create a PictureBox for the news image
                //PictureBox newsImage = new PictureBox();
                //newsImage.SizeMode = PictureBoxSizeMode.Zoom;
                //newsImage.Image = Image.FromFile(row["images"].ToString());
                //newsImage.Dock = DockStyle.Left;
                //newsImage.Width = 200;

                // Create a Label for the news title
                Label newsTitle = new Label();
                //newsTitle.Text = row.GetString(row.GetOrdinal("title"));
                newsTitle.Text = row["title"].ToString();
                newsTitle.Font = new Font("Arial", 12, FontStyle.Bold);
                newsTitle.Dock = DockStyle.Top;
                newsTitle.BackColor = Color.AliceBlue;

                // Create a Label for the news article
                Label newsArticle = new Label();
                //newsArticle.Text = row.GetString(row.GetOrdinal("ARTICLE"));
                newsArticle.Text = row["article"].ToString();
                newsArticle.Dock = DockStyle.Fill;
                newsArticle.AutoSize = false;
                newsArticle.MaximumSize = new Size(0, 200);

                // Add the controls to the newsPanel
                newsPanel.Controls.Add(newsArticle);
                newsPanel.Controls.Add(newsTitle);
                //newsPanel.Controls.Add(newsImage);

                // Add the newsPanel to the form or a container control
                mainnewspanel.Controls.Add(newsPanel);
            }

            row.Close();

            ///showing news 
            ///


            readermain.BringToFront();
        }

     
    }
}

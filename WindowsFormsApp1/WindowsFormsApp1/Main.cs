using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        public Form1()
        {
            Thread splashThread = new Thread(new ThreadStart(AppStart));
            splashThread.Start();
            Thread.Sleep(5000);
            InitializeComponent();
            splashThread.Abort();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";
        }
        
        public void AppStart()
        {
            Application.Run(new SplashScreen());
        }

        private void txtPassword_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void txtUserEnter(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(@"Username"))
            {
                txtUsername.Text = "";
            }
        }

        private void txtUserLeave(object sender, EventArgs e)
        {
            if (txtUsername.Text.Equals(""))
            {
                txtUsername.Text = @"Username";
            }
        }

        private void txtPassEnter(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(@"Password"))
            {
                txtPassword.Text = "";
            }
        }

        private void txtPassLeave(object sender, EventArgs e)
        {
            if (txtPassword.Text.Equals(""))
            {
                txtPassword.Text = @"Password";
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlconn.Open();
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandText = "select * from Login";
            SqlDataReader sqlDataReader = sqlcmd.ExecuteReader();
            if (sqlDataReader.Read())
            {
                if (txtUsername.Text.Equals(sqlDataReader["username"].ToString())
                    && txtPassword.Text.Equals(sqlDataReader["password"].ToString()))
                {
                    MessageBox.Show("Login Success", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Login FAILED", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            sqlconn.Close();
        }
    }
}

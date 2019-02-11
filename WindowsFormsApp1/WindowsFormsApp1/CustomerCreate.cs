using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public partial class CustomerCreate : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        public CustomerCreate()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandType = CommandType.Text;
            // sqlcmd.CommandText = @"insert into Customer (Name, Email, Company, Discount) values ('" + @txtName.Text + "','" + @txtEmail.Text + "','" + @txtCompany + "','" + @txtDiscount + "')";
            sqlcmd.CommandText = "INSERT into Customer (Name, Email, Company, Discount) VALUES (@Name, @Email, @Company, @Discount)";
            sqlcmd.Parameters.AddWithValue("@Name", txtName.Text);
            sqlcmd.Parameters.AddWithValue("@Email", txtEmail.Text);
            sqlcmd.Parameters.AddWithValue("@Company", txtCompany.Text);
            sqlcmd.Parameters.AddWithValue("@Discount", txtDiscount.Text);
            
            try
            {
                sqlconn.Open();
                int recordsAffected = sqlcmd.ExecuteNonQuery();
                if (recordsAffected > 0)
                {
                    MessageBox.Show("New Customer Added", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Closed += (s, args) => this.Close();
                    mainMenu.Show();
                }
                
            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to create new customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlconn.Close();
            }
          
        }
    }
}

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
using System.Diagnostics;

namespace WindowsFormsApp1
{
    public partial class CustomerCreate : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        Boolean modify = false;
        String oldEmail = "";

        public CustomerCreate()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";

            if (!Customer.input.Equals("Enter Email ID"))
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "SELECT * FROM Customer WHERE Email = '" + Customer.input + "';";

                try
                {
                    sqlconn.Open();
                    using (SqlDataReader dr = sqlcmd.ExecuteReader())
                    {
                        //Loop through all the rows, retrieving the columns you need.
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                txtName.Text = dr["Name"].ToString();
                                txtEmail.Text = dr["Email"].ToString();
                                txtCompany.Text = dr["Company"].ToString();
                                txtDiscount.Text = dr["Discount"].ToString();
                                btnCreate.Text = "                 Modify";
                                modify = true;
                                oldEmail = Customer.input;

                            }
                        }
                        else
                        {

                        }
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to modify customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Customer.input = "Enter Email ID";
                    sqlconn.Close();
                }
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            if (!modify)
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
            } else
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "UPDATE Customer SET Name = @newName, Email = @newEmail, Company = @newCompany, Discount = @newDiscount WHERE Email = @newOldEmail";
                sqlcmd.Parameters.AddWithValue("@newName", txtName.Text);
                sqlcmd.Parameters.AddWithValue("@newEmail", txtEmail.Text);
                sqlcmd.Parameters.AddWithValue("@newCompany", txtCompany.Text);
                sqlcmd.Parameters.AddWithValue("@newDiscount", txtDiscount.Text);
                sqlcmd.Parameters.AddWithValue("@newOldEmail", oldEmail);

                try
                {
                    sqlconn.Open();
                    int recordsAffected = sqlcmd.ExecuteNonQuery();
                    if (recordsAffected > 0)
                    {
                        MessageBox.Show("Customer Details Modiied", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Closed += (s, args) => this.Close();
                        mainMenu.Show();
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to Modify Customer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
        }
    }
}

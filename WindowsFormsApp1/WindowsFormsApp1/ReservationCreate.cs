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
    public partial class ReservationCreate : Form
    {

        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        Boolean modify = false;
        String oldEmail = "";

        public ReservationCreate()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";

            if (!Reservation.input.Equals("Enter Email ID"))
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "SELECT * FROM Reservation WHERE Email = '" + Reservation.input + "';";

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

                                DateTime checkin = Convert.ToDateTime(dr["CheckIn"].ToString());
                                dpCheckIn.Value = new DateTime(checkin.Year, checkin.Month, checkin.Day);
                                DateTime checkout = Convert.ToDateTime(dr["CheckOut"].ToString());
                                dpCheckOut.Value = new DateTime(checkout.Year, checkout.Month, checkout.Day);
                                txtPrice.Text = dr["Price"].ToString();
                                txtRoom.Text = dr["Room"].ToString();
                                txtEmail.Text = dr["Email"].ToString();
                                btnReserve.Text = "                 Modify";
                                modify = true;
                                oldEmail = Reservation.input;

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
                    Reservation.input = "Enter Email ID";
                    sqlconn.Close();
                }
            }
        }

        private void dpCheckIn_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "INSERT into Reservation (CheckIn, CheckOut, Price, Room, Email) VALUES (@txtCheckIn, @txtCheckOut, @txtPrice, @txtRoom, @txtEmail)";
                sqlcmd.Parameters.AddWithValue("@txtCheckIn", dpCheckIn.Value.ToString("yyyy-MM-dd"));
                sqlcmd.Parameters.AddWithValue("@txtCheckOut", dpCheckOut.Value.ToString("yyyy-MM-dd"));
                sqlcmd.Parameters.AddWithValue("@txtPrice", txtPrice.Text);
                sqlcmd.Parameters.AddWithValue("@txtRoom", txtRoom.Text);
                sqlcmd.Parameters.AddWithValue("@txtEmail", txtEmail.Text);

                try
                {
                    sqlconn.Open();
                    int recordsAffected = sqlcmd.ExecuteNonQuery();
                    if (recordsAffected > 0)
                    {
                        MessageBox.Show("New Reservation Added", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Closed += (s, args) => this.Close();
                        mainMenu.Show();
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to create new reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();
                }
            } else
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "UPDATE Reservation SET CheckIn = @newCheckIn, CheckOut = @newCheckOut, Price = @newPrice, Room = @newRoom, Email = @newEmail WHERE Email = @newOldEmail";
                sqlcmd.Parameters.AddWithValue("@newCheckIn", dpCheckIn.Value.ToString("yyyy-MM-dd"));
                sqlcmd.Parameters.AddWithValue("@newCheckOut", dpCheckOut.Value.ToString("yyyy-MM-dd"));
                sqlcmd.Parameters.AddWithValue("@newPrice", txtPrice.Text);
                sqlcmd.Parameters.AddWithValue("@newRoom", txtRoom.Text);
                sqlcmd.Parameters.AddWithValue("@newEmail", txtEmail.Text);
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

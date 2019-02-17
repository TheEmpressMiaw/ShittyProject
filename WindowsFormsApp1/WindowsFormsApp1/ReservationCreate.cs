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

        public ReservationCreate()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";
        }

        private void dpCheckIn_onValueChanged(object sender, EventArgs e)
        {

        }

        private void btnReserve_Click(object sender, EventArgs e)
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
        }
    }
}

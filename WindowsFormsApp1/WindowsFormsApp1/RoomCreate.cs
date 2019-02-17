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
    public partial class RoomCreate : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        Boolean modify = false;
        String oldEmail = "";

        public RoomCreate()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";

            if (!Room.input.Equals("Enter Room No"))
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "SELECT * FROM Room WHERE RoomNo = '" + Room.input + "';";

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
                                txtRoomNo.Text = dr["RoomNo"].ToString();
                                txtFloor.Text = dr["Floor"].ToString();
                                txtCapacity.Text = dr["Capacity"].ToString();
                                txtPrice.Text = dr["Price"].ToString();
                                btnAddRoom.Text = "                 Modify";
                                modify = true;
                                oldEmail = Room.input;

                            }
                        }
                        else
                        {

                        }
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to modify Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    Room.input = "Enter Room No";
                    sqlconn.Close();
                }
            }
        }

        private void btnAddRoom_Click(object sender, EventArgs e)
        {
            if (!modify)
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "INSERT into Room (RoomNo, Floor, Capacity, Price) VALUES (@txtRoomNo, @txtFloor, @txtCapacity, @txtPrice)";
                sqlcmd.Parameters.AddWithValue("@txtRoomNo", txtRoomNo.Text);
                sqlcmd.Parameters.AddWithValue("@txtFloor", txtFloor.Text);
                sqlcmd.Parameters.AddWithValue("@txtCapacity", txtCapacity.Text);
                sqlcmd.Parameters.AddWithValue("@txtPrice", txtPrice.Text);

                try
                {
                    sqlconn.Open();
                    int recordsAffected = sqlcmd.ExecuteNonQuery();
                    if (recordsAffected > 0)
                    {
                        MessageBox.Show("New Room Added", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Closed += (s, args) => this.Close();
                        mainMenu.Show();
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to create new room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
            else
            {
                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "UPDATE Room SET RoomNo = @txtRoomNo, Floor = @txtFloor, Capacity = @txtCapacity, Price = @txtPrice WHERE RoomNo = @newOldRoomNo";
                sqlcmd.Parameters.AddWithValue("@txtRoomNo", txtRoomNo.Text);
                sqlcmd.Parameters.AddWithValue("@txtFloor", txtFloor.Text);
                sqlcmd.Parameters.AddWithValue("@txtCapacity", txtCapacity.Text);
                sqlcmd.Parameters.AddWithValue("@txtPrice", txtPrice.Text);
                sqlcmd.Parameters.AddWithValue("@newOldRoomNo", oldEmail);

                try
                {
                    sqlconn.Open();
                    int recordsAffected = sqlcmd.ExecuteNonQuery();
                    if (recordsAffected > 0)
                    {
                        MessageBox.Show("Room Details Modiied", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Hide();
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Closed += (s, args) => this.Close();
                        mainMenu.Show();
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to Modify Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();
                }
            }
        }
    }
}

﻿using System;
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
    public partial class Room : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        public static string input = "Enter Room No";

        public Room()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";
        }

        private void btnNewRoom_Click(object sender, EventArgs e)
        {
            RoomCreate roomCreate = new RoomCreate();
            this.Hide();
            roomCreate.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ShowInputDialog(ref input);
            RoomCreate roomCreate = new RoomCreate();
            this.Hide();
            roomCreate.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String email = "Room No";
            ShowInputDialog(ref email);
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "DELETE FROM Room WHERE RoomNo = @newEmail";
            sqlcmd.Parameters.AddWithValue("@newEmail", email);

            try
            {
                sqlconn.Open();
                int recordsAffected = sqlcmd.ExecuteNonQuery();
                if (recordsAffected > 0)
                {
                    MessageBox.Show("Room Deleted", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Closed += (s, args) => this.Close();
                    mainMenu.Show();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to Delete Room", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Room No";

            System.Windows.Forms.TextBox textBox = new TextBox();
            textBox.Size = new System.Drawing.Size(size.Width - 10, 23);
            textBox.Location = new System.Drawing.Point(5, 5);
            textBox.Text = input;
            inputBox.Controls.Add(textBox);

            Button okButton = new Button();
            okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            okButton.Name = "okButton";
            okButton.Size = new System.Drawing.Size(75, 23);
            okButton.Text = "&OK";
            okButton.Location = new System.Drawing.Point(size.Width - 80 - 80, 39);
            inputBox.Controls.Add(okButton);

            Button cancelButton = new Button();
            cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new System.Drawing.Size(75, 23);
            cancelButton.Text = "&Cancel";
            cancelButton.Location = new System.Drawing.Point(size.Width - 80, 39);
            inputBox.Controls.Add(cancelButton);

            inputBox.AcceptButton = okButton;
            inputBox.CancelButton = cancelButton;

            inputBox.StartPosition = FormStartPosition.CenterParent;

            DialogResult result = inputBox.ShowDialog();
            input = textBox.Text;
            return result;
        }
    }
}

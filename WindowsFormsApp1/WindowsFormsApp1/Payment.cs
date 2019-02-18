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
using System.Net.Mail;

namespace WindowsFormsApp1
{   public partial class Payment : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();
        
        String oldEmail = "";

        public Payment()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";
            
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "SELECT (Price * (SELECT  DATEDIFF(day, (SELECT CheckIn from Reservation where Email = '" + MainMenu.paymentEmail + "'), (SELECT CheckOut from Reservation where Email = '" + MainMenu.paymentEmail + "')))) as Total from Reservation where Email = '" + MainMenu.paymentEmail + "'";

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
                            txtTotal.Text = dr["Total"].ToString();
                            oldEmail = MainMenu.paymentEmail;
                        }
                    }
                    else
                    {

                    }
                }

                sqlcmd.CommandText = "SELECT (MAX(ID) + 1) as Invoice FROM Invoice";
                using (SqlDataReader dr = sqlcmd.ExecuteReader())
                {
                    //Loop through all the rows, retrieving the columns you need.
                    if (dr.HasRows)
                    {
                        while (dr.Read())
                        {
                            lbInvoiceNumber.Text = dr["Invoice"].ToString();
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
                MainMenu.paymentEmail = "Enter Email ID";
                sqlconn.Close();
            }

            lbDate.Text = DateTime.Now.ToString("yyyy/MM/dd");


        }

        private void Payment_Load(object sender, EventArgs e)
        {

        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            sqlcmd.CommandText = "INSERT into Invoice (PaymentDate, Type, Description, Total, Status) VALUES (@txtPaymentDate, @txtType, @txtDescription, @txtTotal, @txtStatus)";
            sqlcmd.Parameters.AddWithValue("@txtPaymentDate", lbDate.Text);
            sqlcmd.Parameters.AddWithValue("@txtType", ddType.Text);
            sqlcmd.Parameters.AddWithValue("@txtDescription", txtDesc.Text);
            sqlcmd.Parameters.AddWithValue("@txtTotal", txtTotal.Text);
            sqlcmd.Parameters.AddWithValue("@txtStatus", ddStatus.Text);

            try
            {
                sqlconn.Open();
                int recordsAffected = sqlcmd.ExecuteNonQuery();
                if (recordsAffected > 0)
                {
                    MessageBox.Show("DONE", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Closed += (s, args) => this.Close();
                    mainMenu.Show();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Error Creating New Invoice", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlconn.Close();
            }
            
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("htmangmt@gmail.com");
                mail.To.Add(oldEmail);
                mail.Subject = "Invoice";

                mail.IsBodyHtml = true;
                mail.Body = "<style type=\"text/css\">" +
".tg  {border-collapse:collapse;border-spacing:0;}" +
".tg td{font-family:Arial, sans-serif;font-size:14px;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:black;}" +
".tg th{font-family:Arial, sans-serif;font-size:14px;font-weight:normal;padding:10px 5px;border-style:solid;border-width:1px;overflow:hidden;word-break:normal;border-color:black;}" +
".tg .tg-0lax{text-align:left;vertical-align:top}" +
"</style>" +
"<table class=\"tg\">" +
"  <tr>" +
"    <th class=\"tg-0lax\">Invoice Number</th>" +
"    <th class=\"tg-0lax\">" + lbInvoiceNumber.Text + "</th>" +
"  </tr>" +
"  <tr>" +
"    <td class=\"tg-0lax\">Payment Date</td>" +
"    <td class=\"tg-0lax\">" + lbDate.Text + "</td>" +
"  </tr>" +
"  <tr>" +
"    <td class=\"tg-0lax\">Type</td>" +
"    <td class=\"tg-0lax\">" + ddType.Text + "</td>" +
"  </tr>" +
"  <tr>" +
"    <td class=\"tg-0lax\">Description</td>" +
"    <td class=\"tg-0lax\">" + txtDesc.Text + "</td>" +
"  </tr>" +
"  <tr>" +
"    <td class=\"tg-0lax\">Total</td>" +
"    <td class=\"tg-0lax\">" + txtTotal.Text + "</td>" +
"  </tr>" +
"  <tr>" +
"    <td class=\"tg-0lax\">Status</td>" +
"    <td class=\"tg-0lax\">" + ddStatus.Text + "</td>" +
"  </tr>" +
"</table>";
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("htmangmt", "H0tel4901");
                SmtpServer.EnableSsl = true;

                SmtpServer.Send(mail);

                MessageBox.Show("Email Sent", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();
                MainMenu mainMenu = new MainMenu();
                mainMenu.Closed += (s, args) => this.Close();
                mainMenu.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            
        }
    }
}

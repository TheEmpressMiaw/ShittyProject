using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;

namespace WindowsFormsApp1
{
    public partial class SendMail : Form
    {
        public SendMail()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");

                mail.From = new MailAddress("htmangmt@gmail.com");
                mail.To.Add(txtToAddress.Text);
                mail.Subject = txtSubject.Text;
                mail.Body = txtBody.Text;

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

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
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Reservation : Form
    {
        SqlConnection sqlconn = new SqlConnection();
        SqlCommand sqlcmd = new SqlCommand();

        public static string input = "Enter Email ID";

        public Reservation()
        {
            InitializeComponent();
            sqlconn.ConnectionString = @"Data Source=SERVER2016;Initial Catalog=HotelMS;Integrated Security=True";
        }

        private void btnNewRes_Click(object sender, EventArgs e)
        {
            ReservationCreate reservationCreate = new ReservationCreate();
            this.Hide();
            reservationCreate.ShowDialog();
        }

        private void btnModify_Click(object sender, EventArgs e)
        {
            ShowInputDialog(ref input);
            ReservationCreate reservationCreate = new ReservationCreate();
            this.Hide();
            reservationCreate.ShowDialog();
        }

        private static DialogResult ShowInputDialog(ref string input)
        {
            System.Drawing.Size size = new System.Drawing.Size(200, 70);
            Form inputBox = new Form();

            inputBox.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            inputBox.ClientSize = size;
            inputBox.Text = "Email ID";

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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String email = "Email ID";
            ShowInputDialog(ref email);
            sqlcmd.Connection = sqlconn;
            sqlcmd.CommandType = CommandType.Text;
            sqlcmd.CommandText = "DELETE FROM Reservation WHERE Email = @newEmail";
            sqlcmd.Parameters.AddWithValue("@newEmail", email);

            try
            {
                sqlconn.Open();
                int recordsAffected = sqlcmd.ExecuteNonQuery();
                if (recordsAffected > 0)
                {
                    MessageBox.Show("Reservation Cancelled", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Closed += (s, args) => this.Close();
                    mainMenu.Show();
                }

            }
            catch (SqlException)
            {
                MessageBox.Show("Unable to Delete Reservation", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlconn.Close();
            }
        }

        private void btnPDF_Click(object sender, EventArgs e)
        {
            Document doc = new Document(PageSize.A4);

            try
            {

                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(
                  Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Report.pdf", FileMode.Create));
                doc.Open();
                PdfPTable tbl = new PdfPTable(6);

                tbl.AddCell("ID");
                tbl.AddCell("Check In");
                tbl.AddCell("Check Out");
                tbl.AddCell("Price");
                tbl.AddCell("Room");
                tbl.AddCell("Email");

                BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, false);
                var fnt = new iTextSharp.text.Font(bf, 13.0f, 1, BaseColor.BLUE);


                sqlcmd.Connection = sqlconn;
                sqlcmd.CommandType = CommandType.Text;
                sqlcmd.CommandText = "SELECT * FROM Reservation";

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
                                tbl.AddCell(dr["ID"].ToString());
                                tbl.AddCell(dr["CheckIn"].ToString());
                                tbl.AddCell(dr["CheckOut"].ToString());
                                tbl.AddCell(dr["Price"].ToString());
                                tbl.AddCell(dr["Room"].ToString());
                                tbl.AddCell(dr["Email"].ToString());
                            }
                        }
                    }

                }
                catch (SqlException)
                {
                    MessageBox.Show("Unable to Generate Report", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sqlconn.Close();

                    doc.Add(tbl);
                    doc.Close();
                    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "/Report.pdf");
                    MessageBox.Show("Report Generated", "Congrats", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ae)
            {
                MessageBox.Show(ae.Message);
            }
        }
    }
}

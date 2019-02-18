namespace WindowsFormsApp1
{
    partial class Reservation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewRes = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPDF = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnPDF);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(-1, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(644, 413);
            this.panel1.TabIndex = 5;
            // 
            // btnDelete
            // 
            this.btnDelete.Active = false;
            this.btnDelete.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.BorderRadius = 0;
            this.btnDelete.ButtonText = "Delete";
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.DisabledColor = System.Drawing.Color.Gray;
            this.btnDelete.Iconcolor = System.Drawing.Color.Transparent;
            this.btnDelete.Iconimage = null;
            this.btnDelete.Iconimage_right = null;
            this.btnDelete.Iconimage_right_Selected = null;
            this.btnDelete.Iconimage_Selected = null;
            this.btnDelete.IconMarginLeft = 0;
            this.btnDelete.IconMarginRight = 0;
            this.btnDelete.IconRightVisible = true;
            this.btnDelete.IconRightZoom = 0D;
            this.btnDelete.IconVisible = true;
            this.btnDelete.IconZoom = 90D;
            this.btnDelete.IsTab = false;
            this.btnDelete.Location = new System.Drawing.Point(192, 245);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(241, 48);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnModify
            // 
            this.btnModify.Active = false;
            this.btnModify.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModify.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModify.BorderRadius = 0;
            this.btnModify.ButtonText = "Modify";
            this.btnModify.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModify.DisabledColor = System.Drawing.Color.Gray;
            this.btnModify.Iconcolor = System.Drawing.Color.Transparent;
            this.btnModify.Iconimage = null;
            this.btnModify.Iconimage_right = null;
            this.btnModify.Iconimage_right_Selected = null;
            this.btnModify.Iconimage_Selected = null;
            this.btnModify.IconMarginLeft = 0;
            this.btnModify.IconMarginRight = 0;
            this.btnModify.IconRightVisible = true;
            this.btnModify.IconRightZoom = 0D;
            this.btnModify.IconVisible = true;
            this.btnModify.IconZoom = 90D;
            this.btnModify.IsTab = false;
            this.btnModify.Location = new System.Drawing.Point(192, 163);
            this.btnModify.Name = "btnModify";
            this.btnModify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnModify.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModify.selected = false;
            this.btnModify.Size = new System.Drawing.Size(241, 48);
            this.btnModify.TabIndex = 5;
            this.btnModify.Text = "Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModify.Textcolor = System.Drawing.Color.White;
            this.btnModify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(644, 134);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNewRes);
            this.panel3.Location = new System.Drawing.Point(39, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 340);
            this.panel3.TabIndex = 3;
            // 
            // btnNewRes
            // 
            this.btnNewRes.Active = false;
            this.btnNewRes.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewRes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewRes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewRes.BorderRadius = 0;
            this.btnNewRes.ButtonText = "New Reservation";
            this.btnNewRes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRes.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewRes.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewRes.Iconimage = null;
            this.btnNewRes.Iconimage_right = null;
            this.btnNewRes.Iconimage_right_Selected = null;
            this.btnNewRes.Iconimage_Selected = null;
            this.btnNewRes.IconMarginLeft = 0;
            this.btnNewRes.IconMarginRight = 0;
            this.btnNewRes.IconRightVisible = true;
            this.btnNewRes.IconRightZoom = 0D;
            this.btnNewRes.IconVisible = true;
            this.btnNewRes.IconZoom = 90D;
            this.btnNewRes.IsTab = false;
            this.btnNewRes.Location = new System.Drawing.Point(153, 50);
            this.btnNewRes.Name = "btnNewRes";
            this.btnNewRes.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewRes.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNewRes.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewRes.selected = false;
            this.btnNewRes.Size = new System.Drawing.Size(241, 48);
            this.btnNewRes.TabIndex = 4;
            this.btnNewRes.Text = "New Reservation";
            this.btnNewRes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewRes.Textcolor = System.Drawing.Color.White;
            this.btnNewRes.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRes.Click += new System.EventHandler(this.btnNewRes_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.Active = false;
            this.btnPDF.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPDF.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPDF.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPDF.BorderRadius = 0;
            this.btnPDF.ButtonText = "Generate PDF Report";
            this.btnPDF.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPDF.DisabledColor = System.Drawing.Color.Gray;
            this.btnPDF.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPDF.Iconimage = null;
            this.btnPDF.Iconimage_right = null;
            this.btnPDF.Iconimage_right_Selected = null;
            this.btnPDF.Iconimage_Selected = null;
            this.btnPDF.IconMarginLeft = 0;
            this.btnPDF.IconMarginRight = 0;
            this.btnPDF.IconRightVisible = true;
            this.btnPDF.IconRightZoom = 0D;
            this.btnPDF.IconVisible = true;
            this.btnPDF.IconZoom = 90D;
            this.btnPDF.IsTab = false;
            this.btnPDF.Location = new System.Drawing.Point(192, 325);
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnPDF.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnPDF.OnHoverTextColor = System.Drawing.Color.White;
            this.btnPDF.selected = false;
            this.btnPDF.Size = new System.Drawing.Size(241, 48);
            this.btnPDF.TabIndex = 7;
            this.btnPDF.Text = "Generate PDF Report";
            this.btnPDF.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPDF.Textcolor = System.Drawing.Color.White;
            this.btnPDF.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // Reservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 411);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reservation";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnModify;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewRes;
        private Bunifu.Framework.UI.BunifuFlatButton btnPDF;
    }
}
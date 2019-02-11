namespace WindowsFormsApp1
{
    partial class Customer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewCus = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModify = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnMail = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMail);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnModify);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(625, 373);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 134);
            this.panel2.TabIndex = 3;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNewCus);
            this.panel3.Location = new System.Drawing.Point(39, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 340);
            this.panel3.TabIndex = 3;
            // 
            // btnNewCus
            // 
            this.btnNewCus.Active = false;
            this.btnNewCus.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewCus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewCus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewCus.BorderRadius = 0;
            this.btnNewCus.ButtonText = "New Customer";
            this.btnNewCus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewCus.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewCus.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewCus.Iconimage = null;
            this.btnNewCus.Iconimage_right = null;
            this.btnNewCus.Iconimage_right_Selected = null;
            this.btnNewCus.Iconimage_Selected = null;
            this.btnNewCus.IconMarginLeft = 0;
            this.btnNewCus.IconMarginRight = 0;
            this.btnNewCus.IconRightVisible = true;
            this.btnNewCus.IconRightZoom = 0D;
            this.btnNewCus.IconVisible = true;
            this.btnNewCus.IconZoom = 90D;
            this.btnNewCus.IsTab = false;
            this.btnNewCus.Location = new System.Drawing.Point(153, 25);
            this.btnNewCus.Name = "btnNewCus";
            this.btnNewCus.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewCus.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNewCus.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewCus.selected = false;
            this.btnNewCus.Size = new System.Drawing.Size(241, 48);
            this.btnNewCus.TabIndex = 4;
            this.btnNewCus.Text = "New Customer";
            this.btnNewCus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewCus.Textcolor = System.Drawing.Color.White;
            this.btnNewCus.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnModify.Location = new System.Drawing.Point(192, 140);
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
            this.btnDelete.Location = new System.Drawing.Point(192, 215);
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
            // 
            // btnMail
            // 
            this.btnMail.Active = false;
            this.btnMail.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMail.BorderRadius = 0;
            this.btnMail.ButtonText = "Send Mail";
            this.btnMail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMail.DisabledColor = System.Drawing.Color.Gray;
            this.btnMail.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMail.Iconimage = null;
            this.btnMail.Iconimage_right = null;
            this.btnMail.Iconimage_right_Selected = null;
            this.btnMail.Iconimage_Selected = null;
            this.btnMail.IconMarginLeft = 0;
            this.btnMail.IconMarginRight = 0;
            this.btnMail.IconRightVisible = true;
            this.btnMail.IconRightZoom = 0D;
            this.btnMail.IconVisible = true;
            this.btnMail.IconZoom = 90D;
            this.btnMail.IsTab = false;
            this.btnMail.Location = new System.Drawing.Point(192, 289);
            this.btnMail.Name = "btnMail";
            this.btnMail.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMail.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMail.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMail.selected = false;
            this.btnMail.Size = new System.Drawing.Size(241, 48);
            this.btnMail.TabIndex = 7;
            this.btnMail.Text = "Send Mail";
            this.btnMail.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMail.Textcolor = System.Drawing.Color.White;
            this.btnMail.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Customer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 372);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Customer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnMail;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnModify;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewCus;
    }
}
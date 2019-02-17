namespace WindowsFormsApp1
{
    partial class ReservationCreate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationCreate));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnReserve = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.dpCheckIn = new Bunifu.Framework.UI.BunifuDatepicker();
            this.dpCheckOut = new Bunifu.Framework.UI.BunifuDatepicker();
            this.txtEmail = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtRoom = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(625, 134);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnReserve);
            this.panel3.Location = new System.Drawing.Point(38, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 340);
            this.panel3.TabIndex = 6;
            // 
            // btnReserve
            // 
            this.btnReserve.Active = false;
            this.btnReserve.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReserve.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReserve.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReserve.BorderRadius = 0;
            this.btnReserve.ButtonText = "                 Reserve";
            this.btnReserve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReserve.DisabledColor = System.Drawing.Color.Gray;
            this.btnReserve.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReserve.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnReserve.Iconimage")));
            this.btnReserve.Iconimage_right = null;
            this.btnReserve.Iconimage_right_Selected = null;
            this.btnReserve.Iconimage_Selected = null;
            this.btnReserve.IconMarginLeft = 0;
            this.btnReserve.IconMarginRight = 0;
            this.btnReserve.IconRightVisible = true;
            this.btnReserve.IconRightZoom = 0D;
            this.btnReserve.IconVisible = true;
            this.btnReserve.IconZoom = 90D;
            this.btnReserve.IsTab = false;
            this.btnReserve.Location = new System.Drawing.Point(147, 31);
            this.btnReserve.Name = "btnReserve";
            this.btnReserve.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnReserve.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnReserve.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReserve.selected = false;
            this.btnReserve.Size = new System.Drawing.Size(241, 48);
            this.btnReserve.TabIndex = 10;
            this.btnReserve.Text = "                 Reserve";
            this.btnReserve.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReserve.Textcolor = System.Drawing.Color.White;
            this.btnReserve.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReserve.Click += new System.EventHandler(this.btnReserve_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtPrice.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPrice.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPrice.HintForeColor = System.Drawing.Color.Empty;
            this.txtPrice.HintText = "";
            this.txtPrice.isPassword = false;
            this.txtPrice.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtPrice.LineIdleColor = System.Drawing.Color.Gray;
            this.txtPrice.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtPrice.LineThickness = 3;
            this.txtPrice.Location = new System.Drawing.Point(173, 265);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(103, 33);
            this.txtPrice.TabIndex = 9;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(101, 275);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel2.TabIndex = 8;
            this.bunifuCustomLabel2.Text = "Price";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(101, 162);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(52, 13);
            this.bunifuCustomLabel1.TabIndex = 10;
            this.bunifuCustomLabel1.Text = "Check IN";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(101, 223);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(64, 13);
            this.bunifuCustomLabel3.TabIndex = 11;
            this.bunifuCustomLabel3.Text = "Check OUT";
            // 
            // dpCheckIn
            // 
            this.dpCheckIn.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCheckIn.BorderRadius = 0;
            this.dpCheckIn.ForeColor = System.Drawing.Color.White;
            this.dpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCheckIn.FormatCustom = null;
            this.dpCheckIn.Location = new System.Drawing.Point(173, 149);
            this.dpCheckIn.Name = "dpCheckIn";
            this.dpCheckIn.Size = new System.Drawing.Size(303, 36);
            this.dpCheckIn.TabIndex = 12;
            this.dpCheckIn.Value = new System.DateTime(2019, 2, 16, 20, 33, 41, 770);
            this.dpCheckIn.onValueChanged += new System.EventHandler(this.dpCheckIn_onValueChanged);
            // 
            // dpCheckOut
            // 
            this.dpCheckOut.BackColor = System.Drawing.Color.SeaGreen;
            this.dpCheckOut.BorderRadius = 0;
            this.dpCheckOut.ForeColor = System.Drawing.Color.White;
            this.dpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dpCheckOut.FormatCustom = null;
            this.dpCheckOut.Location = new System.Drawing.Point(173, 211);
            this.dpCheckOut.Name = "dpCheckOut";
            this.dpCheckOut.Size = new System.Drawing.Size(303, 36);
            this.dpCheckOut.TabIndex = 13;
            this.dpCheckOut.Value = new System.DateTime(2019, 2, 16, 20, 33, 41, 770);
            // 
            // txtEmail
            // 
            this.txtEmail.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtEmail.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtEmail.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtEmail.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtEmail.HintForeColor = System.Drawing.Color.Empty;
            this.txtEmail.HintText = "";
            this.txtEmail.isPassword = false;
            this.txtEmail.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtEmail.LineIdleColor = System.Drawing.Color.Gray;
            this.txtEmail.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtEmail.LineThickness = 3;
            this.txtEmail.Location = new System.Drawing.Point(173, 316);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(303, 33);
            this.txtEmail.TabIndex = 15;
            this.txtEmail.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(101, 326);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 14;
            this.labelEmail.Text = "Email";
            // 
            // txtRoom
            // 
            this.txtRoom.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRoom.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRoom.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRoom.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoom.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRoom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoom.HintForeColor = System.Drawing.Color.Empty;
            this.txtRoom.HintText = "";
            this.txtRoom.isPassword = false;
            this.txtRoom.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRoom.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRoom.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRoom.LineThickness = 3;
            this.txtRoom.Location = new System.Drawing.Point(355, 265);
            this.txtRoom.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoom.MaxLength = 32767;
            this.txtRoom.Name = "txtRoom";
            this.txtRoom.Size = new System.Drawing.Size(121, 33);
            this.txtRoom.TabIndex = 17;
            this.txtRoom.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(303, 275);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(35, 13);
            this.bunifuCustomLabel5.TabIndex = 16;
            this.bunifuCustomLabel5.Text = "Room";
            // 
            // ReservationCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 373);
            this.Controls.Add(this.txtRoom);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.dpCheckOut);
            this.Controls.Add(this.dpCheckIn);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReservationCreate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnReserve;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuDatepicker dpCheckIn;
        private Bunifu.Framework.UI.BunifuDatepicker dpCheckOut;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtEmail;
        private Bunifu.Framework.UI.BunifuCustomLabel labelEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRoom;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
    }
}
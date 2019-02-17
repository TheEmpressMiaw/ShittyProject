namespace WindowsFormsApp1
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAddRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtRoomNo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.labelEmail = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtFloor = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtPrice = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txtCapacity = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
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
            this.panel2.Size = new System.Drawing.Size(609, 134);
            this.panel2.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnAddRoom);
            this.panel3.Location = new System.Drawing.Point(38, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 340);
            this.panel3.TabIndex = 6;
            // 
            // btnAddRoom
            // 
            this.btnAddRoom.Active = false;
            this.btnAddRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAddRoom.BorderRadius = 0;
            this.btnAddRoom.ButtonText = "                 Add Room";
            this.btnAddRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnAddRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnAddRoom.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnAddRoom.Iconimage")));
            this.btnAddRoom.Iconimage_right = null;
            this.btnAddRoom.Iconimage_right_Selected = null;
            this.btnAddRoom.Iconimage_Selected = null;
            this.btnAddRoom.IconMarginLeft = 0;
            this.btnAddRoom.IconMarginRight = 0;
            this.btnAddRoom.IconRightVisible = true;
            this.btnAddRoom.IconRightZoom = 0D;
            this.btnAddRoom.IconVisible = true;
            this.btnAddRoom.IconZoom = 90D;
            this.btnAddRoom.IsTab = false;
            this.btnAddRoom.Location = new System.Drawing.Point(147, 31);
            this.btnAddRoom.Name = "btnAddRoom";
            this.btnAddRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnAddRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnAddRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnAddRoom.selected = false;
            this.btnAddRoom.Size = new System.Drawing.Size(241, 48);
            this.btnAddRoom.TabIndex = 10;
            this.btnAddRoom.Text = "                 Add Room";
            this.btnAddRoom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddRoom.Textcolor = System.Drawing.Color.White;
            this.btnAddRoom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // txtRoomNo
            // 
            this.txtRoomNo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtRoomNo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtRoomNo.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRoomNo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRoomNo.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtRoomNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtRoomNo.HintForeColor = System.Drawing.Color.Empty;
            this.txtRoomNo.HintText = "";
            this.txtRoomNo.isPassword = false;
            this.txtRoomNo.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtRoomNo.LineIdleColor = System.Drawing.Color.Gray;
            this.txtRoomNo.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtRoomNo.LineThickness = 3;
            this.txtRoomNo.Location = new System.Drawing.Point(185, 141);
            this.txtRoomNo.Margin = new System.Windows.Forms.Padding(4);
            this.txtRoomNo.MaxLength = 32767;
            this.txtRoomNo.Name = "txtRoomNo";
            this.txtRoomNo.Size = new System.Drawing.Size(303, 33);
            this.txtRoomNo.TabIndex = 17;
            this.txtRoomNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(117, 151);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(45, 13);
            this.labelEmail.TabIndex = 16;
            this.labelEmail.Text = "Room #";
            // 
            // txtFloor
            // 
            this.txtFloor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtFloor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtFloor.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFloor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFloor.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtFloor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtFloor.HintForeColor = System.Drawing.Color.Empty;
            this.txtFloor.HintText = "";
            this.txtFloor.isPassword = false;
            this.txtFloor.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtFloor.LineIdleColor = System.Drawing.Color.Gray;
            this.txtFloor.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtFloor.LineThickness = 3;
            this.txtFloor.Location = new System.Drawing.Point(185, 197);
            this.txtFloor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFloor.MaxLength = 32767;
            this.txtFloor.Name = "txtFloor";
            this.txtFloor.Size = new System.Drawing.Size(303, 33);
            this.txtFloor.TabIndex = 19;
            this.txtFloor.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(117, 208);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(30, 13);
            this.bunifuCustomLabel1.TabIndex = 18;
            this.bunifuCustomLabel1.Text = "Floor";
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
            this.txtPrice.Location = new System.Drawing.Point(185, 293);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrice.MaxLength = 32767;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(303, 33);
            this.txtPrice.TabIndex = 23;
            this.txtPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(117, 303);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(31, 13);
            this.bunifuCustomLabel2.TabIndex = 22;
            this.bunifuCustomLabel2.Text = "Price";
            // 
            // txtCapacity
            // 
            this.txtCapacity.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtCapacity.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtCapacity.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCapacity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCapacity.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtCapacity.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCapacity.HintForeColor = System.Drawing.Color.Empty;
            this.txtCapacity.HintText = "";
            this.txtCapacity.isPassword = false;
            this.txtCapacity.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtCapacity.LineIdleColor = System.Drawing.Color.Gray;
            this.txtCapacity.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtCapacity.LineThickness = 3;
            this.txtCapacity.Location = new System.Drawing.Point(185, 243);
            this.txtCapacity.Margin = new System.Windows.Forms.Padding(4);
            this.txtCapacity.MaxLength = 32767;
            this.txtCapacity.Name = "txtCapacity";
            this.txtCapacity.Size = new System.Drawing.Size(303, 33);
            this.txtCapacity.TabIndex = 21;
            this.txtCapacity.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(117, 252);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(48, 13);
            this.bunifuCustomLabel3.TabIndex = 20;
            this.bunifuCustomLabel3.Text = "Capacity";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(609, 361);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.bunifuCustomLabel2);
            this.Controls.Add(this.txtCapacity);
            this.Controls.Add(this.bunifuCustomLabel3);
            this.Controls.Add(this.txtFloor);
            this.Controls.Add(this.bunifuCustomLabel1);
            this.Controls.Add(this.txtRoomNo);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
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
        private Bunifu.Framework.UI.BunifuFlatButton btnAddRoom;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtRoomNo;
        private Bunifu.Framework.UI.BunifuCustomLabel labelEmail;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtFloor;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtPrice;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtCapacity;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
    }
}
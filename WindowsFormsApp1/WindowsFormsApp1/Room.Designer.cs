namespace WindowsFormsApp1
{
    partial class Room
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnNewRoom = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnDelete = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnModify = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.panel2.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.btnNewRoom);
            this.panel3.Location = new System.Drawing.Point(39, 33);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(552, 340);
            this.panel3.TabIndex = 3;
            // 
            // btnNewRoom
            // 
            this.btnNewRoom.Active = false;
            this.btnNewRoom.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewRoom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewRoom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewRoom.BorderRadius = 0;
            this.btnNewRoom.ButtonText = "New Room";
            this.btnNewRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNewRoom.DisabledColor = System.Drawing.Color.Gray;
            this.btnNewRoom.Iconcolor = System.Drawing.Color.Transparent;
            this.btnNewRoom.Iconimage = null;
            this.btnNewRoom.Iconimage_right = null;
            this.btnNewRoom.Iconimage_right_Selected = null;
            this.btnNewRoom.Iconimage_Selected = null;
            this.btnNewRoom.IconMarginLeft = 0;
            this.btnNewRoom.IconMarginRight = 0;
            this.btnNewRoom.IconRightVisible = true;
            this.btnNewRoom.IconRightZoom = 0D;
            this.btnNewRoom.IconVisible = true;
            this.btnNewRoom.IconZoom = 90D;
            this.btnNewRoom.IsTab = false;
            this.btnNewRoom.Location = new System.Drawing.Point(153, 50);
            this.btnNewRoom.Name = "btnNewRoom";
            this.btnNewRoom.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnNewRoom.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnNewRoom.OnHoverTextColor = System.Drawing.Color.White;
            this.btnNewRoom.selected = false;
            this.btnNewRoom.Size = new System.Drawing.Size(241, 48);
            this.btnNewRoom.TabIndex = 4;
            this.btnNewRoom.Text = "New Room";
            this.btnNewRoom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNewRoom.Textcolor = System.Drawing.Color.White;
            this.btnNewRoom.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNewRoom.Click += new System.EventHandler(this.btnNewRoom_Click);
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
            this.btnDelete.Location = new System.Drawing.Point(192, 296);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnDelete.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnDelete.OnHoverTextColor = System.Drawing.Color.White;
            this.btnDelete.selected = false;
            this.btnDelete.Size = new System.Drawing.Size(241, 48);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnDelete.Textcolor = System.Drawing.Color.White;
            this.btnDelete.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnModify.Location = new System.Drawing.Point(192, 188);
            this.btnModify.Name = "btnModify";
            this.btnModify.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnModify.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnModify.OnHoverTextColor = System.Drawing.Color.White;
            this.btnModify.selected = false;
            this.btnModify.Size = new System.Drawing.Size(241, 48);
            this.btnModify.TabIndex = 7;
            this.btnModify.Text = "Modify";
            this.btnModify.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnModify.Textcolor = System.Drawing.Color.White;
            this.btnModify.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // Room
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(625, 372);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Room";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Bunifu.Framework.UI.BunifuFlatButton btnNewRoom;
        private Bunifu.Framework.UI.BunifuFlatButton btnDelete;
        private Bunifu.Framework.UI.BunifuFlatButton btnModify;
    }
}
namespace WindowsFormsApp1
{
    partial class Sorting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sorting));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtInput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel3 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnMerge = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.btnBubble = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.btnQuick = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.btnInsert = new Bunifu.UI.WinForms.BunifuRadioButton();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel5 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel6 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel7 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnSorting = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtOutput = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.btnMainMenu = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.txtExecutionTime = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(641, 134);
            this.panel2.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnMainMenu);
            this.panel1.Location = new System.Drawing.Point(39, 33);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(552, 352);
            this.panel1.TabIndex = 3;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.Location = new System.Drawing.Point(66, 158);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(113, 15);
            this.bunifuLabel1.TabIndex = 4;
            this.bunifuLabel1.Text = "Enter input to be sorted ";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.Location = new System.Drawing.Point(218, 183);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(148, 15);
            this.bunifuLabel2.TabIndex = 5;
            this.bunifuLabel2.Text = "Use space to seperate number";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtInput
            // 
            this.txtInput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtInput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtInput.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtInput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtInput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtInput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtInput.HintForeColor = System.Drawing.Color.Empty;
            this.txtInput.HintText = "";
            this.txtInput.isPassword = false;
            this.txtInput.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtInput.LineIdleColor = System.Drawing.Color.Gray;
            this.txtInput.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtInput.LineThickness = 3;
            this.txtInput.Location = new System.Drawing.Point(203, 143);
            this.txtInput.Margin = new System.Windows.Forms.Padding(4);
            this.txtInput.MaxLength = 32767;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(379, 33);
            this.txtInput.TabIndex = 6;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel3
            // 
            this.bunifuLabel3.AutoEllipsis = false;
            this.bunifuLabel3.CursorType = null;
            this.bunifuLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel3.Location = new System.Drawing.Point(66, 237);
            this.bunifuLabel3.Name = "bunifuLabel3";
            this.bunifuLabel3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel3.Size = new System.Drawing.Size(108, 15);
            this.bunifuLabel3.TabIndex = 7;
            this.bunifuLabel3.Text = "Select Sorting Method";
            this.bunifuLabel3.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnMerge
            // 
            this.btnMerge.Checked = false;
            this.btnMerge.Location = new System.Drawing.Point(194, 226);
            this.btnMerge.Name = "btnMerge";
            this.btnMerge.OutlineColor = System.Drawing.Color.Purple;
            this.btnMerge.RadioColor = System.Drawing.Color.Purple;
            this.btnMerge.Size = new System.Drawing.Size(25, 25);
            this.btnMerge.TabIndex = 8;
            this.btnMerge.Text = null;
            // 
            // btnBubble
            // 
            this.btnBubble.Checked = false;
            this.btnBubble.Location = new System.Drawing.Point(301, 226);
            this.btnBubble.Name = "btnBubble";
            this.btnBubble.OutlineColor = System.Drawing.Color.Purple;
            this.btnBubble.RadioColor = System.Drawing.Color.Purple;
            this.btnBubble.Size = new System.Drawing.Size(25, 25);
            this.btnBubble.TabIndex = 9;
            this.btnBubble.Text = null;
            // 
            // btnQuick
            // 
            this.btnQuick.Checked = false;
            this.btnQuick.Location = new System.Drawing.Point(408, 227);
            this.btnQuick.Name = "btnQuick";
            this.btnQuick.OutlineColor = System.Drawing.Color.Purple;
            this.btnQuick.RadioColor = System.Drawing.Color.Purple;
            this.btnQuick.Size = new System.Drawing.Size(25, 25);
            this.btnQuick.TabIndex = 10;
            this.btnQuick.Text = null;
            // 
            // btnInsert
            // 
            this.btnInsert.Checked = false;
            this.btnInsert.Location = new System.Drawing.Point(503, 226);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.OutlineColor = System.Drawing.Color.Purple;
            this.btnInsert.RadioColor = System.Drawing.Color.Purple;
            this.btnInsert.Size = new System.Drawing.Size(25, 25);
            this.btnInsert.TabIndex = 11;
            this.btnInsert.Text = null;
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel4.Location = new System.Drawing.Point(225, 236);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(33, 15);
            this.bunifuLabel4.TabIndex = 12;
            this.bunifuLabel4.Text = "Merge";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel5
            // 
            this.bunifuLabel5.AutoEllipsis = false;
            this.bunifuLabel5.CursorType = null;
            this.bunifuLabel5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel5.Location = new System.Drawing.Point(332, 237);
            this.bunifuLabel5.Name = "bunifuLabel5";
            this.bunifuLabel5.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel5.Size = new System.Drawing.Size(36, 15);
            this.bunifuLabel5.TabIndex = 13;
            this.bunifuLabel5.Text = "Bubble";
            this.bunifuLabel5.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel6
            // 
            this.bunifuLabel6.AutoEllipsis = false;
            this.bunifuLabel6.CursorType = null;
            this.bunifuLabel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel6.Location = new System.Drawing.Point(439, 236);
            this.bunifuLabel6.Name = "bunifuLabel6";
            this.bunifuLabel6.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel6.Size = new System.Drawing.Size(31, 15);
            this.bunifuLabel6.TabIndex = 14;
            this.bunifuLabel6.Text = "Quick";
            this.bunifuLabel6.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // bunifuLabel7
            // 
            this.bunifuLabel7.AutoEllipsis = false;
            this.bunifuLabel7.CursorType = null;
            this.bunifuLabel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel7.Location = new System.Drawing.Point(534, 236);
            this.bunifuLabel7.Name = "bunifuLabel7";
            this.bunifuLabel7.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel7.Size = new System.Drawing.Size(29, 15);
            this.bunifuLabel7.TabIndex = 15;
            this.bunifuLabel7.Text = "Insert";
            this.bunifuLabel7.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnSorting
            // 
            this.btnSorting.Active = false;
            this.btnSorting.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSorting.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSorting.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSorting.BorderRadius = 0;
            this.btnSorting.ButtonText = "Sort";
            this.btnSorting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSorting.DisabledColor = System.Drawing.Color.Gray;
            this.btnSorting.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSorting.Iconimage = null;
            this.btnSorting.Iconimage_right = null;
            this.btnSorting.Iconimage_right_Selected = null;
            this.btnSorting.Iconimage_Selected = null;
            this.btnSorting.IconMarginLeft = 0;
            this.btnSorting.IconMarginRight = 0;
            this.btnSorting.IconRightVisible = true;
            this.btnSorting.IconRightZoom = 0D;
            this.btnSorting.IconVisible = true;
            this.btnSorting.IconZoom = 90D;
            this.btnSorting.IsTab = false;
            this.btnSorting.Location = new System.Drawing.Point(203, 276);
            this.btnSorting.Name = "btnSorting";
            this.btnSorting.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnSorting.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnSorting.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSorting.selected = false;
            this.btnSorting.Size = new System.Drawing.Size(379, 48);
            this.btnSorting.TabIndex = 16;
            this.btnSorting.Text = "Sort";
            this.btnSorting.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSorting.Textcolor = System.Drawing.Color.White;
            this.btnSorting.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSorting.Click += new System.EventHandler(this.btnSorting_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.txtOutput.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.txtOutput.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtOutput.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtOutput.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtOutput.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtOutput.HintForeColor = System.Drawing.Color.Empty;
            this.txtOutput.HintText = "";
            this.txtOutput.isPassword = false;
            this.txtOutput.LineFocusedColor = System.Drawing.Color.Blue;
            this.txtOutput.LineIdleColor = System.Drawing.Color.Gray;
            this.txtOutput.LineMouseHoverColor = System.Drawing.Color.Blue;
            this.txtOutput.LineThickness = 3;
            this.txtOutput.Location = new System.Drawing.Point(194, 392);
            this.txtOutput.Margin = new System.Windows.Forms.Padding(4);
            this.txtOutput.MaxLength = 32767;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.Size = new System.Drawing.Size(379, 33);
            this.txtOutput.TabIndex = 18;
            this.txtOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.Location = new System.Drawing.Point(66, 407);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(69, 15);
            this.bunifuLabel8.TabIndex = 17;
            this.bunifuLabel8.Text = "Sorted Output";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // btnMainMenu
            // 
            this.btnMainMenu.Active = false;
            this.btnMainMenu.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMainMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMainMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMainMenu.BorderRadius = 0;
            this.btnMainMenu.ButtonText = "Main Menu";
            this.btnMainMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMainMenu.DisabledColor = System.Drawing.Color.Gray;
            this.btnMainMenu.Iconcolor = System.Drawing.Color.Transparent;
            this.btnMainMenu.Iconimage = null;
            this.btnMainMenu.Iconimage_right = null;
            this.btnMainMenu.Iconimage_right_Selected = null;
            this.btnMainMenu.Iconimage_Selected = null;
            this.btnMainMenu.IconMarginLeft = 0;
            this.btnMainMenu.IconMarginRight = 0;
            this.btnMainMenu.IconRightVisible = true;
            this.btnMainMenu.IconRightZoom = 0D;
            this.btnMainMenu.IconVisible = true;
            this.btnMainMenu.IconZoom = 90D;
            this.btnMainMenu.IsTab = false;
            this.btnMainMenu.Location = new System.Drawing.Point(86, 30);
            this.btnMainMenu.Name = "btnMainMenu";
            this.btnMainMenu.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(139)))), ((int)(((byte)(87)))));
            this.btnMainMenu.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(129)))), ((int)(((byte)(77)))));
            this.btnMainMenu.OnHoverTextColor = System.Drawing.Color.White;
            this.btnMainMenu.selected = false;
            this.btnMainMenu.Size = new System.Drawing.Size(379, 48);
            this.btnMainMenu.TabIndex = 19;
            this.btnMainMenu.Text = "Main Menu";
            this.btnMainMenu.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnMainMenu.Textcolor = System.Drawing.Color.White;
            this.btnMainMenu.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMainMenu.Click += new System.EventHandler(this.btnMainMenu_Click);
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel9.Location = new System.Drawing.Point(66, 358);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(62, 15);
            this.bunifuLabel9.TabIndex = 19;
            this.bunifuLabel9.Text = "Sorting Time";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // txtExecutionTime
            // 
            this.txtExecutionTime.AutoEllipsis = false;
            this.txtExecutionTime.CursorType = null;
            this.txtExecutionTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExecutionTime.Location = new System.Drawing.Point(194, 358);
            this.txtExecutionTime.Name = "txtExecutionTime";
            this.txtExecutionTime.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtExecutionTime.Size = new System.Drawing.Size(0, 0);
            this.txtExecutionTime.TabIndex = 20;
            this.txtExecutionTime.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            // 
            // Sorting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(641, 464);
            this.Controls.Add(this.txtExecutionTime);
            this.Controls.Add(this.bunifuLabel9);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.bunifuLabel8);
            this.Controls.Add(this.btnSorting);
            this.Controls.Add(this.bunifuLabel7);
            this.Controls.Add(this.bunifuLabel6);
            this.Controls.Add(this.bunifuLabel5);
            this.Controls.Add(this.bunifuLabel4);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnQuick);
            this.Controls.Add(this.btnBubble);
            this.Controls.Add(this.btnMerge);
            this.Controls.Add(this.bunifuLabel3);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Sorting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtInput;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel3;
        private Bunifu.UI.WinForms.BunifuRadioButton btnMerge;
        private Bunifu.UI.WinForms.BunifuRadioButton btnBubble;
        private Bunifu.UI.WinForms.BunifuRadioButton btnQuick;
        private Bunifu.UI.WinForms.BunifuRadioButton btnInsert;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel5;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel6;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel7;
        private Bunifu.Framework.UI.BunifuFlatButton btnSorting;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtOutput;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.Framework.UI.BunifuFlatButton btnMainMenu;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Bunifu.UI.WinForms.BunifuLabel txtExecutionTime;
    }
}
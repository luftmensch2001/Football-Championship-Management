namespace NationalFootballChampionshipManagement
{
    partial class formScoresTools
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
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tbTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.nudWin = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbWin = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.nudEqual = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbEqual = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.nudLose = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.tbLose = new Guna.UI2.WinForms.Guna2TextBox();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudWin)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEqual)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudLose)).BeginInit();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.tbTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(874, 70);
            this.panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 35;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 70);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.BorderThickness = 0;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.DefaultText = "Quy định về điểm số";
            this.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTitle.DisabledState.Parent = this.tbTitle;
            this.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.tbTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTitle.FocusedState.Parent = this.tbTitle;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTitle.HoverState.Parent = this.tbTitle;
            this.tbTitle.Location = new System.Drawing.Point(0, 0);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(8, 9, 8, 9);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.PlaceholderText = "";
            this.tbTitle.SelectedText = "";
            this.tbTitle.SelectionStart = 19;
            this.tbTitle.ShadowDecoration.Parent = this.tbTitle;
            this.tbTitle.Size = new System.Drawing.Size(874, 70);
            this.tbTitle.TabIndex = 2;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.nudWin);
            this.panel2.Controls.Add(this.tbWin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 70);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(874, 40);
            this.panel2.TabIndex = 1;
            // 
            // nudWin
            // 
            this.nudWin.BackColor = System.Drawing.Color.Transparent;
            this.nudWin.BorderThickness = 0;
            this.nudWin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudWin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudWin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudWin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudWin.DisabledState.Parent = this.nudWin;
            this.nudWin.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudWin.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudWin.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudWin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudWin.FocusedState.Parent = this.nudWin;
            this.nudWin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.nudWin.ForeColor = System.Drawing.Color.Black;
            this.nudWin.Location = new System.Drawing.Point(80, 0);
            this.nudWin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudWin.Name = "nudWin";
            this.nudWin.ShadowDecoration.Parent = this.nudWin;
            this.nudWin.Size = new System.Drawing.Size(76, 40);
            this.nudWin.TabIndex = 5;
            this.nudWin.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // tbWin
            // 
            this.tbWin.BorderThickness = 0;
            this.tbWin.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbWin.DefaultText = "Thắng:";
            this.tbWin.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbWin.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbWin.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbWin.DisabledState.Parent = this.tbWin;
            this.tbWin.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbWin.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbWin.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbWin.FocusedState.Parent = this.tbWin;
            this.tbWin.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbWin.ForeColor = System.Drawing.Color.Black;
            this.tbWin.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbWin.HoverState.Parent = this.tbWin;
            this.tbWin.Location = new System.Drawing.Point(0, 0);
            this.tbWin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbWin.Name = "tbWin";
            this.tbWin.PasswordChar = '\0';
            this.tbWin.PlaceholderText = "";
            this.tbWin.SelectedText = "";
            this.tbWin.SelectionStart = 6;
            this.tbWin.ShadowDecoration.Parent = this.tbWin;
            this.tbWin.Size = new System.Drawing.Size(80, 40);
            this.tbWin.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.nudEqual);
            this.panel3.Controls.Add(this.tbEqual);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 110);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(874, 40);
            this.panel3.TabIndex = 2;
            // 
            // nudEqual
            // 
            this.nudEqual.BackColor = System.Drawing.Color.Transparent;
            this.nudEqual.BorderThickness = 0;
            this.nudEqual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudEqual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudEqual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudEqual.DisabledState.Parent = this.nudEqual;
            this.nudEqual.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudEqual.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudEqual.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudEqual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudEqual.FocusedState.Parent = this.nudEqual;
            this.nudEqual.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.nudEqual.ForeColor = System.Drawing.Color.Black;
            this.nudEqual.Location = new System.Drawing.Point(80, 0);
            this.nudEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudEqual.Name = "nudEqual";
            this.nudEqual.ShadowDecoration.Parent = this.nudEqual;
            this.nudEqual.Size = new System.Drawing.Size(76, 40);
            this.nudEqual.TabIndex = 6;
            this.nudEqual.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // tbEqual
            // 
            this.tbEqual.BorderThickness = 0;
            this.tbEqual.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbEqual.DefaultText = "Hòa:";
            this.tbEqual.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbEqual.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbEqual.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEqual.DisabledState.Parent = this.tbEqual;
            this.tbEqual.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbEqual.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbEqual.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEqual.FocusedState.Parent = this.tbEqual;
            this.tbEqual.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbEqual.ForeColor = System.Drawing.Color.Black;
            this.tbEqual.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbEqual.HoverState.Parent = this.tbEqual;
            this.tbEqual.Location = new System.Drawing.Point(0, 0);
            this.tbEqual.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbEqual.Name = "tbEqual";
            this.tbEqual.PasswordChar = '\0';
            this.tbEqual.PlaceholderText = "";
            this.tbEqual.SelectedText = "";
            this.tbEqual.SelectionStart = 4;
            this.tbEqual.ShadowDecoration.Parent = this.tbEqual;
            this.tbEqual.Size = new System.Drawing.Size(80, 40);
            this.tbEqual.TabIndex = 5;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.nudLose);
            this.panel4.Controls.Add(this.tbLose);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 150);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(874, 40);
            this.panel4.TabIndex = 3;
            // 
            // nudLose
            // 
            this.nudLose.BackColor = System.Drawing.Color.Transparent;
            this.nudLose.BorderThickness = 0;
            this.nudLose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.nudLose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.nudLose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.nudLose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.nudLose.DisabledState.Parent = this.nudLose;
            this.nudLose.DisabledState.UpDownButtonFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(177)))), ((int)(((byte)(177)))));
            this.nudLose.DisabledState.UpDownButtonForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.nudLose.Dock = System.Windows.Forms.DockStyle.Left;
            this.nudLose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.nudLose.FocusedState.Parent = this.nudLose;
            this.nudLose.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.nudLose.ForeColor = System.Drawing.Color.Black;
            this.nudLose.Location = new System.Drawing.Point(80, 0);
            this.nudLose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nudLose.Name = "nudLose";
            this.nudLose.ShadowDecoration.Parent = this.nudLose;
            this.nudLose.Size = new System.Drawing.Size(76, 40);
            this.nudLose.TabIndex = 6;
            // 
            // tbLose
            // 
            this.tbLose.BorderThickness = 0;
            this.tbLose.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbLose.DefaultText = "Thua:";
            this.tbLose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbLose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbLose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLose.DisabledState.Parent = this.tbLose;
            this.tbLose.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbLose.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbLose.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLose.FocusedState.Parent = this.tbLose;
            this.tbLose.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.tbLose.ForeColor = System.Drawing.Color.Black;
            this.tbLose.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbLose.HoverState.Parent = this.tbLose;
            this.tbLose.Location = new System.Drawing.Point(0, 0);
            this.tbLose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbLose.Name = "tbLose";
            this.tbLose.PasswordChar = '\0';
            this.tbLose.PlaceholderText = "";
            this.tbLose.SelectedText = "";
            this.tbLose.SelectionStart = 5;
            this.tbLose.ShadowDecoration.Parent = this.tbLose;
            this.tbLose.Size = new System.Drawing.Size(80, 40);
            this.tbLose.TabIndex = 5;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Save;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 28;
            this.btnSave.Location = new System.Drawing.Point(0, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(156, 40);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Lưu";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.btnSave);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 190);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(874, 40);
            this.panel5.TabIndex = 4;
            // 
            // formScoresTools
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(874, 661);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formScoresTools";
            this.Text = "formScoresTools";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudWin)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudEqual)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.nudLose)).EndInit();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox tbTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnSave;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudWin;
        private Guna.UI2.WinForms.Guna2TextBox tbWin;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudEqual;
        private Guna.UI2.WinForms.Guna2TextBox tbEqual;
        private Guna.UI2.WinForms.Guna2NumericUpDown nudLose;
        private Guna.UI2.WinForms.Guna2TextBox tbLose;
        private System.Windows.Forms.Panel panel5;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}
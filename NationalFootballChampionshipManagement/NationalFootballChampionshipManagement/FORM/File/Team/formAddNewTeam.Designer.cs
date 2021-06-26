namespace NationalFootballChampionshipManagement
{
    partial class formAddNewTeam
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
            this.lTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnAdd = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbTeamImage = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnUpload = new FontAwesome.Sharp.IconButton();
            this.panel6 = new System.Windows.Forms.Panel();
            this.tbTeamName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.tbCoachName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.tbHost = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamImage)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1165, 86);
            this.panel1.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(57, 0);
            this.lTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(1108, 86);
            this.lTitle.TabIndex = 7;
            this.lTitle.Text = "Thêm đội bóng mới";
            this.lTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnClose.IconColor = System.Drawing.Color.White;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.IconSize = 35;
            this.btnClose.Location = new System.Drawing.Point(0, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 86);
            this.btnClose.TabIndex = 6;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnAdd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 762);
            this.panel3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 52);
            this.panel3.TabIndex = 3;
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAdd.IconColor = System.Drawing.Color.White;
            this.btnAdd.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAdd.IconSize = 30;
            this.btnAdd.Location = new System.Drawing.Point(964, 0);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(201, 52);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(764, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(401, 676);
            this.panel2.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel5.Controls.Add(this.pbTeamImage);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(401, 639);
            this.panel5.TabIndex = 1;
            // 
            // pbTeamImage
            // 
            this.pbTeamImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbTeamImage.Location = new System.Drawing.Point(0, 0);
            this.pbTeamImage.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbTeamImage.Name = "pbTeamImage";
            this.pbTeamImage.Size = new System.Drawing.Size(401, 639);
            this.pbTeamImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbTeamImage.TabIndex = 0;
            this.pbTeamImage.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnUpload);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 639);
            this.panel4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(401, 37);
            this.panel4.TabIndex = 0;
            // 
            // btnUpload
            // 
            this.btnUpload.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnUpload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpload.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnUpload.FlatAppearance.BorderSize = 0;
            this.btnUpload.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.btnUpload.ForeColor = System.Drawing.Color.White;
            this.btnUpload.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnUpload.IconColor = System.Drawing.Color.White;
            this.btnUpload.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnUpload.IconSize = 25;
            this.btnUpload.Location = new System.Drawing.Point(0, 0);
            this.btnUpload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(401, 37);
            this.btnUpload.TabIndex = 1;
            this.btnUpload.Text = "Tải ảnh lên";
            this.btnUpload.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpload.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUpload.UseVisualStyleBackColor = false;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.tbTeamName);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel6.Location = new System.Drawing.Point(0, 86);
            this.panel6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(764, 50);
            this.panel6.TabIndex = 5;
            // 
            // tbTeamName
            // 
            this.tbTeamName.BorderThickness = 0;
            this.tbTeamName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTeamName.DefaultText = "";
            this.tbTeamName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTeamName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTeamName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTeamName.DisabledState.Parent = this.tbTeamName;
            this.tbTeamName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTeamName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbTeamName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTeamName.FocusedState.Parent = this.tbTeamName;
            this.tbTeamName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbTeamName.ForeColor = System.Drawing.Color.Black;
            this.tbTeamName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTeamName.HoverState.Parent = this.tbTeamName;
            this.tbTeamName.Location = new System.Drawing.Point(208, 0);
            this.tbTeamName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbTeamName.Name = "tbTeamName";
            this.tbTeamName.PasswordChar = '\0';
            this.tbTeamName.PlaceholderText = "Tên của đội bóng";
            this.tbTeamName.SelectedText = "";
            this.tbTeamName.ShadowDecoration.Parent = this.tbTeamName;
            this.tbTeamName.Size = new System.Drawing.Size(524, 50);
            this.tbTeamName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Left;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 50);
            this.label2.TabIndex = 0;
            this.label2.Text = "Tên đội bóng:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.tbCoachName);
            this.panel7.Controls.Add(this.label3);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel7.Location = new System.Drawing.Point(0, 136);
            this.panel7.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(764, 50);
            this.panel7.TabIndex = 6;
            // 
            // tbCoachName
            // 
            this.tbCoachName.BorderThickness = 0;
            this.tbCoachName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbCoachName.DefaultText = "";
            this.tbCoachName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbCoachName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbCoachName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCoachName.DisabledState.Parent = this.tbCoachName;
            this.tbCoachName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbCoachName.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbCoachName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCoachName.FocusedState.Parent = this.tbCoachName;
            this.tbCoachName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbCoachName.ForeColor = System.Drawing.Color.Black;
            this.tbCoachName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbCoachName.HoverState.Parent = this.tbCoachName;
            this.tbCoachName.Location = new System.Drawing.Point(208, 0);
            this.tbCoachName.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbCoachName.Name = "tbCoachName";
            this.tbCoachName.PasswordChar = '\0';
            this.tbCoachName.PlaceholderText = "Tên huấn luyện viên trưởng";
            this.tbCoachName.SelectedText = "";
            this.tbCoachName.ShadowDecoration.Parent = this.tbCoachName;
            this.tbCoachName.Size = new System.Drawing.Size(524, 50);
            this.tbCoachName.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 50);
            this.label3.TabIndex = 0;
            this.label3.Text = "Huấn luyện viên:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.tbHost);
            this.panel8.Controls.Add(this.label4);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.panel8.Location = new System.Drawing.Point(0, 186);
            this.panel8.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(764, 50);
            this.panel8.TabIndex = 7;
            // 
            // tbHost
            // 
            this.tbHost.BorderThickness = 0;
            this.tbHost.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbHost.DefaultText = "";
            this.tbHost.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbHost.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbHost.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHost.DisabledState.Parent = this.tbHost;
            this.tbHost.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbHost.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbHost.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHost.FocusedState.Parent = this.tbHost;
            this.tbHost.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.tbHost.ForeColor = System.Drawing.Color.Black;
            this.tbHost.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbHost.HoverState.Parent = this.tbHost;
            this.tbHost.Location = new System.Drawing.Point(208, 0);
            this.tbHost.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.tbHost.Name = "tbHost";
            this.tbHost.PasswordChar = '\0';
            this.tbHost.PlaceholderText = "Tên sân nhà";
            this.tbHost.SelectedText = "";
            this.tbHost.ShadowDecoration.Parent = this.tbHost;
            this.tbHost.Size = new System.Drawing.Size(524, 50);
            this.tbHost.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Left;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(208, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Sân nhà:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // formAddNewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 814);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "formAddNewTeam";
            this.Text = "formAddNewTeam";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbTeamImage)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Panel panel3;
        private FontAwesome.Sharp.IconButton btnAdd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel6;
        private Guna.UI2.WinForms.Guna2TextBox tbTeamName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private Guna.UI2.WinForms.Guna2TextBox tbCoachName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel8;
        private Guna.UI2.WinForms.Guna2TextBox tbHost;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.PictureBox pbTeamImage;
        private FontAwesome.Sharp.IconButton btnUpload;
    }
}
namespace NationalFootballChampionshipManagement
{
    partial class formMuaGiai
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbNowTournament = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnAddNewTournaments = new FontAwesome.Sharp.IconButton();
            this.btnChange = new FontAwesome.Sharp.IconButton();
            this.cbLeague = new Guna.UI2.WinForms.Guna2ComboBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
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
            this.lTitle.TabIndex = 8;
            this.lTitle.Text = "Quản lý mùa giải";
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
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(57, 86);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbNowTournament);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 86);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1165, 82);
            this.panel2.TabIndex = 1;
            // 
            // lbNowTournament
            // 
            this.lbNowTournament.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbNowTournament.Font = new System.Drawing.Font("Segoe UI", 20F);
            this.lbNowTournament.Location = new System.Drawing.Point(0, 0);
            this.lbNowTournament.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNowTournament.Name = "lbNowTournament";
            this.lbNowTournament.Size = new System.Drawing.Size(1165, 82);
            this.lbNowTournament.TabIndex = 0;
            this.lbNowTournament.Text = "Mùa giải hiện tại: 2021";
            this.lbNowTournament.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 168);
            this.panel3.Margin = new System.Windows.Forms.Padding(4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1165, 160);
            this.panel3.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.cbLeague);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(412, 160);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thay đổi mùa giải";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.btnAddNewTournaments);
            this.panel4.Controls.Add(this.btnChange);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(187, 56);
            this.panel4.Margin = new System.Windows.Forms.Padding(4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(221, 100);
            this.panel4.TabIndex = 1;
            // 
            // btnAddNewTournaments
            // 
            this.btnAddNewTournaments.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.btnAddNewTournaments.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddNewTournaments.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddNewTournaments.FlatAppearance.BorderSize = 0;
            this.btnAddNewTournaments.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddNewTournaments.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnAddNewTournaments.ForeColor = System.Drawing.Color.White;
            this.btnAddNewTournaments.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddNewTournaments.IconColor = System.Drawing.Color.White;
            this.btnAddNewTournaments.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnAddNewTournaments.IconSize = 30;
            this.btnAddNewTournaments.Location = new System.Drawing.Point(0, 46);
            this.btnAddNewTournaments.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddNewTournaments.Name = "btnAddNewTournaments";
            this.btnAddNewTournaments.Size = new System.Drawing.Size(221, 46);
            this.btnAddNewTournaments.TabIndex = 1;
            this.btnAddNewTournaments.Text = "Tạo mùa giải mới";
            this.btnAddNewTournaments.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddNewTournaments.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddNewTournaments.UseVisualStyleBackColor = false;
            this.btnAddNewTournaments.Click += new System.EventHandler(this.btnAddNewTournaments_Click);
            // 
            // btnChange
            // 
            this.btnChange.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(128)))), ((int)(((byte)(190)))));
            this.btnChange.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChange.FlatAppearance.BorderSize = 0;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Semibold", 10.75F, System.Drawing.FontStyle.Bold);
            this.btnChange.ForeColor = System.Drawing.Color.White;
            this.btnChange.IconChar = FontAwesome.Sharp.IconChar.ExchangeAlt;
            this.btnChange.IconColor = System.Drawing.Color.White;
            this.btnChange.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnChange.IconSize = 30;
            this.btnChange.Location = new System.Drawing.Point(0, 0);
            this.btnChange.Margin = new System.Windows.Forms.Padding(4);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(221, 46);
            this.btnChange.TabIndex = 0;
            this.btnChange.Text = "Chuyển đổi";
            this.btnChange.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChange.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // cbLeague
            // 
            this.cbLeague.BackColor = System.Drawing.Color.Transparent;
            this.cbLeague.Dock = System.Windows.Forms.DockStyle.Top;
            this.cbLeague.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLeague.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLeague.FocusedColor = System.Drawing.Color.Empty;
            this.cbLeague.FocusedState.Parent = this.cbLeague;
            this.cbLeague.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.cbLeague.ForeColor = System.Drawing.Color.Black;
            this.cbLeague.FormattingEnabled = true;
            this.cbLeague.HoverState.Parent = this.cbLeague;
            this.cbLeague.ItemHeight = 30;
            this.cbLeague.Items.AddRange(new object[] {
            "Mùa giải 2021 ",
            "Mùa giải 2020",
            "Mùa giải 2019"});
            this.cbLeague.ItemsAppearance.Parent = this.cbLeague;
            this.cbLeague.Location = new System.Drawing.Point(4, 20);
            this.cbLeague.Margin = new System.Windows.Forms.Padding(4);
            this.cbLeague.Name = "cbLeague";
            this.cbLeague.ShadowDecoration.Parent = this.cbLeague;
            this.cbLeague.Size = new System.Drawing.Size(404, 36);
            this.cbLeague.StartIndex = 0;
            this.cbLeague.TabIndex = 0;
            // 
            // formMuaGiai
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1165, 814);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formMuaGiai";
            this.Text = "formMuaGiai";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI2.WinForms.Guna2ComboBox cbLeague;
        private System.Windows.Forms.Panel panel4;
        private FontAwesome.Sharp.IconButton btnAddNewTournaments;
        private FontAwesome.Sharp.IconButton btnChange;
        private System.Windows.Forms.Label lbNowTournament;
    }
}
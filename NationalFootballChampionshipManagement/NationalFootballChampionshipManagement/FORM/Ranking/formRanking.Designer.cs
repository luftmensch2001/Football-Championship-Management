namespace NationalFootballChampionshipManagement
{
    partial class formRanking
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlTitle = new System.Windows.Forms.Panel();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.tbTitle = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnlFill = new System.Windows.Forms.Panel();
            this.dgvRanking = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colCLB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMatches = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEqual = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfGoalsConceded = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCoefficient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colScores = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col5History = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlTitle.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.pnlTitle.Controls.Add(this.btnClose);
            this.pnlTitle.Controls.Add(this.tbTitle);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(842, 70);
            this.pnlTitle.TabIndex = 0;
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
            this.btnClose.TabIndex = 1;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // tbTitle
            // 
            this.tbTitle.BorderThickness = 0;
            this.tbTitle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbTitle.DefaultText = "Bảng xếp hạng";
            this.tbTitle.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbTitle.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbTitle.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTitle.DisabledState.Parent = this.tbTitle;
            this.tbTitle.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbTitle.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.tbTitle.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTitle.FocusedState.Parent = this.tbTitle;
            this.tbTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTitle.ForeColor = System.Drawing.Color.White;
            this.tbTitle.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbTitle.HoverState.Parent = this.tbTitle;
            this.tbTitle.Location = new System.Drawing.Point(0, 0);
            this.tbTitle.Margin = new System.Windows.Forms.Padding(6);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.PasswordChar = '\0';
            this.tbTitle.PlaceholderText = "";
            this.tbTitle.SelectedText = "";
            this.tbTitle.SelectionStart = 13;
            this.tbTitle.ShadowDecoration.Parent = this.tbTitle;
            this.tbTitle.Size = new System.Drawing.Size(842, 70);
            this.tbTitle.TabIndex = 0;
            this.tbTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pnlFill);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(842, 409);
            this.panel4.TabIndex = 1;
            // 
            // pnlFill
            // 
            this.pnlFill.Controls.Add(this.dgvRanking);
            this.pnlFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlFill.Location = new System.Drawing.Point(25, 0);
            this.pnlFill.Name = "pnlFill";
            this.pnlFill.Size = new System.Drawing.Size(792, 409);
            this.pnlFill.TabIndex = 3;
            // 
            // dgvRanking
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvRanking.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvRanking.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRanking.BackgroundColor = System.Drawing.Color.White;
            this.dgvRanking.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvRanking.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRanking.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvRanking.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvRanking.ColumnHeadersHeight = 35;
            this.dgvRanking.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colCLB,
            this.colMatches,
            this.colWin,
            this.colEqual,
            this.colLose,
            this.colNumberOfGoals,
            this.colNumberOfGoalsConceded,
            this.colCoefficient,
            this.colScores,
            this.col5History});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvRanking.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvRanking.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvRanking.EnableHeadersVisualStyles = false;
            this.dgvRanking.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRanking.Location = new System.Drawing.Point(0, 0);
            this.dgvRanking.Name = "dgvRanking";
            this.dgvRanking.RowHeadersVisible = false;
            this.dgvRanking.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRanking.Size = new System.Drawing.Size(792, 409);
            this.dgvRanking.TabIndex = 0;
            this.dgvRanking.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvRanking.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRanking.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvRanking.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvRanking.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvRanking.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvRanking.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvRanking.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRanking.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvRanking.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvRanking.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRanking.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvRanking.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvRanking.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvRanking.ThemeStyle.ReadOnly = false;
            this.dgvRanking.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvRanking.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvRanking.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvRanking.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvRanking.ThemeStyle.RowsStyle.Height = 22;
            this.dgvRanking.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvRanking.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colCLB
            // 
            this.colCLB.FillWeight = 450.9696F;
            this.colCLB.HeaderText = "Câu lạc bộ";
            this.colCLB.Name = "colCLB";
            this.colCLB.ReadOnly = true;
            // 
            // colMatches
            // 
            this.colMatches.FillWeight = 45.68528F;
            this.colMatches.HeaderText = "ĐĐ";
            this.colMatches.Name = "colMatches";
            this.colMatches.ReadOnly = true;
            // 
            // colWin
            // 
            this.colWin.FillWeight = 46.60886F;
            this.colWin.HeaderText = "Thắng";
            this.colWin.Name = "colWin";
            this.colWin.ReadOnly = true;
            // 
            // colEqual
            // 
            this.colEqual.FillWeight = 47.40521F;
            this.colEqual.HeaderText = "Hòa";
            this.colEqual.Name = "colEqual";
            this.colEqual.ReadOnly = true;
            // 
            // colLose
            // 
            this.colLose.FillWeight = 48.07418F;
            this.colLose.HeaderText = "Thua";
            this.colLose.Name = "colLose";
            this.colLose.ReadOnly = true;
            // 
            // colNumberOfGoals
            // 
            this.colNumberOfGoals.FillWeight = 48.615F;
            this.colNumberOfGoals.HeaderText = "BT";
            this.colNumberOfGoals.Name = "colNumberOfGoals";
            this.colNumberOfGoals.ReadOnly = true;
            // 
            // colNumberOfGoalsConceded
            // 
            this.colNumberOfGoalsConceded.FillWeight = 49.02624F;
            this.colNumberOfGoalsConceded.HeaderText = "SBT";
            this.colNumberOfGoalsConceded.Name = "colNumberOfGoalsConceded";
            this.colNumberOfGoalsConceded.ReadOnly = true;
            // 
            // colCoefficient
            // 
            this.colCoefficient.FillWeight = 49.30579F;
            this.colCoefficient.HeaderText = "HS";
            this.colCoefficient.Name = "colCoefficient";
            this.colCoefficient.ReadOnly = true;
            // 
            // colScores
            // 
            this.colScores.FillWeight = 49.45081F;
            this.colScores.HeaderText = "Đ";
            this.colScores.Name = "colScores";
            this.colScores.ReadOnly = true;
            // 
            // col5History
            // 
            this.col5History.FillWeight = 164.859F;
            this.col5History.HeaderText = "5 trận gần nhất";
            this.col5History.Name = "col5History";
            this.col5History.ReadOnly = true;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(817, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(25, 409);
            this.panel2.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(25, 409);
            this.panel1.TabIndex = 1;
            // 
            // formRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(842, 479);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pnlTitle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formRanking";
            this.Text = "formRanking";
            this.pnlTitle.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvRanking)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlTitle;
        private Guna.UI2.WinForms.Guna2TextBox tbTitle;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnlFill;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2DataGridView dgvRanking;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCLB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEqual;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLose;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfGoals;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfGoalsConceded;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCoefficient;
        private System.Windows.Forms.DataGridViewTextBoxColumn colScores;
        private System.Windows.Forms.DataGridViewTextBoxColumn col5History;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}
namespace NationalFootballChampionshipManagement
{
    partial class formPlayerList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lTitle = new System.Windows.Forms.Label();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.panel11 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dgvPlayerList = new Guna.UI2.WinForms.Guna2DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTeam = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTypeOfPlayer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNumberOfGoals = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panelType = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.panelsfsdf = new System.Windows.Forms.Panel();
            this.panelTeam = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btSearch = new FontAwesome.Sharp.IconButton();
            this.tbNamePlayer = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel15 = new System.Windows.Forms.Panel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new FontAwesome.Sharp.IconButton();
            this.panel1.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerList)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panelsfsdf.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.panel1.Controls.Add(this.lTitle);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(858, 70);
            this.panel1.TabIndex = 0;
            // 
            // lTitle
            // 
            this.lTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, System.Drawing.FontStyle.Bold);
            this.lTitle.ForeColor = System.Drawing.Color.White;
            this.lTitle.Location = new System.Drawing.Point(43, 0);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(815, 70);
            this.lTitle.TabIndex = 7;
            this.lTitle.Text = "Danh sách cầu thủ";
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
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(43, 70);
            this.btnClose.TabIndex = 3;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.panel10);
            this.panel11.Controls.Add(this.panel2);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(0, 70);
            this.panel11.Name = "panel11";
            this.panel11.Size = new System.Drawing.Size(858, 552);
            this.panel11.TabIndex = 5;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dgvPlayerList);
            this.panel10.Controls.Add(this.label2);
            this.panel10.Controls.Add(this.panel3);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(858, 514);
            this.panel10.TabIndex = 2;
            // 
            // dgvPlayerList
            // 
            this.dgvPlayerList.AllowUserToAddRows = false;
            this.dgvPlayerList.AllowUserToDeleteRows = false;
            this.dgvPlayerList.AllowUserToResizeColumns = false;
            this.dgvPlayerList.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.dgvPlayerList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvPlayerList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPlayerList.BackgroundColor = System.Drawing.Color.White;
            this.dgvPlayerList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPlayerList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlayerList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPlayerList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvPlayerList.ColumnHeadersHeight = 35;
            this.dgvPlayerList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colName,
            this.colTeam,
            this.colTypeOfPlayer,
            this.colNumberOfGoals});
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvPlayerList.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvPlayerList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPlayerList.EnableHeadersVisualStyles = false;
            this.dgvPlayerList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayerList.Location = new System.Drawing.Point(0, 0);
            this.dgvPlayerList.Name = "dgvPlayerList";
            this.dgvPlayerList.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dgvPlayerList.RowHeadersVisible = false;
            this.dgvPlayerList.RowHeadersWidth = 51;
            this.dgvPlayerList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPlayerList.Size = new System.Drawing.Size(658, 514);
            this.dgvPlayerList.TabIndex = 6;
            this.dgvPlayerList.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.dgvPlayerList.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayerList.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvPlayerList.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvPlayerList.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvPlayerList.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvPlayerList.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayerList.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayerList.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvPlayerList.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvPlayerList.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPlayerList.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvPlayerList.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvPlayerList.ThemeStyle.HeaderStyle.Height = 35;
            this.dgvPlayerList.ThemeStyle.ReadOnly = false;
            this.dgvPlayerList.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvPlayerList.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvPlayerList.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgvPlayerList.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvPlayerList.ThemeStyle.RowsStyle.Height = 22;
            this.dgvPlayerList.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvPlayerList.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            // 
            // colName
            // 
            this.colName.HeaderText = "Cầu thủ";
            this.colName.MinimumWidth = 6;
            this.colName.Name = "colName";
            // 
            // colTeam
            // 
            this.colTeam.HeaderText = "Đội";
            this.colTeam.MinimumWidth = 6;
            this.colTeam.Name = "colTeam";
            // 
            // colTypeOfPlayer
            // 
            this.colTypeOfPlayer.HeaderText = "Loại cầu thủ";
            this.colTypeOfPlayer.MinimumWidth = 6;
            this.colTypeOfPlayer.Name = "colTypeOfPlayer";
            // 
            // colNumberOfGoals
            // 
            this.colNumberOfGoals.HeaderText = "Tổng số bàn thắng";
            this.colNumberOfGoals.MinimumWidth = 6;
            this.colNumberOfGoals.Name = "colNumberOfGoals";
            this.colNumberOfGoals.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.DarkGray;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(438, 394);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(176, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại cầu thủ";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panelsfsdf);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(658, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 514);
            this.panel3.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel6.Controls.Add(this.panelType);
            this.panel6.Controls.Add(this.panel8);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 317);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(200, 197);
            this.panel6.TabIndex = 2;
            // 
            // panelType
            // 
            this.panelType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelType.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelType.Location = new System.Drawing.Point(43, 36);
            this.panelType.Name = "panelType";
            this.panelType.Size = new System.Drawing.Size(157, 161);
            this.panelType.TabIndex = 5;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(0, 36);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(43, 161);
            this.panel8.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.DarkGray;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 36);
            this.label5.TabIndex = 3;
            this.label5.Text = "Loại cầu thủ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelsfsdf
            // 
            this.panelsfsdf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelsfsdf.Controls.Add(this.panelTeam);
            this.panelsfsdf.Controls.Add(this.panel9);
            this.panelsfsdf.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelsfsdf.Location = new System.Drawing.Point(0, 155);
            this.panelsfsdf.Name = "panelsfsdf";
            this.panelsfsdf.Size = new System.Drawing.Size(200, 162);
            this.panelsfsdf.TabIndex = 1;
            // 
            // panelTeam
            // 
            this.panelTeam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panelTeam.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTeam.Location = new System.Drawing.Point(43, 0);
            this.panelTeam.Name = "panelTeam";
            this.panelTeam.Size = new System.Drawing.Size(157, 162);
            this.panelTeam.TabIndex = 5;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel9.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel9.Location = new System.Drawing.Point(0, 0);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(43, 162);
            this.panel9.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label1);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 155);
            this.panel4.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.DarkGray;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(0, 119);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(200, 36);
            this.label1.TabIndex = 2;
            this.label1.Text = "Đội bóng";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.panel7.Controls.Add(this.btSearch);
            this.panel7.Controls.Add(this.tbNamePlayer);
            this.panel7.Controls.Add(this.panel15);
            this.panel7.Controls.Add(this.panel14);
            this.panel7.Controls.Add(this.panel13);
            this.panel7.Controls.Add(this.panel12);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 70);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(200, 49);
            this.panel7.TabIndex = 4;
            // 
            // btSearch
            // 
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(246)))), ((int)(((byte)(248)))));
            this.btSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btSearch.ForeColor = System.Drawing.Color.Coral;
            this.btSearch.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btSearch.IconColor = System.Drawing.Color.Black;
            this.btSearch.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btSearch.IconSize = 25;
            this.btSearch.Location = new System.Drawing.Point(156, 7);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(39, 35);
            this.btSearch.TabIndex = 5;
            this.btSearch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbNamePlayer
            // 
            this.tbNamePlayer.AutoRoundedCorners = true;
            this.tbNamePlayer.BorderRadius = 16;
            this.tbNamePlayer.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.tbNamePlayer.DefaultText = "";
            this.tbNamePlayer.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.tbNamePlayer.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.tbNamePlayer.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamePlayer.DisabledState.Parent = this.tbNamePlayer;
            this.tbNamePlayer.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.tbNamePlayer.Dock = System.Windows.Forms.DockStyle.Left;
            this.tbNamePlayer.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamePlayer.FocusedState.Parent = this.tbNamePlayer;
            this.tbNamePlayer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.tbNamePlayer.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.tbNamePlayer.HoverState.Parent = this.tbNamePlayer;
            this.tbNamePlayer.Location = new System.Drawing.Point(5, 7);
            this.tbNamePlayer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbNamePlayer.Name = "tbNamePlayer";
            this.tbNamePlayer.PasswordChar = '\0';
            this.tbNamePlayer.PlaceholderText = "Nguyễn Văn A";
            this.tbNamePlayer.SelectedText = "";
            this.tbNamePlayer.ShadowDecoration.Parent = this.tbNamePlayer;
            this.tbNamePlayer.Size = new System.Drawing.Size(145, 35);
            this.tbNamePlayer.TabIndex = 4;
            // 
            // panel15
            // 
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(195, 7);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(5, 35);
            this.panel15.TabIndex = 3;
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(0, 7);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(5, 35);
            this.panel14.TabIndex = 2;
            // 
            // panel13
            // 
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(0, 42);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(200, 7);
            this.panel13.TabIndex = 1;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel12.Location = new System.Drawing.Point(0, 0);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(200, 7);
            this.panel12.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.DarkGray;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(0, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 35);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tên cầu thủ";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 18F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(0, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(200, 35);
            this.label3.TabIndex = 1;
            this.label3.Text = "Bảng Tra cứu";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 514);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(858, 38);
            this.panel2.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(194)))), ((int)(((byte)(138)))));
            this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.FlatAppearance.BorderSize = 0;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.IconChar = FontAwesome.Sharp.IconChar.Archive;
            this.btnSave.IconColor = System.Drawing.Color.White;
            this.btnSave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSave.IconSize = 25;
            this.btnSave.Location = new System.Drawing.Point(740, 0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 38);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "In";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // formPlayerList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(858, 622);
            this.Controls.Add(this.panel11);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "formPlayerList";
            this.Text = "formPlayerList";
            this.panel1.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPlayerList)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panelsfsdf.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnSave;
        private FontAwesome.Sharp.IconButton btnClose;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panelsfsdf;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel9;
        private Guna.UI2.WinForms.Guna2DataGridView dgvPlayerList;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTeam;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTypeOfPlayer;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNumberOfGoals;
        private FontAwesome.Sharp.IconButton btSearch;
        private Guna.UI2.WinForms.Guna2TextBox tbNamePlayer;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panelType;
        private System.Windows.Forms.Panel panelTeam;
    }
}
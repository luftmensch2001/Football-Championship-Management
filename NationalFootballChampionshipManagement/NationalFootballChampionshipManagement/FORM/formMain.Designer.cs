namespace NationalFootballChampionshipManagement
{
    partial class formMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnHelp = new FontAwesome.Sharp.IconButton();
            this.pnlSubToolsMenu = new System.Windows.Forms.Panel();
            this.btnRankingTools = new FontAwesome.Sharp.IconButton();
            this.btnScoresTools = new FontAwesome.Sharp.IconButton();
            this.btnChampionshipTools = new FontAwesome.Sharp.IconButton();
            this.btnTools = new FontAwesome.Sharp.IconButton();
            this.pnlSubFileMenu = new System.Windows.Forms.Panel();
            this.btnPlayerFile = new FontAwesome.Sharp.IconButton();
            this.btnTeamFile = new FontAwesome.Sharp.IconButton();
            this.btnFile = new FontAwesome.Sharp.IconButton();
            this.btnRankingChart = new FontAwesome.Sharp.IconButton();
            this.pnlSubResultMenu = new System.Windows.Forms.Panel();
            this.btnResultHistory = new FontAwesome.Sharp.IconButton();
            this.btnRecordResult = new FontAwesome.Sharp.IconButton();
            this.btnResult = new FontAwesome.Sharp.IconButton();
            this.btnCompetitionSchedule = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelChampionshipLogo = new System.Windows.Forms.Panel();
            this.pnlChildForm = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlSubToolsMenu.SuspendLayout();
            this.pnlSubFileMenu.SuspendLayout();
            this.pnlSubResultMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.AutoScroll = true;
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelChampionshipLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(280, 814);
            this.panelMenu.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnHelp);
            this.panel2.Controls.Add(this.pnlSubToolsMenu);
            this.panel2.Controls.Add(this.btnTools);
            this.panel2.Controls.Add(this.pnlSubFileMenu);
            this.panel2.Controls.Add(this.btnFile);
            this.panel2.Controls.Add(this.btnRankingChart);
            this.panel2.Controls.Add(this.pnlSubResultMenu);
            this.panel2.Controls.Add(this.btnResult);
            this.panel2.Controls.Add(this.btnCompetitionSchedule);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 69);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(280, 745);
            this.panel2.TabIndex = 11;
            this.panel2.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.Color.Transparent;
            this.btnHelp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnHelp.FlatAppearance.BorderSize = 0;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Font = new System.Drawing.Font("TUV Coco Gothic", 13F);
            this.btnHelp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnHelp.IconChar = FontAwesome.Sharp.IconChar.Info;
            this.btnHelp.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnHelp.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnHelp.IconSize = 35;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(0, 622);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(280, 49);
            this.btnHelp.TabIndex = 19;
            this.btnHelp.Text = "Trợ giúp";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // pnlSubToolsMenu
            // 
            this.pnlSubToolsMenu.Controls.Add(this.btnRankingTools);
            this.pnlSubToolsMenu.Controls.Add(this.btnScoresTools);
            this.pnlSubToolsMenu.Controls.Add(this.btnChampionshipTools);
            this.pnlSubToolsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubToolsMenu.Location = new System.Drawing.Point(0, 461);
            this.pnlSubToolsMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSubToolsMenu.Name = "pnlSubToolsMenu";
            this.pnlSubToolsMenu.Size = new System.Drawing.Size(280, 161);
            this.pnlSubToolsMenu.TabIndex = 18;
            // 
            // btnRankingTools
            // 
            this.btnRankingTools.BackColor = System.Drawing.Color.Transparent;
            this.btnRankingTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRankingTools.FlatAppearance.BorderSize = 0;
            this.btnRankingTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankingTools.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnRankingTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnRankingTools.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnRankingTools.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnRankingTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRankingTools.IconSize = 25;
            this.btnRankingTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankingTools.Location = new System.Drawing.Point(0, 98);
            this.btnRankingTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRankingTools.Name = "btnRankingTools";
            this.btnRankingTools.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRankingTools.Size = new System.Drawing.Size(280, 49);
            this.btnRankingTools.TabIndex = 10;
            this.btnRankingTools.Text = "Quy định xếp hạng";
            this.btnRankingTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankingTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankingTools.UseVisualStyleBackColor = false;
            this.btnRankingTools.Click += new System.EventHandler(this.btnRankingTools_Click);
            // 
            // btnScoresTools
            // 
            this.btnScoresTools.BackColor = System.Drawing.Color.Transparent;
            this.btnScoresTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnScoresTools.FlatAppearance.BorderSize = 0;
            this.btnScoresTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScoresTools.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnScoresTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnScoresTools.IconChar = FontAwesome.Sharp.IconChar.Angular;
            this.btnScoresTools.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnScoresTools.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnScoresTools.IconSize = 25;
            this.btnScoresTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoresTools.Location = new System.Drawing.Point(0, 49);
            this.btnScoresTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnScoresTools.Name = "btnScoresTools";
            this.btnScoresTools.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnScoresTools.Size = new System.Drawing.Size(280, 49);
            this.btnScoresTools.TabIndex = 9;
            this.btnScoresTools.Text = "Quy định điểm số";
            this.btnScoresTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnScoresTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScoresTools.UseVisualStyleBackColor = false;
            this.btnScoresTools.Click += new System.EventHandler(this.btnScoresTools_Click);
            // 
            // btnChampionshipTools
            // 
            this.btnChampionshipTools.BackColor = System.Drawing.Color.Transparent;
            this.btnChampionshipTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnChampionshipTools.FlatAppearance.BorderSize = 0;
            this.btnChampionshipTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChampionshipTools.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnChampionshipTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnChampionshipTools.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btnChampionshipTools.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnChampionshipTools.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnChampionshipTools.IconSize = 25;
            this.btnChampionshipTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChampionshipTools.Location = new System.Drawing.Point(0, 0);
            this.btnChampionshipTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnChampionshipTools.Name = "btnChampionshipTools";
            this.btnChampionshipTools.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnChampionshipTools.Size = new System.Drawing.Size(280, 49);
            this.btnChampionshipTools.TabIndex = 8;
            this.btnChampionshipTools.Text = "Quy định giải đấu";
            this.btnChampionshipTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnChampionshipTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnChampionshipTools.UseVisualStyleBackColor = false;
            this.btnChampionshipTools.Click += new System.EventHandler(this.btnChampionshipTools_Click);
            // 
            // btnTools
            // 
            this.btnTools.BackColor = System.Drawing.Color.Transparent;
            this.btnTools.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTools.FlatAppearance.BorderSize = 0;
            this.btnTools.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTools.Font = new System.Drawing.Font("TUV Coco Gothic", 13F);
            this.btnTools.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnTools.IconChar = FontAwesome.Sharp.IconChar.Tools;
            this.btnTools.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnTools.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTools.IconSize = 35;
            this.btnTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.Location = new System.Drawing.Point(0, 412);
            this.btnTools.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTools.Name = "btnTools";
            this.btnTools.Size = new System.Drawing.Size(280, 49);
            this.btnTools.TabIndex = 17;
            this.btnTools.Text = "Quy định";
            this.btnTools.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTools.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTools.UseVisualStyleBackColor = false;
            this.btnTools.Click += new System.EventHandler(this.btnTools_Click);
            // 
            // pnlSubFileMenu
            // 
            this.pnlSubFileMenu.Controls.Add(this.btnPlayerFile);
            this.pnlSubFileMenu.Controls.Add(this.btnTeamFile);
            this.pnlSubFileMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubFileMenu.Location = new System.Drawing.Point(0, 304);
            this.pnlSubFileMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSubFileMenu.Name = "pnlSubFileMenu";
            this.pnlSubFileMenu.Size = new System.Drawing.Size(280, 108);
            this.pnlSubFileMenu.TabIndex = 16;
            // 
            // btnPlayerFile
            // 
            this.btnPlayerFile.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayerFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlayerFile.FlatAppearance.BorderSize = 0;
            this.btnPlayerFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlayerFile.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnPlayerFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnPlayerFile.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnPlayerFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnPlayerFile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnPlayerFile.IconSize = 25;
            this.btnPlayerFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayerFile.Location = new System.Drawing.Point(0, 49);
            this.btnPlayerFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlayerFile.Name = "btnPlayerFile";
            this.btnPlayerFile.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnPlayerFile.Size = new System.Drawing.Size(280, 49);
            this.btnPlayerFile.TabIndex = 8;
            this.btnPlayerFile.Text = "Cầu thủ";
            this.btnPlayerFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPlayerFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPlayerFile.UseVisualStyleBackColor = false;
            this.btnPlayerFile.Click += new System.EventHandler(this.btnPlayerFile_Click);
            // 
            // btnTeamFile
            // 
            this.btnTeamFile.BackColor = System.Drawing.Color.Transparent;
            this.btnTeamFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTeamFile.FlatAppearance.BorderSize = 0;
            this.btnTeamFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTeamFile.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnTeamFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnTeamFile.IconChar = FontAwesome.Sharp.IconChar.Users;
            this.btnTeamFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnTeamFile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnTeamFile.IconSize = 25;
            this.btnTeamFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamFile.Location = new System.Drawing.Point(0, 0);
            this.btnTeamFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTeamFile.Name = "btnTeamFile";
            this.btnTeamFile.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnTeamFile.Size = new System.Drawing.Size(280, 49);
            this.btnTeamFile.TabIndex = 7;
            this.btnTeamFile.Text = "Đội bóng";
            this.btnTeamFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTeamFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTeamFile.UseVisualStyleBackColor = false;
            this.btnTeamFile.Click += new System.EventHandler(this.btnTeamFile_Click);
            // 
            // btnFile
            // 
            this.btnFile.BackColor = System.Drawing.Color.Transparent;
            this.btnFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFile.FlatAppearance.BorderSize = 0;
            this.btnFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFile.Font = new System.Drawing.Font("TUV Coco Gothic", 13F);
            this.btnFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnFile.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnFile.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnFile.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnFile.IconSize = 35;
            this.btnFile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.Location = new System.Drawing.Point(0, 255);
            this.btnFile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnFile.Name = "btnFile";
            this.btnFile.Size = new System.Drawing.Size(280, 49);
            this.btnFile.TabIndex = 15;
            this.btnFile.Text = "Hồ sơ";
            this.btnFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFile.UseVisualStyleBackColor = false;
            this.btnFile.Click += new System.EventHandler(this.btnFile_Click);
            // 
            // btnRankingChart
            // 
            this.btnRankingChart.BackColor = System.Drawing.Color.Transparent;
            this.btnRankingChart.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRankingChart.FlatAppearance.BorderSize = 0;
            this.btnRankingChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRankingChart.Font = new System.Drawing.Font("TUV Coco Gothic", 13F);
            this.btnRankingChart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnRankingChart.IconChar = FontAwesome.Sharp.IconChar.ChartBar;
            this.btnRankingChart.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnRankingChart.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRankingChart.IconSize = 35;
            this.btnRankingChart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankingChart.Location = new System.Drawing.Point(0, 206);
            this.btnRankingChart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRankingChart.Name = "btnRankingChart";
            this.btnRankingChart.Size = new System.Drawing.Size(280, 49);
            this.btnRankingChart.TabIndex = 12;
            this.btnRankingChart.Text = "Bảng xếp hạng";
            this.btnRankingChart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRankingChart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRankingChart.UseVisualStyleBackColor = false;
            this.btnRankingChart.Click += new System.EventHandler(this.btnRankingChart_Click);
            // 
            // pnlSubResultMenu
            // 
            this.pnlSubResultMenu.Controls.Add(this.btnResultHistory);
            this.pnlSubResultMenu.Controls.Add(this.btnRecordResult);
            this.pnlSubResultMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSubResultMenu.Location = new System.Drawing.Point(0, 98);
            this.pnlSubResultMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlSubResultMenu.Name = "pnlSubResultMenu";
            this.pnlSubResultMenu.Size = new System.Drawing.Size(280, 108);
            this.pnlSubResultMenu.TabIndex = 11;
            // 
            // btnResultHistory
            // 
            this.btnResultHistory.BackColor = System.Drawing.Color.Transparent;
            this.btnResultHistory.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResultHistory.FlatAppearance.BorderSize = 0;
            this.btnResultHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResultHistory.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnResultHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnResultHistory.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btnResultHistory.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnResultHistory.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnResultHistory.IconSize = 25;
            this.btnResultHistory.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultHistory.Location = new System.Drawing.Point(0, 49);
            this.btnResultHistory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResultHistory.Name = "btnResultHistory";
            this.btnResultHistory.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnResultHistory.Size = new System.Drawing.Size(280, 49);
            this.btnResultHistory.TabIndex = 9;
            this.btnResultHistory.Text = "Kết quả thi đấu";
            this.btnResultHistory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResultHistory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResultHistory.UseVisualStyleBackColor = false;
            this.btnResultHistory.Click += new System.EventHandler(this.btnResultHistory_Click);
            // 
            // btnRecordResult
            // 
            this.btnRecordResult.BackColor = System.Drawing.Color.Transparent;
            this.btnRecordResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecordResult.FlatAppearance.BorderSize = 0;
            this.btnRecordResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecordResult.Font = new System.Drawing.Font("TUV Coco Gothic", 10F);
            this.btnRecordResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnRecordResult.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnRecordResult.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnRecordResult.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.btnRecordResult.IconSize = 25;
            this.btnRecordResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordResult.Location = new System.Drawing.Point(0, 0);
            this.btnRecordResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRecordResult.Name = "btnRecordResult";
            this.btnRecordResult.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnRecordResult.Size = new System.Drawing.Size(280, 49);
            this.btnRecordResult.TabIndex = 8;
            this.btnRecordResult.Text = "Ghi nhận kết quả";
            this.btnRecordResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecordResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecordResult.UseVisualStyleBackColor = false;
            this.btnRecordResult.Click += new System.EventHandler(this.btnRecordResult_Click);
            // 
            // btnResult
            // 
            this.btnResult.BackColor = System.Drawing.Color.Transparent;
            this.btnResult.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnResult.FlatAppearance.BorderSize = 0;
            this.btnResult.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnResult.Font = new System.Drawing.Font("TUV Coco Gothic", 13F);
            this.btnResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnResult.IconChar = FontAwesome.Sharp.IconChar.Trophy;
            this.btnResult.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnResult.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnResult.IconSize = 35;
            this.btnResult.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.Location = new System.Drawing.Point(0, 49);
            this.btnResult.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnResult.Name = "btnResult";
            this.btnResult.Size = new System.Drawing.Size(280, 49);
            this.btnResult.TabIndex = 10;
            this.btnResult.Text = "Kết quả thi đấu";
            this.btnResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnResult.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnResult.UseVisualStyleBackColor = false;
            this.btnResult.Click += new System.EventHandler(this.btnResult_Click);
            // 
            // btnCompetitionSchedule
            // 
            this.btnCompetitionSchedule.BackColor = System.Drawing.Color.Transparent;
            this.btnCompetitionSchedule.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCompetitionSchedule.FlatAppearance.BorderSize = 0;
            this.btnCompetitionSchedule.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompetitionSchedule.Font = new System.Drawing.Font("TUV Coco Gothic", 13F);
            this.btnCompetitionSchedule.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnCompetitionSchedule.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.btnCompetitionSchedule.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(113)))), ((int)(((byte)(121)))));
            this.btnCompetitionSchedule.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCompetitionSchedule.IconSize = 35;
            this.btnCompetitionSchedule.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetitionSchedule.Location = new System.Drawing.Point(0, 0);
            this.btnCompetitionSchedule.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCompetitionSchedule.Name = "btnCompetitionSchedule";
            this.btnCompetitionSchedule.Size = new System.Drawing.Size(280, 49);
            this.btnCompetitionSchedule.TabIndex = 3;
            this.btnCompetitionSchedule.Text = "Lập lịch thi đấu";
            this.btnCompetitionSchedule.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCompetitionSchedule.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCompetitionSchedule.UseVisualStyleBackColor = false;
            this.btnCompetitionSchedule.Click += new System.EventHandler(this.btnCompetitionSchedule_Click);
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 68);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 1);
            this.panel1.TabIndex = 10;
            // 
            // panelChampionshipLogo
            // 
            this.panelChampionshipLogo.BackColor = System.Drawing.Color.White;
            this.panelChampionshipLogo.BackgroundImage = global::NationalFootballChampionshipManagement.Properties.Resources.LS_V_League_Logo;
            this.panelChampionshipLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelChampionshipLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelChampionshipLogo.Location = new System.Drawing.Point(0, 0);
            this.panelChampionshipLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelChampionshipLogo.Name = "panelChampionshipLogo";
            this.panelChampionshipLogo.Size = new System.Drawing.Size(280, 68);
            this.panelChampionshipLogo.TabIndex = 0;
            // 
            // pnlChildForm
            // 
            this.pnlChildForm.BackColor = System.Drawing.Color.White;
            this.pnlChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChildForm.Location = new System.Drawing.Point(280, 0);
            this.pnlChildForm.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlChildForm.Name = "pnlChildForm";
            this.pnlChildForm.Size = new System.Drawing.Size(1165, 814);
            this.pnlChildForm.TabIndex = 2;
            // 
            // formMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 814);
            this.Controls.Add(this.pnlChildForm);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(1461, 851);
            this.Name = "formMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm quản lý giải bóng đá vô địch quốc gia";
            this.panelMenu.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlSubToolsMenu.ResumeLayout(false);
            this.pnlSubFileMenu.ResumeLayout(false);
            this.pnlSubResultMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelChampionshipLogo;
        private System.Windows.Forms.Panel pnlChildForm;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconButton btnCompetitionSchedule;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton btnResult;
        private FontAwesome.Sharp.IconButton btnHelp;
        private System.Windows.Forms.Panel pnlSubToolsMenu;
        private FontAwesome.Sharp.IconButton btnRankingTools;
        private FontAwesome.Sharp.IconButton btnScoresTools;
        private FontAwesome.Sharp.IconButton btnChampionshipTools;
        private FontAwesome.Sharp.IconButton btnTools;
        private System.Windows.Forms.Panel pnlSubFileMenu;
        private FontAwesome.Sharp.IconButton btnPlayerFile;
        private FontAwesome.Sharp.IconButton btnTeamFile;
        private FontAwesome.Sharp.IconButton btnFile;
        private FontAwesome.Sharp.IconButton btnRankingChart;
        private System.Windows.Forms.Panel pnlSubResultMenu;
        private FontAwesome.Sharp.IconButton btnResultHistory;
        private FontAwesome.Sharp.IconButton btnRecordResult;
    }
}


namespace NationalFootballChampionshipManagement
{
    partial class formHome
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formHome));
            this.lbTimeNow = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.timerNow = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTimeNow
            // 
            this.lbTimeNow.AutoSize = true;
            this.lbTimeNow.BackColor = System.Drawing.Color.Transparent;
            this.lbTimeNow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTimeNow.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.lbTimeNow.ForeColor = System.Drawing.Color.White;
            this.lbTimeNow.Location = new System.Drawing.Point(0, 173);
            this.lbTimeNow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTimeNow.Name = "lbTimeNow";
            this.lbTimeNow.Size = new System.Drawing.Size(136, 57);
            this.lbTimeNow.TabIndex = 0;
            this.lbTimeNow.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbTimeNow);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 324);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1067, 230);
            this.panel1.TabIndex = 1;
            // 
            // timerNow
            // 
            this.timerNow.Tick += new System.EventHandler(this.timerNow_Tick);
            // 
            // formHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formHome";
            this.Text = "formHome";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbTimeNow;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Timer timerNow;
    }
}
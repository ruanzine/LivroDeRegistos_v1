namespace LivroDeRegistos_v1.gui
{
    partial class Panel_Help
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Panel_Help));
            this.pnlManual = new System.Windows.Forms.Panel();
            this.lblManual = new System.Windows.Forms.Label();
            this.pnlHelp_title = new System.Windows.Forms.Panel();
            this.lblHelp_Title = new System.Windows.Forms.Label();
            this.pnlSideHelp = new System.Windows.Forms.Panel();
            this.pnlBaseHelp = new System.Windows.Forms.Panel();
            this.pnlManual.SuspendLayout();
            this.pnlHelp_title.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlManual
            // 
            this.pnlManual.BackColor = System.Drawing.Color.Silver;
            this.pnlManual.Controls.Add(this.pnlBaseHelp);
            this.pnlManual.Controls.Add(this.pnlSideHelp);
            this.pnlManual.Controls.Add(this.pnlHelp_title);
            this.pnlManual.Controls.Add(this.lblManual);
            this.pnlManual.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlManual.Location = new System.Drawing.Point(0, 0);
            this.pnlManual.Name = "pnlManual";
            this.pnlManual.Size = new System.Drawing.Size(1190, 705);
            this.pnlManual.TabIndex = 2;
            // 
            // lblManual
            // 
            this.lblManual.BackColor = System.Drawing.Color.Silver;
            this.lblManual.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblManual.Location = new System.Drawing.Point(40, 32);
            this.lblManual.Name = "lblManual";
            this.lblManual.Size = new System.Drawing.Size(1024, 640);
            this.lblManual.TabIndex = 0;
            this.lblManual.Text = resources.GetString("lblManual.Text");
            this.lblManual.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnlHelp_title
            // 
            this.pnlHelp_title.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlHelp_title.Controls.Add(this.lblHelp_Title);
            this.pnlHelp_title.Location = new System.Drawing.Point(440, 8);
            this.pnlHelp_title.Name = "pnlHelp_title";
            this.pnlHelp_title.Size = new System.Drawing.Size(264, 56);
            this.pnlHelp_title.TabIndex = 23;
            // 
            // lblHelp_Title
            // 
            this.lblHelp_Title.AutoSize = true;
            this.lblHelp_Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp_Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblHelp_Title.Location = new System.Drawing.Point(16, 16);
            this.lblHelp_Title.Name = "lblHelp_Title";
            this.lblHelp_Title.Size = new System.Drawing.Size(78, 24);
            this.lblHelp_Title.TabIndex = 11;
            this.lblHelp_Title.Text = "Manual";
            // 
            // pnlSideHelp
            // 
            this.pnlSideHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.pnlSideHelp.Location = new System.Drawing.Point(432, 16);
            this.pnlSideHelp.Name = "pnlSideHelp";
            this.pnlSideHelp.Size = new System.Drawing.Size(8, 48);
            this.pnlSideHelp.TabIndex = 25;
            // 
            // pnlBaseHelp
            // 
            this.pnlBaseHelp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.pnlBaseHelp.Location = new System.Drawing.Point(432, 64);
            this.pnlBaseHelp.Name = "pnlBaseHelp";
            this.pnlBaseHelp.Size = new System.Drawing.Size(264, 8);
            this.pnlBaseHelp.TabIndex = 26;
            // 
            // Panel_Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1190, 705);
            this.Controls.Add(this.pnlManual);
            this.Name = "Panel_Help";
            this.Text = "Panel_Help";
            this.pnlManual.ResumeLayout(false);
            this.pnlHelp_title.ResumeLayout(false);
            this.pnlHelp_title.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlManual;
        private System.Windows.Forms.Label lblManual;
        private System.Windows.Forms.Panel pnlHelp_title;
        private System.Windows.Forms.Label lblHelp_Title;
        private System.Windows.Forms.Panel pnlSideHelp;
        private System.Windows.Forms.Panel pnlBaseHelp;
    }
}
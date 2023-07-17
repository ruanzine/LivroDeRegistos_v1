namespace LivroDeRegistos_v1
{
    partial class SelectListing
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
            this.pnlChooseListing = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bttDateListing = new System.Windows.Forms.Button();
            this.bttNormalListing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlChooseListing.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlChooseListing
            // 
            this.pnlChooseListing.BackColor = System.Drawing.Color.Silver;
            this.pnlChooseListing.Controls.Add(this.groupBox2);
            this.pnlChooseListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlChooseListing.Location = new System.Drawing.Point(0, 0);
            this.pnlChooseListing.Name = "pnlChooseListing";
            this.pnlChooseListing.Size = new System.Drawing.Size(800, 450);
            this.pnlChooseListing.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bttDateListing);
            this.groupBox2.Controls.Add(this.bttNormalListing);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(360, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(456, 344);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // bttDateListing
            // 
            this.bttDateListing.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttDateListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDateListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttDateListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDateListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttDateListing.Location = new System.Drawing.Point(272, 192);
            this.bttDateListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttDateListing.Name = "bttDateListing";
            this.bttDateListing.Size = new System.Drawing.Size(104, 104);
            this.bttDateListing.TabIndex = 19;
            this.bttDateListing.Text = "Por data ";
            this.bttDateListing.UseVisualStyleBackColor = false;
            this.bttDateListing.Click += new System.EventHandler(this.bttDateListing_Click);
            // 
            // bttNormalListing
            // 
            this.bttNormalListing.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttNormalListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNormalListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttNormalListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNormalListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttNormalListing.Location = new System.Drawing.Point(80, 192);
            this.bttNormalListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttNormalListing.Name = "bttNormalListing";
            this.bttNormalListing.Size = new System.Drawing.Size(104, 104);
            this.bttNormalListing.TabIndex = 18;
            this.bttNormalListing.Text = "Listagem Normal";
            this.bttNormalListing.UseVisualStyleBackColor = false;
            this.bttNormalListing.Click += new System.EventHandler(this.bttNormalListing_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(80, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 24);
            this.label4.TabIndex = 6;
            this.label4.Text = "Selecione o método de listagem";
            // 
            // SelectListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlChooseListing);
            this.Name = "SelectListing";
            this.Text = "SelectListing";
            this.pnlChooseListing.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlChooseListing;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bttDateListing;
        private System.Windows.Forms.Button bttNormalListing;
        private System.Windows.Forms.Label label4;
    }
}
using System.ComponentModel;

namespace LivroDeRegistos_v1.gui
{
    partial class SelectionList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.bttDateListing = new System.Windows.Forms.Button();
            this.ListingFrame = new System.Windows.Forms.Panel();
            this.gpbSelectListing = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.bttNormalListing = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ListingFrame.SuspendLayout();
            this.gpbSelectListing.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttDateListing
            // 
            this.bttDateListing.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttDateListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDateListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttDateListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDateListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttDateListing.Location = new System.Drawing.Point(304, 216);
            this.bttDateListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttDateListing.Name = "bttDateListing";
            this.bttDateListing.Size = new System.Drawing.Size(104, 104);
            this.bttDateListing.TabIndex = 22;
            this.bttDateListing.Text = "Por data ";
            this.bttDateListing.UseVisualStyleBackColor = false;
            this.bttDateListing.Click += new System.EventHandler(this.bttDateListing_Click);
            // 
            // ListingFrame
            // 
            this.ListingFrame.BackColor = System.Drawing.Color.Silver;
            this.ListingFrame.Controls.Add(this.gpbSelectListing);
            this.ListingFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ListingFrame.Location = new System.Drawing.Point(0, 0);
            this.ListingFrame.Margin = new System.Windows.Forms.Padding(2);
            this.ListingFrame.Name = "ListingFrame";
            this.ListingFrame.Size = new System.Drawing.Size(1103, 623);
            this.ListingFrame.TabIndex = 24;
            // 
            // gpbSelectListing
            // 
            this.gpbSelectListing.Controls.Add(this.label4);
            this.gpbSelectListing.Controls.Add(this.bttDateListing);
            this.gpbSelectListing.Controls.Add(this.bttNormalListing);
            this.gpbSelectListing.Location = new System.Drawing.Point(352, 128);
            this.gpbSelectListing.Name = "gpbSelectListing";
            this.gpbSelectListing.Size = new System.Drawing.Size(500, 370);
            this.gpbSelectListing.TabIndex = 23;
            this.gpbSelectListing.TabStop = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(95, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(311, 24);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selecione o método de listagem";
            // 
            // bttNormalListing
            // 
            this.bttNormalListing.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttNormalListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNormalListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttNormalListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNormalListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttNormalListing.Location = new System.Drawing.Point(96, 216);
            this.bttNormalListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttNormalListing.Name = "bttNormalListing";
            this.bttNormalListing.Size = new System.Drawing.Size(104, 104);
            this.bttNormalListing.TabIndex = 21;
            this.bttNormalListing.Text = "Normal";
            this.bttNormalListing.UseVisualStyleBackColor = false;
            this.bttNormalListing.Click += new System.EventHandler(this.bttNormalListing_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ListingFrame);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1103, 623);
            this.panel1.TabIndex = 25;
            // 
            // SelectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 623);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SelectionList";
            this.Text = "SelectionList";
            this.ListingFrame.ResumeLayout(false);
            this.gpbSelectListing.ResumeLayout(false);
            this.gpbSelectListing.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button bttDateListing;
        private System.Windows.Forms.Panel ListingFrame;
        private System.Windows.Forms.Button bttNormalListing;
        private System.Windows.Forms.Label label4;

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gpbSelectListing;
    }
}
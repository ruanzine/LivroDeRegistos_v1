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
            this.bttNormalListing = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.ListingFrame.SuspendLayout();
            this.SuspendLayout();
            // 
            // bttDateListing
            // 
            this.bttDateListing.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttDateListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttDateListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttDateListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttDateListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttDateListing.Location = new System.Drawing.Point(355, 202);
            this.bttDateListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttDateListing.Name = "bttDateListing";
            this.bttDateListing.Size = new System.Drawing.Size(156, 160);
            this.bttDateListing.TabIndex = 22;
            this.bttDateListing.Text = "Por data ";
            this.bttDateListing.UseVisualStyleBackColor = false;
            this.bttDateListing.Click += new System.EventHandler(this.bttDateListing_Click);
            // 
            // ListingFrame
            // 
            this.ListingFrame.Controls.Add(this.bttDateListing);
            this.ListingFrame.Controls.Add(this.bttNormalListing);
            this.ListingFrame.Controls.Add(this.label4);
            this.ListingFrame.Location = new System.Drawing.Point(108, 26);
            this.ListingFrame.Name = "ListingFrame";
            this.ListingFrame.Size = new System.Drawing.Size(585, 399);
            this.ListingFrame.TabIndex = 24;
            // 
            // bttNormalListing
            // 
            this.bttNormalListing.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttNormalListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNormalListing.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttNormalListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNormalListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttNormalListing.Location = new System.Drawing.Point(67, 202);
            this.bttNormalListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttNormalListing.Name = "bttNormalListing";
            this.bttNormalListing.Size = new System.Drawing.Size(156, 160);
            this.bttNormalListing.TabIndex = 21;
            this.bttNormalListing.Text = "Listagem Normal";
            this.bttNormalListing.UseVisualStyleBackColor = false;
            this.bttNormalListing.Click += new System.EventHandler(this.bttNormalListing_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(67, 30);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(460, 33);
            this.label4.TabIndex = 20;
            this.label4.Text = "Selecione o método de listagem";
            // 
            // SelectionList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListingFrame);
            this.Name = "SelectionList";
            this.Text = "SelectionList";
            this.ListingFrame.ResumeLayout(false);
            this.ListingFrame.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button bttDateListing;
        private System.Windows.Forms.Panel ListingFrame;
        private System.Windows.Forms.Button bttNormalListing;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}
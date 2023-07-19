﻿using LivroDeRegistos_v1.RJControls;

namespace LivroDeRegistos_v1.gui
{
    partial class DateFromUntil
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
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
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
            this.pnlPickDate = new System.Windows.Forms.Panel();
            this.gpbDateUntil = new System.Windows.Forms.GroupBox();
            this.bttShowDate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtData_Ate = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.txtData_De = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.pnlPickDate.SuspendLayout();
            this.gpbDateUntil.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPickDate
            // 
            this.pnlPickDate.BackColor = System.Drawing.Color.Silver;
            this.pnlPickDate.Controls.Add(this.gpbDateUntil);
            this.pnlPickDate.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPickDate.Location = new System.Drawing.Point(0, 0);
            this.pnlPickDate.Name = "pnlPickDate";
            this.pnlPickDate.Size = new System.Drawing.Size(930, 560);
            this.pnlPickDate.TabIndex = 1;
            // 
            // gpbDateUntil
            // 
            this.gpbDateUntil.Controls.Add(this.bttShowDate);
            this.gpbDateUntil.Controls.Add(this.label1);
            this.gpbDateUntil.Controls.Add(this.label3);
            this.gpbDateUntil.Controls.Add(this.txtData_Ate);
            this.gpbDateUntil.Controls.Add(this.txtData_De);
            this.gpbDateUntil.Location = new System.Drawing.Point(352, 128);
            this.gpbDateUntil.Name = "gpbDateUntil";
            this.gpbDateUntil.Size = new System.Drawing.Size(500, 370);
            this.gpbDateUntil.TabIndex = 0;
            this.gpbDateUntil.TabStop = false;
            // 
            // bttShowDate
            // 
            this.bttShowDate.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttShowDate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttShowDate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttShowDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttShowDate.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttShowDate.Location = new System.Drawing.Point(224, 296);
            this.bttShowDate.Margin = new System.Windows.Forms.Padding(0);
            this.bttShowDate.Name = "bttShowDate";
            this.bttShowDate.Size = new System.Drawing.Size(72, 32);
            this.bttShowDate.TabIndex = 18;
            this.bttShowDate.Text = "Exibir";
            this.bttShowDate.UseVisualStyleBackColor = false;
            this.bttShowDate.Click += new System.EventHandler(this.bttShowDate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(173, 184);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Até";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(172, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "De";
            // 
            // txtData_Ate
            // 
            this.txtData_Ate.BackColor = System.Drawing.SystemColors.Window;
            this.txtData_Ate.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtData_Ate.BorderSize = 2;
            this.txtData_Ate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData_Ate.ForeColor = System.Drawing.Color.DimGray;
            this.txtData_Ate.Location = new System.Drawing.Point(174, 208);
            this.txtData_Ate.Margin = new System.Windows.Forms.Padding(4);
            this.txtData_Ate.Multiline = false;
            this.txtData_Ate.Name = "txtData_Ate";
            this.txtData_Ate.Padding = new System.Windows.Forms.Padding(9);
            this.txtData_Ate.PasswordChar = false;
            this.txtData_Ate.Size = new System.Drawing.Size(152, 35);
            this.txtData_Ate.TabIndex = 1;
            this.txtData_Ate.Texts = "";
            this.txtData_Ate.UnderlinedStyle = false;
            // 
            // txtData_De
            // 
            this.txtData_De.BackColor = System.Drawing.SystemColors.Window;
            this.txtData_De.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtData_De.BorderSize = 2;
            this.txtData_De.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData_De.ForeColor = System.Drawing.Color.DimGray;
            this.txtData_De.Location = new System.Drawing.Point(174, 112);
            this.txtData_De.Margin = new System.Windows.Forms.Padding(4);
            this.txtData_De.Multiline = false;
            this.txtData_De.Name = "txtData_De";
            this.txtData_De.Padding = new System.Windows.Forms.Padding(9);
            this.txtData_De.PasswordChar = false;
            this.txtData_De.Size = new System.Drawing.Size(152, 35);
            this.txtData_De.TabIndex = 0;
            this.txtData_De.Texts = "";
            this.txtData_De.UnderlinedStyle = false;
            // 
            // DateFromUntil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 560);
            this.Controls.Add(this.pnlPickDate);
            this.Name = "DateFromUntil";
            this.Text = "DateFromUntil";
            this.pnlPickDate.ResumeLayout(false);
            this.gpbDateUntil.ResumeLayout(false);
            this.gpbDateUntil.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPickDate;
        private System.Windows.Forms.GroupBox gpbDateUntil;
        private System.Windows.Forms.Button bttShowDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private txtTitulo txtData_Ate;
        private txtTitulo txtData_De;
    }
}
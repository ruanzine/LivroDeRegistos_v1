using LivroDeRegistos_v1.RJControls;

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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlDateListing = new System.Windows.Forms.Panel();
            this.pnlListas_Date = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAte = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.txtDe = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.bttPrintDate = new System.Windows.Forms.Button();
            this.lblListagemListing = new System.Windows.Forms.Label();
            this.bttFiltrar = new System.Windows.Forms.Button();
            this.dgvListagemDate = new System.Windows.Forms.DataGridView();
            this.pnlDateListing.SuspendLayout();
            this.pnlListas_Date.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDate)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDateListing
            // 
            this.pnlDateListing.BackColor = System.Drawing.Color.Silver;
            this.pnlDateListing.Controls.Add(this.pnlListas_Date);
            this.pnlDateListing.Controls.Add(this.dgvListagemDate);
            this.pnlDateListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDateListing.Location = new System.Drawing.Point(0, 0);
            this.pnlDateListing.Name = "pnlDateListing";
            this.pnlDateListing.Size = new System.Drawing.Size(1115, 560);
            this.pnlDateListing.TabIndex = 28;
            // 
            // pnlListas_Date
            // 
            this.pnlListas_Date.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlListas_Date.Controls.Add(this.label2);
            this.pnlListas_Date.Controls.Add(this.label1);
            this.pnlListas_Date.Controls.Add(this.txtAte);
            this.pnlListas_Date.Controls.Add(this.txtDe);
            this.pnlListas_Date.Controls.Add(this.bttPrintDate);
            this.pnlListas_Date.Controls.Add(this.lblListagemListing);
            this.pnlListas_Date.Controls.Add(this.bttFiltrar);
            this.pnlListas_Date.Location = new System.Drawing.Point(16, 64);
            this.pnlListas_Date.Name = "pnlListas_Date";
            this.pnlListas_Date.Size = new System.Drawing.Size(1128, 64);
            this.pnlListas_Date.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(840, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 17;
            this.label2.Text = "Até";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(653, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "De";
            // 
            // txtAte
            // 
            this.txtAte.BackColor = System.Drawing.SystemColors.Window;
            this.txtAte.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAte.BorderSize = 2;
            this.txtAte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAte.ForeColor = System.Drawing.Color.DimGray;
            this.txtAte.Location = new System.Drawing.Point(880, 16);
            this.txtAte.Margin = new System.Windows.Forms.Padding(4);
            this.txtAte.Multiline = false;
            this.txtAte.Name = "txtAte";
            this.txtAte.Padding = new System.Windows.Forms.Padding(9);
            this.txtAte.PasswordChar = false;
            this.txtAte.Size = new System.Drawing.Size(136, 35);
            this.txtAte.TabIndex = 15;
            this.txtAte.Texts = "";
            this.txtAte.UnderlinedStyle = true;
            // 
            // txtDe
            // 
            this.txtDe.BackColor = System.Drawing.SystemColors.Window;
            this.txtDe.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDe.BorderSize = 2;
            this.txtDe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDe.ForeColor = System.Drawing.Color.DimGray;
            this.txtDe.Location = new System.Drawing.Point(688, 16);
            this.txtDe.Margin = new System.Windows.Forms.Padding(4);
            this.txtDe.Multiline = false;
            this.txtDe.Name = "txtDe";
            this.txtDe.Padding = new System.Windows.Forms.Padding(9);
            this.txtDe.PasswordChar = false;
            this.txtDe.Size = new System.Drawing.Size(136, 35);
            this.txtDe.TabIndex = 14;
            this.txtDe.Texts = "";
            this.txtDe.UnderlinedStyle = true;
            // 
            // bttPrintDate
            // 
            this.bttPrintDate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrintDate.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.icons8_printer_28;
            this.bttPrintDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttPrintDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrintDate.Location = new System.Drawing.Point(1080, 14);
            this.bttPrintDate.Name = "bttPrintDate";
            this.bttPrintDate.Size = new System.Drawing.Size(35, 35);
            this.bttPrintDate.TabIndex = 12;
            this.bttPrintDate.UseVisualStyleBackColor = false;
            this.bttPrintDate.Click += new System.EventHandler(this.bttPrintDate_Click);
            // 
            // lblListagemListing
            // 
            this.lblListagemListing.AutoSize = true;
            this.lblListagemListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListagemListing.Location = new System.Drawing.Point(24, 20);
            this.lblListagemListing.Name = "lblListagemListing";
            this.lblListagemListing.Size = new System.Drawing.Size(144, 24);
            this.lblListagemListing.TabIndex = 11;
            this.lblListagemListing.Text = "Listas por data";
            // 
            // bttFiltrar
            // 
            this.bttFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttFiltrar.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.search_4_svgrepo_com;
            this.bttFiltrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttFiltrar.Location = new System.Drawing.Point(1032, 14);
            this.bttFiltrar.Margin = new System.Windows.Forms.Padding(0);
            this.bttFiltrar.Name = "bttFiltrar";
            this.bttFiltrar.Size = new System.Drawing.Size(35, 35);
            this.bttFiltrar.TabIndex = 9;
            this.bttFiltrar.UseVisualStyleBackColor = false;
            this.bttFiltrar.Click += new System.EventHandler(this.bttFiltrar_Click);
            // 
            // dgvListagemDate
            // 
            this.dgvListagemDate.AllowUserToAddRows = false;
            this.dgvListagemDate.AllowUserToDeleteRows = false;
            this.dgvListagemDate.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListagemDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagemDate.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDate.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvListagemDate.Location = new System.Drawing.Point(16, 128);
            this.dgvListagemDate.Name = "dgvListagemDate";
            this.dgvListagemDate.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemDate.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvListagemDate.RowHeadersVisible = false;
            this.dgvListagemDate.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListagemDate.Size = new System.Drawing.Size(1128, 560);
            this.dgvListagemDate.TabIndex = 0;
            // 
            // DateFromUntil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 560);
            this.Controls.Add(this.pnlDateListing);
            this.Name = "DateFromUntil";
            this.Text = "DateFromUntil";
            this.pnlDateListing.ResumeLayout(false);
            this.pnlListas_Date.ResumeLayout(false);
            this.pnlListas_Date.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemDate)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDateListing;
        private System.Windows.Forms.Panel pnlListas_Date;
        private txtTitulo txtAte;
        private txtTitulo txtDe;
        private System.Windows.Forms.Button bttPrintDate;
        private System.Windows.Forms.Label lblListagemListing;
        private System.Windows.Forms.Button bttFiltrar;
        public System.Windows.Forms.DataGridView dgvListagemDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
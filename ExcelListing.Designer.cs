namespace LivroDeRegistos_v1
{
    partial class ExcelListing
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNormalListing = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rjComboBox_Select = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.bttPrint = new System.Windows.Forms.Button();
            this.lblListagem = new System.Windows.Forms.Label();
            this.rjComboBox_Search = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.dgvListagem = new System.Windows.Forms.DataGridView();
            this.pnlNormalListing.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNormalListing
            // 
            this.pnlNormalListing.BackColor = System.Drawing.Color.Silver;
            this.pnlNormalListing.Controls.Add(this.panel4);
            this.pnlNormalListing.Controls.Add(this.dgvListagem);
            this.pnlNormalListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNormalListing.Location = new System.Drawing.Point(0, 0);
            this.pnlNormalListing.Name = "pnlNormalListing";
            this.pnlNormalListing.Size = new System.Drawing.Size(1317, 667);
            this.pnlNormalListing.TabIndex = 27;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.rjComboBox_Select);
            this.panel4.Controls.Add(this.bttPrint);
            this.panel4.Controls.Add(this.lblListagem);
            this.panel4.Controls.Add(this.rjComboBox_Search);
            this.panel4.Controls.Add(this.bttSearch);
            this.panel4.Location = new System.Drawing.Point(16, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 64);
            this.panel4.TabIndex = 1;
            // 
            // rjComboBox_Select
            // 
            this.rjComboBox_Select.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_Select.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Select.BorderSize = 1;
            this.rjComboBox_Select.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_Select.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_Select.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Select.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Select.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_Select.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Select.Location = new System.Drawing.Point(728, 16);
            this.rjComboBox_Select.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_Select.Name = "rjComboBox_Select";
            this.rjComboBox_Select.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_Select.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_Select.TabIndex = 13;
            this.rjComboBox_Select.Texts = "idk";
            // 
            // bttPrint
            // 
            this.bttPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint.Location = new System.Drawing.Point(1080, 16);
            this.bttPrint.Name = "bttPrint";
            this.bttPrint.Size = new System.Drawing.Size(35, 35);
            this.bttPrint.TabIndex = 12;
            this.bttPrint.Text = "PR";
            this.bttPrint.UseVisualStyleBackColor = false;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 20);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(213, 24);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Listagem e Impressão";
            // 
            // rjComboBox_Search
            // 
            this.rjComboBox_Search.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_Search.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Search.BorderSize = 1;
            this.rjComboBox_Search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_Search.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_Search.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Search.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Search.Items.AddRange(new object[] {
            "Número de Registo",
            "Título",
            "Autor",
            "Cota",
            "Estado"});
            this.rjComboBox_Search.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_Search.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Search.Location = new System.Drawing.Point(504, 16);
            this.rjComboBox_Search.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_Search.Name = "rjComboBox_Search";
            this.rjComboBox_Search.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_Search.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_Search.TabIndex = 10;
            this.rjComboBox_Search.Texts = "Filtro de listagem";
            // 
            // bttSearch
            // 
            this.bttSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttSearch.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.search_4_svgrepo_com;
            this.bttSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearch.Location = new System.Drawing.Point(952, 16);
            this.bttSearch.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(35, 35);
            this.bttSearch.TabIndex = 9;
            this.bttSearch.UseVisualStyleBackColor = false;
            // 
            // dgvListagem
            // 
            this.dgvListagem.AllowUserToAddRows = false;
            this.dgvListagem.AllowUserToDeleteRows = false;
            this.dgvListagem.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagem.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagem.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvListagem.Location = new System.Drawing.Point(16, 128);
            this.dgvListagem.Name = "dgvListagem";
            this.dgvListagem.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagem.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvListagem.RowHeadersVisible = false;
            this.dgvListagem.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListagem.Size = new System.Drawing.Size(1128, 560);
            this.dgvListagem.TabIndex = 0;
            // 
            // ExcelListing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1317, 667);
            this.Controls.Add(this.pnlNormalListing);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExcelListing";
            this.Text = "ExcelListing";
            this.pnlNormalListing.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNormalListing;
        private System.Windows.Forms.Panel panel4;
        private RJControls.RJComboBox rjComboBox_Select;
        private System.Windows.Forms.Button bttPrint;
        private System.Windows.Forms.Label lblListagem;
        private RJControls.RJComboBox rjComboBox_Search;
        private System.Windows.Forms.Button bttSearch;
        public System.Windows.Forms.DataGridView dgvListagem;
    }
}
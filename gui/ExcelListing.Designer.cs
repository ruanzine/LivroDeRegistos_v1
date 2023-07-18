namespace LivroDeRegistos_v1.gui
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlNormalListing = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPesquisa = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.rjComboBox_SelectAll = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.bttPrint = new System.Windows.Forms.Button();
            this.lblListagem = new System.Windows.Forms.Label();
            this.rjComboBox_SelectFilter = new LivroDeRegistos_v1.RJControls.RJComboBox();
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
            this.panel4.Controls.Add(this.txtPesquisa);
            this.panel4.Controls.Add(this.rjComboBox_SelectAll);
            this.panel4.Controls.Add(this.bttPrint);
            this.panel4.Controls.Add(this.lblListagem);
            this.panel4.Controls.Add(this.rjComboBox_SelectFilter);
            this.panel4.Controls.Add(this.bttSearch);
            this.panel4.Location = new System.Drawing.Point(16, 64);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 64);
            this.panel4.TabIndex = 1;
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.BackColor = System.Drawing.SystemColors.Window;
            this.txtPesquisa.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPesquisa.BorderSize = 2;
            this.txtPesquisa.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisa.ForeColor = System.Drawing.Color.DimGray;
            this.txtPesquisa.Location = new System.Drawing.Point(848, 16);
            this.txtPesquisa.Margin = new System.Windows.Forms.Padding(4);
            this.txtPesquisa.Multiline = false;
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.Padding = new System.Windows.Forms.Padding(9);
            this.txtPesquisa.PasswordChar = false;
            this.txtPesquisa.Size = new System.Drawing.Size(176, 35);
            this.txtPesquisa.TabIndex = 14;
            this.txtPesquisa.Texts = "";
            this.txtPesquisa.UnderlinedStyle = true;
            // 
            // rjComboBox_SelectAll
            // 
            this.rjComboBox_SelectAll.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_SelectAll.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_SelectAll.BorderSize = 1;
            this.rjComboBox_SelectAll.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_SelectAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_SelectAll.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_SelectAll.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_SelectAll.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_SelectAll.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_SelectAll.Location = new System.Drawing.Point(432, 16);
            this.rjComboBox_SelectAll.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectAll.Name = "rjComboBox_SelectAll";
            this.rjComboBox_SelectAll.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_SelectAll.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectAll.TabIndex = 13;
            this.rjComboBox_SelectAll.Texts = "<Selecione uma opção>";
            // 
            // bttPrint
            // 
            this.bttPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrint.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.icons8_printer_28;
            this.bttPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint.Location = new System.Drawing.Point(1080, 14);
            this.bttPrint.Name = "bttPrint";
            this.bttPrint.Size = new System.Drawing.Size(35, 35);
            this.bttPrint.TabIndex = 12;
            this.bttPrint.UseVisualStyleBackColor = false;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 20);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(62, 24);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Listas";
            // 
            // rjComboBox_SelectFilter
            // 
            this.rjComboBox_SelectFilter.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_SelectFilter.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_SelectFilter.BorderSize = 1;
            this.rjComboBox_SelectFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_SelectFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_SelectFilter.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_SelectFilter.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_SelectFilter.Items.AddRange(new object[] {
            "Nº de Registo",
            "Título",
            "Autor",
            "Cota",
            "Estado"});
            this.rjComboBox_SelectFilter.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_SelectFilter.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_SelectFilter.Location = new System.Drawing.Point(208, 16);
            this.rjComboBox_SelectFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectFilter.Name = "rjComboBox_SelectFilter";
            this.rjComboBox_SelectFilter.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_SelectFilter.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectFilter.TabIndex = 10;
            this.rjComboBox_SelectFilter.Texts = "Filtro";
            this.rjComboBox_SelectFilter.TabIndexChanged += new System.EventHandler(this.rjComboBox_SelectFilter_TabIndexChanged);
            // 
            // bttSearch
            // 
            this.bttSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttSearch.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.search_4_svgrepo_com;
            this.bttSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearch.Location = new System.Drawing.Point(648, 14);
            this.bttSearch.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(35, 35);
            this.bttSearch.TabIndex = 9;
            this.bttSearch.UseVisualStyleBackColor = false;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // dgvListagem
            // 
            this.dgvListagem.AllowUserToAddRows = false;
            this.dgvListagem.AllowUserToDeleteRows = false;
            this.dgvListagem.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagem.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagem.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListagem.Location = new System.Drawing.Point(16, 128);
            this.dgvListagem.Name = "dgvListagem";
            this.dgvListagem.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagem.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
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
        private RJControls.RJComboBox rjComboBox_SelectAll;
        private System.Windows.Forms.Button bttPrint;
        private System.Windows.Forms.Label lblListagem;
        private RJControls.RJComboBox rjComboBox_SelectFilter;
        private System.Windows.Forms.Button bttSearch;
        public System.Windows.Forms.DataGridView dgvListagem;
        private RJControls.txtTitulo txtPesquisa;
    }
}
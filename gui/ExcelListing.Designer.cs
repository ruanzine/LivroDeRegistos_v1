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
            this.pnlListas = new System.Windows.Forms.Panel();
            this.lblListagemListing = new System.Windows.Forms.Label();
            this.dgvListagemListing = new System.Windows.Forms.DataGridView();
            this.bttPrint = new System.Windows.Forms.Button();
            this.bttSearchListing = new System.Windows.Forms.Button();
            this.txtSearchListing = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.rjComboBox_SelectAll = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.rjComboBox_SelectFilter = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.pnlNormalListing.SuspendLayout();
            this.pnlListas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemListing)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNormalListing
            // 
            this.pnlNormalListing.BackColor = System.Drawing.Color.Silver;
            this.pnlNormalListing.Controls.Add(this.pnlListas);
            this.pnlNormalListing.Controls.Add(this.dgvListagemListing);
            this.pnlNormalListing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlNormalListing.Location = new System.Drawing.Point(0, 0);
            this.pnlNormalListing.Name = "pnlNormalListing";
            this.pnlNormalListing.Size = new System.Drawing.Size(1317, 667);
            this.pnlNormalListing.TabIndex = 27;
            // 
            // pnlListas
            // 
            this.pnlListas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.pnlListas.Controls.Add(this.txtSearchListing);
            this.pnlListas.Controls.Add(this.rjComboBox_SelectAll);
            this.pnlListas.Controls.Add(this.bttPrint);
            this.pnlListas.Controls.Add(this.lblListagemListing);
            this.pnlListas.Controls.Add(this.rjComboBox_SelectFilter);
            this.pnlListas.Controls.Add(this.bttSearchListing);
            this.pnlListas.Location = new System.Drawing.Point(16, 64);
            this.pnlListas.Name = "pnlListas";
            this.pnlListas.Size = new System.Drawing.Size(1128, 64);
            this.pnlListas.TabIndex = 1;
            // 
            // lblListagemListing
            // 
            this.lblListagemListing.AutoSize = true;
            this.lblListagemListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagemListing.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListagemListing.Location = new System.Drawing.Point(24, 20);
            this.lblListagemListing.Name = "lblListagemListing";
            this.lblListagemListing.Size = new System.Drawing.Size(170, 24);
            this.lblListagemListing.TabIndex = 11;
            this.lblListagemListing.Text = "Listas Avançadas";
            // 
            // dgvListagemListing
            // 
            this.dgvListagemListing.AllowUserToAddRows = false;
            this.dgvListagemListing.AllowUserToDeleteRows = false;
            this.dgvListagemListing.BackgroundColor = System.Drawing.Color.Silver;
            this.dgvListagemListing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListagemListing.Cursor = System.Windows.Forms.Cursors.Default;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemListing.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvListagemListing.Location = new System.Drawing.Point(16, 128);
            this.dgvListagemListing.Name = "dgvListagemListing";
            this.dgvListagemListing.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListagemListing.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvListagemListing.RowHeadersVisible = false;
            this.dgvListagemListing.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgvListagemListing.Size = new System.Drawing.Size(1128, 560);
            this.dgvListagemListing.TabIndex = 0;
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
            this.bttPrint.Click += new System.EventHandler(this.bttPrint_Click);
            // 
            // bttSearchListing
            // 
            this.bttSearchListing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttSearchListing.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.search_4_svgrepo_com;
            this.bttSearchListing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSearchListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearchListing.Location = new System.Drawing.Point(664, 14);
            this.bttSearchListing.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearchListing.Name = "bttSearchListing";
            this.bttSearchListing.Size = new System.Drawing.Size(35, 35);
            this.bttSearchListing.TabIndex = 9;
            this.bttSearchListing.UseVisualStyleBackColor = false;
            this.bttSearchListing.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // txtSearchListing
            // 
            this.txtSearchListing.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearchListing.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearchListing.BorderSize = 2;
            this.txtSearchListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchListing.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearchListing.Location = new System.Drawing.Point(848, 16);
            this.txtSearchListing.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchListing.Multiline = false;
            this.txtSearchListing.Name = "txtSearchListing";
            this.txtSearchListing.Padding = new System.Windows.Forms.Padding(9);
            this.txtSearchListing.PasswordChar = false;
            this.txtSearchListing.Size = new System.Drawing.Size(176, 35);
            this.txtSearchListing.TabIndex = 14;
            this.txtSearchListing.Texts = "";
            this.txtSearchListing.UnderlinedStyle = true;
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
            this.rjComboBox_SelectAll.Location = new System.Drawing.Point(448, 16);
            this.rjComboBox_SelectAll.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectAll.Name = "rjComboBox_SelectAll";
            this.rjComboBox_SelectAll.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_SelectAll.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectAll.TabIndex = 13;
            this.rjComboBox_SelectAll.Texts = "<Selecione uma opção>";
            this.rjComboBox_SelectAll.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_SelectAll_OnSelectedIndexChanged);
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
            this.rjComboBox_SelectFilter.Location = new System.Drawing.Point(224, 16);
            this.rjComboBox_SelectFilter.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectFilter.Name = "rjComboBox_SelectFilter";
            this.rjComboBox_SelectFilter.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_SelectFilter.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_SelectFilter.TabIndex = 10;
            this.rjComboBox_SelectFilter.Texts = "Filtro";
            this.rjComboBox_SelectFilter.OnSelectedIndexChanged += new System.EventHandler(this.rjComboBox_SelectFilter_OnSelectedIndexChanged);
            this.rjComboBox_SelectFilter.TabIndexChanged += new System.EventHandler(this.rjComboBox_SelectFilter_TabIndexChanged);
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
            this.pnlListas.ResumeLayout(false);
            this.pnlListas.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagemListing)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlNormalListing;
        private System.Windows.Forms.Panel pnlListas;
        private RJControls.RJComboBox rjComboBox_SelectAll;
        private System.Windows.Forms.Button bttPrint;
        private System.Windows.Forms.Label lblListagemListing;
        private RJControls.RJComboBox rjComboBox_SelectFilter;
        private System.Windows.Forms.Button bttSearchListing;
        public System.Windows.Forms.DataGridView dgvListagemListing;
        private RJControls.txtTitulo txtSearchListing;
    }
}
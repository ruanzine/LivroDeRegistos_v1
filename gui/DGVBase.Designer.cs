using LivroDeRegistos_v1.RJControls;

namespace LivroDeRegistos_v1.gui
{
    partial class DGVBase
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pnlSearch = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblListagem = new System.Windows.Forms.Label();
            this.rjComboBox_Search = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.bttSearch = new System.Windows.Forms.Button();
            this.txtSearch = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.dgvListagem = new System.Windows.Forms.DataGridView();
            this.bttPrint_Search = new System.Windows.Forms.Button();
            this.pnlSearch.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Silver;
            this.pnlSearch.Controls.Add(this.panel4);
            this.pnlSearch.Controls.Add(this.dgvListagem);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSearch.Location = new System.Drawing.Point(0, 0);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1356, 572);
            this.pnlSearch.TabIndex = 24;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel4.Controls.Add(this.bttPrint_Search);
            this.panel4.Controls.Add(this.lblListagem);
            this.panel4.Controls.Add(this.rjComboBox_Search);
            this.panel4.Controls.Add(this.bttSearch);
            this.panel4.Controls.Add(this.txtSearch);
            this.panel4.Location = new System.Drawing.Point(16, 24);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1128, 64);
            this.panel4.TabIndex = 1;
            // 
            // lblListagem
            // 
            this.lblListagem.AutoSize = true;
            this.lblListagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListagem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblListagem.Location = new System.Drawing.Point(24, 20);
            this.lblListagem.Name = "lblListagem";
            this.lblListagem.Size = new System.Drawing.Size(242, 24);
            this.lblListagem.TabIndex = 11;
            this.lblListagem.Text = "Pesquisa de Exemplares";
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
            this.rjComboBox_Search.Location = new System.Drawing.Point(520, 18);
            this.rjComboBox_Search.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_Search.Name = "rjComboBox_Search";
            this.rjComboBox_Search.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_Search.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_Search.TabIndex = 10;
            this.rjComboBox_Search.Texts = "Filtro de pesquisa";
            // 
            // bttSearch
            // 
            this.bttSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttSearch.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.search_4_svgrepo_com;
            this.bttSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bttSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttSearch.Location = new System.Drawing.Point(1024, 16);
            this.bttSearch.Margin = new System.Windows.Forms.Padding(0);
            this.bttSearch.Name = "bttSearch";
            this.bttSearch.Size = new System.Drawing.Size(35, 35);
            this.bttSearch.TabIndex = 9;
            this.bttSearch.UseVisualStyleBackColor = false;
            this.bttSearch.Click += new System.EventHandler(this.bttSearch_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtSearch.BorderSize = 2;
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DimGray;
            this.txtSearch.Location = new System.Drawing.Point(728, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Multiline = false;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Padding = new System.Windows.Forms.Padding(9);
            this.txtSearch.PasswordChar = false;
            this.txtSearch.Size = new System.Drawing.Size(288, 35);
            this.txtSearch.TabIndex = 5;
            this.txtSearch.Texts = "";
            this.txtSearch.UnderlinedStyle = true;
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
            this.dgvListagem.Location = new System.Drawing.Point(16, 88);
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
            this.dgvListagem.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvListagem_CellFormatting);
            // 
            // bttPrint_Search
            // 
            this.bttPrint_Search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttPrint_Search.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.icons8_printer_28;
            this.bttPrint_Search.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttPrint_Search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPrint_Search.Location = new System.Drawing.Point(1072, 16);
            this.bttPrint_Search.Name = "bttPrint_Search";
            this.bttPrint_Search.Size = new System.Drawing.Size(35, 35);
            this.bttPrint_Search.TabIndex = 13;
            this.bttPrint_Search.UseVisualStyleBackColor = false;
            this.bttPrint_Search.Click += new System.EventHandler(this.bttPrint_Search_Click);
            // 
            // DGVBase
            // 
            this.ClientSize = new System.Drawing.Size(1356, 572);
            this.Controls.Add(this.pnlSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DGVBase";
            this.pnlSearch.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListagem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblListagem;
        private RJControls.RJComboBox rjComboBox_Search;
        private System.Windows.Forms.Button bttSearch;
        private txtTitulo txtSearch;
        public System.Windows.Forms.DataGridView dgvListagem;
        private System.Windows.Forms.Button bttPrint_Search;
    }
}
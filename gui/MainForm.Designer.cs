namespace LivroDeRegistos_v1.gui
{
    partial class MainForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (this.components != null))
            {
                this.components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.pnlLogo = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pnlMainFrame = new System.Windows.Forms.Panel();
            this.bttHelp = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bttStatistics = new System.Windows.Forms.Button();
            this.bttListing = new System.Windows.Forms.Button();
            this.bttPesquisar = new System.Windows.Forms.Button();
            this.bttEdidBook = new System.Windows.Forms.Button();
            this.bttNew = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnlMenu.SuspendLayout();
            this.pnlLogo.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.pnlMenu.Controls.Add(this.bttStatistics);
            this.pnlMenu.Controls.Add(this.bttListing);
            this.pnlMenu.Controls.Add(this.bttPesquisar);
            this.pnlMenu.Controls.Add(this.bttEdidBook);
            this.pnlMenu.Controls.Add(this.bttNew);
            this.pnlMenu.Controls.Add(this.pnlLogo);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(203, 669);
            this.pnlMenu.TabIndex = 0;
            // 
            // pnlLogo
            // 
            this.pnlLogo.Controls.Add(this.picLogo);
            this.pnlLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlLogo.Location = new System.Drawing.Point(0, 0);
            this.pnlLogo.Name = "pnlLogo";
            this.pnlLogo.Size = new System.Drawing.Size(203, 152);
            this.pnlLogo.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(173)))), ((int)(((byte)(255)))));
            this.panel2.Controls.Add(this.bttHelp);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(203, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1167, 48);
            this.panel2.TabIndex = 3;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.label2.Location = new System.Drawing.Point(296, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(373, 29);
            this.label2.TabIndex = 13;
            this.label2.Text = "LIVRO DE REGISTO DIGITAL -";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(664, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 23);
            this.label1.TabIndex = 12;
            this.label1.Text = "BE EB2,3 Padre José Rota";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(133)))), ((int)(((byte)(215)))));
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(203, 48);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1167, 5);
            this.panel3.TabIndex = 6;
            // 
            // pnlMainFrame
            // 
            this.pnlMainFrame.BackColor = System.Drawing.Color.Silver;
            this.pnlMainFrame.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.backgroundLV__1_;
            this.pnlMainFrame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlMainFrame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMainFrame.Location = new System.Drawing.Point(203, 53);
            this.pnlMainFrame.Name = "pnlMainFrame";
            this.pnlMainFrame.Size = new System.Drawing.Size(1167, 616);
            this.pnlMainFrame.TabIndex = 25;
            // 
            // bttHelp
            // 
            this.bttHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttHelp.Dock = System.Windows.Forms.DockStyle.Left;
            this.bttHelp.FlatAppearance.BorderSize = 0;
            this.bttHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttHelp.Image = global::LivroDeRegistos_v1.Properties.Resources.icons8_help_28;
            this.bttHelp.Location = new System.Drawing.Point(0, 0);
            this.bttHelp.Name = "bttHelp";
            this.bttHelp.Size = new System.Drawing.Size(48, 48);
            this.bttHelp.TabIndex = 16;
            this.bttHelp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttHelp.UseVisualStyleBackColor = true;
            this.bttHelp.Click += new System.EventHandler(this.bttHelp_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LivroDeRegistos_v1.Properties.Resources.LogoBibliotecaAEFC;
            this.pictureBox1.Location = new System.Drawing.Point(952, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(216, 48);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // bttStatistics
            // 
            this.bttStatistics.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttStatistics.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttStatistics.FlatAppearance.BorderSize = 0;
            this.bttStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttStatistics.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttStatistics.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttStatistics.Image = global::LivroDeRegistos_v1.Properties.Resources.icons8_bar_chart_30;
            this.bttStatistics.Location = new System.Drawing.Point(0, 544);
            this.bttStatistics.Name = "bttStatistics";
            this.bttStatistics.Size = new System.Drawing.Size(203, 98);
            this.bttStatistics.TabIndex = 13;
            this.bttStatistics.Text = "   Relatórios       ";
            this.bttStatistics.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttStatistics.UseVisualStyleBackColor = true;
            this.bttStatistics.Click += new System.EventHandler(this.bttStatistics_Click);
            // 
            // bttListing
            // 
            this.bttListing.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttListing.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttListing.FlatAppearance.BorderSize = 0;
            this.bttListing.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttListing.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttListing.Image = global::LivroDeRegistos_v1.Properties.Resources.icons8_clipboard_30;
            this.bttListing.Location = new System.Drawing.Point(0, 446);
            this.bttListing.Name = "bttListing";
            this.bttListing.Size = new System.Drawing.Size(203, 98);
            this.bttListing.TabIndex = 12;
            this.bttListing.Text = "    Listas                ";
            this.bttListing.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttListing.UseVisualStyleBackColor = true;
            this.bttListing.Click += new System.EventHandler(this.bttListing_Click);
            // 
            // bttPesquisar
            // 
            this.bttPesquisar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttPesquisar.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttPesquisar.FlatAppearance.BorderSize = 0;
            this.bttPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttPesquisar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttPesquisar.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttPesquisar.Image = global::LivroDeRegistos_v1.Properties.Resources.icons8_search_book_30;
            this.bttPesquisar.Location = new System.Drawing.Point(0, 348);
            this.bttPesquisar.Name = "bttPesquisar";
            this.bttPesquisar.Size = new System.Drawing.Size(203, 98);
            this.bttPesquisar.TabIndex = 10;
            this.bttPesquisar.Text = "    Pesquisar         ";
            this.bttPesquisar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttPesquisar.UseVisualStyleBackColor = true;
            this.bttPesquisar.Click += new System.EventHandler(this.bttPesquisar_Click);
            // 
            // bttEdidBook
            // 
            this.bttEdidBook.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEdidBook.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttEdidBook.FlatAppearance.BorderSize = 0;
            this.bttEdidBook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttEdidBook.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEdidBook.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttEdidBook.Image = global::LivroDeRegistos_v1.Properties.Resources.icons8_edit_30;
            this.bttEdidBook.Location = new System.Drawing.Point(0, 250);
            this.bttEdidBook.Name = "bttEdidBook";
            this.bttEdidBook.Size = new System.Drawing.Size(203, 98);
            this.bttEdidBook.TabIndex = 9;
            this.bttEdidBook.Text = "    Editar Exemplar";
            this.bttEdidBook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttEdidBook.UseVisualStyleBackColor = true;
            this.bttEdidBook.Click += new System.EventHandler(this.bttEdidBook_Click);
            // 
            // bttNew
            // 
            this.bttNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttNew.Dock = System.Windows.Forms.DockStyle.Top;
            this.bttNew.FlatAppearance.BorderSize = 0;
            this.bttNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttNew.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttNew.Image = global::LivroDeRegistos_v1.Properties.Resources.icons8_add_book_30__1_;
            this.bttNew.Location = new System.Drawing.Point(0, 152);
            this.bttNew.Name = "bttNew";
            this.bttNew.Size = new System.Drawing.Size(203, 98);
            this.bttNew.TabIndex = 8;
            this.bttNew.Text = "    Novo Exemplar   ";
            this.bttNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bttNew.UseVisualStyleBackColor = true;
            this.bttNew.Click += new System.EventHandler(this.bttNew_Click);
            // 
            // picLogo
            // 
            this.picLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picLogo.Image = global::LivroDeRegistos_v1.Properties.Resources.eb2_3logo;
            this.picLogo.Location = new System.Drawing.Point(0, 0);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(203, 152);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            this.picLogo.Click += new System.EventHandler(this.picLogo_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1370, 669);
            this.Controls.Add(this.pnlMainFrame);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnlMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.pnlMenu.ResumeLayout(false);
            this.pnlLogo.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlLogo;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Button bttPesquisar;
        private System.Windows.Forms.Button bttEdidBook;
        private System.Windows.Forms.Button bttNew;
        private System.Windows.Forms.Panel pnlMainFrame;
        private System.Windows.Forms.Button bttListing;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button bttStatistics;
        private System.Windows.Forms.Button bttHelp;
    }
}


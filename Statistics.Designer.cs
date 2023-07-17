namespace LivroDeRegistos_v1
{
    partial class Statistics
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
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.gpbExemplares = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNExemplares = new LivroDeRegistos_v1.txtTitulo();
            this.bttRefresh = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNAutores = new LivroDeRegistos_v1.txtTitulo();
            this.gpbCompras = new System.Windows.Forms.GroupBox();
            this.txtNOfertas = new LivroDeRegistos_v1.txtTitulo();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNCompras = new LivroDeRegistos_v1.txtTitulo();
            this.gpbDisponiveis = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtDisponiveis = new LivroDeRegistos_v1.txtTitulo();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIndisponiveis = new LivroDeRegistos_v1.txtTitulo();
            this.txtExposicao = new LivroDeRegistos_v1.txtTitulo();
            this.txtConsultaL = new LivroDeRegistos_v1.txtTitulo();
            this.label9 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.gpbAbatidos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDeposito = new LivroDeRegistos_v1.txtTitulo();
            this.txtPerdidos = new LivroDeRegistos_v1.txtTitulo();
            this.label7 = new System.Windows.Forms.Label();
            this.txtAbatidos = new LivroDeRegistos_v1.txtTitulo();
            this.label13 = new System.Windows.Forms.Label();
            this.pnlEdit.SuspendLayout();
            this.gpbExemplares.SuspendLayout();
            this.gpbCompras.SuspendLayout();
            this.gpbDisponiveis.SuspendLayout();
            this.gpbAbatidos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Silver;
            this.pnlEdit.Controls.Add(this.gpbAbatidos);
            this.pnlEdit.Controls.Add(this.gpbCompras);
            this.pnlEdit.Controls.Add(this.gpbExemplares);
            this.pnlEdit.Controls.Add(this.gpbDisponiveis);
            this.pnlEdit.Controls.Add(this.bttRefresh);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(1024, 595);
            this.pnlEdit.TabIndex = 14;
            this.pnlEdit.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlEdit_Paint);
            // 
            // gpbExemplares
            // 
            this.gpbExemplares.Controls.Add(this.txtNAutores);
            this.gpbExemplares.Controls.Add(this.label1);
            this.gpbExemplares.Controls.Add(this.label2);
            this.gpbExemplares.Controls.Add(this.txtNExemplares);
            this.gpbExemplares.Location = new System.Drawing.Point(160, 80);
            this.gpbExemplares.Name = "gpbExemplares";
            this.gpbExemplares.Size = new System.Drawing.Size(568, 64);
            this.gpbExemplares.TabIndex = 19;
            this.gpbExemplares.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(16, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nº de Exemplares";
            // 
            // txtNExemplares
            // 
            this.txtNExemplares.BackColor = System.Drawing.SystemColors.Window;
            this.txtNExemplares.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNExemplares.BorderSize = 2;
            this.txtNExemplares.Enabled = false;
            this.txtNExemplares.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNExemplares.ForeColor = System.Drawing.Color.DimGray;
            this.txtNExemplares.Location = new System.Drawing.Point(168, 16);
            this.txtNExemplares.Margin = new System.Windows.Forms.Padding(4);
            this.txtNExemplares.Multiline = false;
            this.txtNExemplares.Name = "txtNExemplares";
            this.txtNExemplares.Padding = new System.Windows.Forms.Padding(9);
            this.txtNExemplares.PasswordChar = false;
            this.txtNExemplares.Size = new System.Drawing.Size(64, 35);
            this.txtNExemplares.TabIndex = 2;
            this.txtNExemplares.Texts = "";
            this.txtNExemplares.UnderlinedStyle = true;
            // 
            // bttRefresh
            // 
            this.bttRefresh.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttRefresh.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttRefresh.Location = new System.Drawing.Point(160, 32);
            this.bttRefresh.Margin = new System.Windows.Forms.Padding(0);
            this.bttRefresh.Name = "bttRefresh";
            this.bttRefresh.Size = new System.Drawing.Size(88, 32);
            this.bttRefresh.TabIndex = 15;
            this.bttRefresh.Text = "Atualizar";
            this.bttRefresh.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(264, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Nº de Autores";
            // 
            // txtNAutores
            // 
            this.txtNAutores.BackColor = System.Drawing.SystemColors.Window;
            this.txtNAutores.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNAutores.BorderSize = 2;
            this.txtNAutores.Enabled = false;
            this.txtNAutores.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNAutores.ForeColor = System.Drawing.Color.DimGray;
            this.txtNAutores.Location = new System.Drawing.Point(384, 16);
            this.txtNAutores.Margin = new System.Windows.Forms.Padding(4);
            this.txtNAutores.Multiline = false;
            this.txtNAutores.Name = "txtNAutores";
            this.txtNAutores.Padding = new System.Windows.Forms.Padding(9);
            this.txtNAutores.PasswordChar = false;
            this.txtNAutores.Size = new System.Drawing.Size(64, 35);
            this.txtNAutores.TabIndex = 5;
            this.txtNAutores.Texts = "";
            this.txtNAutores.UnderlinedStyle = true;
            // 
            // gpbCompras
            // 
            this.gpbCompras.Controls.Add(this.txtNOfertas);
            this.gpbCompras.Controls.Add(this.label3);
            this.gpbCompras.Controls.Add(this.label5);
            this.gpbCompras.Controls.Add(this.txtNCompras);
            this.gpbCompras.Location = new System.Drawing.Point(160, 152);
            this.gpbCompras.Name = "gpbCompras";
            this.gpbCompras.Size = new System.Drawing.Size(568, 64);
            this.gpbCompras.TabIndex = 20;
            this.gpbCompras.TabStop = false;
            // 
            // txtNOfertas
            // 
            this.txtNOfertas.BackColor = System.Drawing.SystemColors.Window;
            this.txtNOfertas.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNOfertas.BorderSize = 2;
            this.txtNOfertas.Enabled = false;
            this.txtNOfertas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNOfertas.ForeColor = System.Drawing.Color.DimGray;
            this.txtNOfertas.Location = new System.Drawing.Point(384, 16);
            this.txtNOfertas.Margin = new System.Windows.Forms.Padding(4);
            this.txtNOfertas.Multiline = false;
            this.txtNOfertas.Name = "txtNOfertas";
            this.txtNOfertas.Padding = new System.Windows.Forms.Padding(9);
            this.txtNOfertas.PasswordChar = false;
            this.txtNOfertas.Size = new System.Drawing.Size(64, 35);
            this.txtNOfertas.TabIndex = 5;
            this.txtNOfertas.Texts = "";
            this.txtNOfertas.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(264, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Nº de Ofertas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(32, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 16);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nº de Compras";
            // 
            // txtNCompras
            // 
            this.txtNCompras.BackColor = System.Drawing.SystemColors.Window;
            this.txtNCompras.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNCompras.BorderSize = 2;
            this.txtNCompras.Enabled = false;
            this.txtNCompras.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNCompras.ForeColor = System.Drawing.Color.DimGray;
            this.txtNCompras.Location = new System.Drawing.Point(168, 16);
            this.txtNCompras.Margin = new System.Windows.Forms.Padding(4);
            this.txtNCompras.Multiline = false;
            this.txtNCompras.Name = "txtNCompras";
            this.txtNCompras.Padding = new System.Windows.Forms.Padding(9);
            this.txtNCompras.PasswordChar = false;
            this.txtNCompras.Size = new System.Drawing.Size(64, 35);
            this.txtNCompras.TabIndex = 2;
            this.txtNCompras.Texts = "";
            this.txtNCompras.UnderlinedStyle = true;
            // 
            // gpbDisponiveis
            // 
            this.gpbDisponiveis.Controls.Add(this.label12);
            this.gpbDisponiveis.Controls.Add(this.txtConsultaL);
            this.gpbDisponiveis.Controls.Add(this.txtExposicao);
            this.gpbDisponiveis.Controls.Add(this.txtIndisponiveis);
            this.gpbDisponiveis.Controls.Add(this.label8);
            this.gpbDisponiveis.Controls.Add(this.txtDisponiveis);
            this.gpbDisponiveis.Controls.Add(this.label13);
            this.gpbDisponiveis.Controls.Add(this.label10);
            this.gpbDisponiveis.Location = new System.Drawing.Point(160, 224);
            this.gpbDisponiveis.Name = "gpbDisponiveis";
            this.gpbDisponiveis.Size = new System.Drawing.Size(568, 128);
            this.gpbDisponiveis.TabIndex = 18;
            this.gpbDisponiveis.TabStop = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(63, 32);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(89, 16);
            this.label10.TabIndex = 6;
            this.label10.Text = "Disponíveis";
            // 
            // txtDisponiveis
            // 
            this.txtDisponiveis.BackColor = System.Drawing.SystemColors.Window;
            this.txtDisponiveis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDisponiveis.BorderSize = 2;
            this.txtDisponiveis.Enabled = false;
            this.txtDisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDisponiveis.ForeColor = System.Drawing.Color.DimGray;
            this.txtDisponiveis.Location = new System.Drawing.Point(168, 24);
            this.txtDisponiveis.Margin = new System.Windows.Forms.Padding(4);
            this.txtDisponiveis.Multiline = false;
            this.txtDisponiveis.Name = "txtDisponiveis";
            this.txtDisponiveis.Padding = new System.Windows.Forms.Padding(9);
            this.txtDisponiveis.PasswordChar = false;
            this.txtDisponiveis.Size = new System.Drawing.Size(64, 35);
            this.txtDisponiveis.TabIndex = 6;
            this.txtDisponiveis.Texts = "";
            this.txtDisponiveis.UnderlinedStyle = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(264, 32);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Indisponíveis";
            // 
            // txtIndisponiveis
            // 
            this.txtIndisponiveis.BackColor = System.Drawing.SystemColors.Window;
            this.txtIndisponiveis.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtIndisponiveis.BorderSize = 2;
            this.txtIndisponiveis.Enabled = false;
            this.txtIndisponiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndisponiveis.ForeColor = System.Drawing.Color.DimGray;
            this.txtIndisponiveis.Location = new System.Drawing.Point(384, 24);
            this.txtIndisponiveis.Margin = new System.Windows.Forms.Padding(4);
            this.txtIndisponiveis.Multiline = false;
            this.txtIndisponiveis.Name = "txtIndisponiveis";
            this.txtIndisponiveis.Padding = new System.Windows.Forms.Padding(9);
            this.txtIndisponiveis.PasswordChar = false;
            this.txtIndisponiveis.Size = new System.Drawing.Size(64, 35);
            this.txtIndisponiveis.TabIndex = 8;
            this.txtIndisponiveis.Texts = "";
            this.txtIndisponiveis.UnderlinedStyle = true;
            // 
            // txtExposicao
            // 
            this.txtExposicao.BackColor = System.Drawing.SystemColors.Window;
            this.txtExposicao.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtExposicao.BorderSize = 2;
            this.txtExposicao.Enabled = false;
            this.txtExposicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtExposicao.ForeColor = System.Drawing.Color.DimGray;
            this.txtExposicao.Location = new System.Drawing.Point(168, 80);
            this.txtExposicao.Margin = new System.Windows.Forms.Padding(4);
            this.txtExposicao.Multiline = false;
            this.txtExposicao.Name = "txtExposicao";
            this.txtExposicao.Padding = new System.Windows.Forms.Padding(9);
            this.txtExposicao.PasswordChar = false;
            this.txtExposicao.Size = new System.Drawing.Size(64, 35);
            this.txtExposicao.TabIndex = 9;
            this.txtExposicao.Texts = "";
            this.txtExposicao.UnderlinedStyle = true;
            // 
            // txtConsultaL
            // 
            this.txtConsultaL.BackColor = System.Drawing.SystemColors.Window;
            this.txtConsultaL.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtConsultaL.BorderSize = 2;
            this.txtConsultaL.Enabled = false;
            this.txtConsultaL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConsultaL.ForeColor = System.Drawing.Color.DimGray;
            this.txtConsultaL.Location = new System.Drawing.Point(384, 80);
            this.txtConsultaL.Margin = new System.Windows.Forms.Padding(4);
            this.txtConsultaL.Multiline = false;
            this.txtConsultaL.Name = "txtConsultaL";
            this.txtConsultaL.Padding = new System.Windows.Forms.Padding(9);
            this.txtConsultaL.PasswordChar = false;
            this.txtConsultaL.Size = new System.Drawing.Size(64, 35);
            this.txtConsultaL.TabIndex = 10;
            this.txtConsultaL.Texts = "";
            this.txtConsultaL.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(80, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(69, 16);
            this.label9.TabIndex = 11;
            this.label9.Text = "Abatidos";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.DimGray;
            this.label12.Location = new System.Drawing.Point(256, 88);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(109, 16);
            this.label12.TabIndex = 12;
            this.label12.Text = "Consulta Local";
            // 
            // gpbAbatidos
            // 
            this.gpbAbatidos.Controls.Add(this.label9);
            this.gpbAbatidos.Controls.Add(this.label6);
            this.gpbAbatidos.Controls.Add(this.txtDeposito);
            this.gpbAbatidos.Controls.Add(this.txtPerdidos);
            this.gpbAbatidos.Controls.Add(this.label7);
            this.gpbAbatidos.Controls.Add(this.txtAbatidos);
            this.gpbAbatidos.Location = new System.Drawing.Point(160, 360);
            this.gpbAbatidos.Name = "gpbAbatidos";
            this.gpbAbatidos.Size = new System.Drawing.Size(568, 128);
            this.gpbAbatidos.TabIndex = 19;
            this.gpbAbatidos.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(80, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "Depósito";
            // 
            // txtDeposito
            // 
            this.txtDeposito.BackColor = System.Drawing.SystemColors.Window;
            this.txtDeposito.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDeposito.BorderSize = 2;
            this.txtDeposito.Enabled = false;
            this.txtDeposito.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDeposito.ForeColor = System.Drawing.Color.DimGray;
            this.txtDeposito.Location = new System.Drawing.Point(168, 80);
            this.txtDeposito.Margin = new System.Windows.Forms.Padding(4);
            this.txtDeposito.Multiline = false;
            this.txtDeposito.Name = "txtDeposito";
            this.txtDeposito.Padding = new System.Windows.Forms.Padding(9);
            this.txtDeposito.PasswordChar = false;
            this.txtDeposito.Size = new System.Drawing.Size(64, 35);
            this.txtDeposito.TabIndex = 9;
            this.txtDeposito.Texts = "";
            this.txtDeposito.UnderlinedStyle = true;
            // 
            // txtPerdidos
            // 
            this.txtPerdidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtPerdidos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtPerdidos.BorderSize = 2;
            this.txtPerdidos.Enabled = false;
            this.txtPerdidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPerdidos.ForeColor = System.Drawing.Color.DimGray;
            this.txtPerdidos.Location = new System.Drawing.Point(384, 24);
            this.txtPerdidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtPerdidos.Multiline = false;
            this.txtPerdidos.Name = "txtPerdidos";
            this.txtPerdidos.Padding = new System.Windows.Forms.Padding(9);
            this.txtPerdidos.PasswordChar = false;
            this.txtPerdidos.Size = new System.Drawing.Size(64, 35);
            this.txtPerdidos.TabIndex = 8;
            this.txtPerdidos.Texts = "";
            this.txtPerdidos.UnderlinedStyle = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(296, 32);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 16);
            this.label7.TabIndex = 7;
            this.label7.Text = "Perdidos";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtAbatidos
            // 
            this.txtAbatidos.BackColor = System.Drawing.SystemColors.Window;
            this.txtAbatidos.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAbatidos.BorderSize = 2;
            this.txtAbatidos.Enabled = false;
            this.txtAbatidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAbatidos.ForeColor = System.Drawing.Color.DimGray;
            this.txtAbatidos.Location = new System.Drawing.Point(168, 24);
            this.txtAbatidos.Margin = new System.Windows.Forms.Padding(4);
            this.txtAbatidos.Multiline = false;
            this.txtAbatidos.Name = "txtAbatidos";
            this.txtAbatidos.Padding = new System.Windows.Forms.Padding(9);
            this.txtAbatidos.PasswordChar = false;
            this.txtAbatidos.Size = new System.Drawing.Size(64, 35);
            this.txtAbatidos.TabIndex = 6;
            this.txtAbatidos.Texts = "";
            this.txtAbatidos.UnderlinedStyle = true;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.DimGray;
            this.label13.Location = new System.Drawing.Point(72, 88);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(80, 16);
            this.label13.TabIndex = 6;
            this.label13.Text = "Exposição";
            // 
            // Statistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 595);
            this.Controls.Add(this.pnlEdit);
            this.Name = "Statistics";
            this.Text = "Statistics";
            this.pnlEdit.ResumeLayout(false);
            this.gpbExemplares.ResumeLayout(false);
            this.gpbExemplares.PerformLayout();
            this.gpbCompras.ResumeLayout(false);
            this.gpbCompras.PerformLayout();
            this.gpbDisponiveis.ResumeLayout(false);
            this.gpbDisponiveis.PerformLayout();
            this.gpbAbatidos.ResumeLayout(false);
            this.gpbAbatidos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox gpbExemplares;
        private System.Windows.Forms.Label label2;
        private txtTitulo txtNExemplares;
        private System.Windows.Forms.Button bttRefresh;
        private System.Windows.Forms.GroupBox gpbCompras;
        private txtTitulo txtNOfertas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private txtTitulo txtNCompras;
        private txtTitulo txtNAutores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gpbDisponiveis;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label9;
        private txtTitulo txtConsultaL;
        private txtTitulo txtExposicao;
        private txtTitulo txtIndisponiveis;
        private System.Windows.Forms.Label label8;
        private txtTitulo txtDisponiveis;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox gpbAbatidos;
        private System.Windows.Forms.Label label6;
        private txtTitulo txtDeposito;
        private txtTitulo txtPerdidos;
        private System.Windows.Forms.Label label7;
        private txtTitulo txtAbatidos;
        private System.Windows.Forms.Label label13;
    }
}
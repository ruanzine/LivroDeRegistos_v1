using LivroDeRegistos_v1.RJControls;

namespace LivroDeRegistos_v1.gui
{
    partial class PanelAddLivros
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
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.gpbEstado = new System.Windows.Forms.GroupBox();
            this.rjComboBox_Est = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbAqi = new System.Windows.Forms.GroupBox();
            this.rjComboBox_Aqi = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditora = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbCota = new System.Windows.Forms.GroupBox();
            this.txtObservacoes = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCota = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNVolume = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.gpbAuthor = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.gpbNReg = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataEntrega = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNRegisto = new LivroDeRegistos_v1.RJControls.txtTitulo();
            this.bttAdd = new System.Windows.Forms.Button();
            this.bttClearText = new System.Windows.Forms.Button();
            this.pnlAdd.SuspendLayout();
            this.gpbEstado.SuspendLayout();
            this.gpbAqi.SuspendLayout();
            this.gpbCota.SuspendLayout();
            this.gpbAuthor.SuspendLayout();
            this.gpbNReg.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAdd
            // 
            this.pnlAdd.BackColor = System.Drawing.Color.Silver;
            this.pnlAdd.Controls.Add(this.bttClearText);
            this.pnlAdd.Controls.Add(this.gpbEstado);
            this.pnlAdd.Controls.Add(this.gpbAqi);
            this.pnlAdd.Controls.Add(this.gpbCota);
            this.pnlAdd.Controls.Add(this.gpbAuthor);
            this.pnlAdd.Controls.Add(this.gpbNReg);
            this.pnlAdd.Controls.Add(this.bttAdd);
            this.pnlAdd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlAdd.Location = new System.Drawing.Point(0, 0);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(906, 685);
            this.pnlAdd.TabIndex = 12;
            // 
            // gpbEstado
            // 
            this.gpbEstado.Controls.Add(this.rjComboBox_Est);
            this.gpbEstado.Controls.Add(this.label11);
            this.gpbEstado.Location = new System.Drawing.Point(288, 464);
            this.gpbEstado.Name = "gpbEstado";
            this.gpbEstado.Size = new System.Drawing.Size(568, 64);
            this.gpbEstado.TabIndex = 17;
            this.gpbEstado.TabStop = false;
            // 
            // rjComboBox_Est
            // 
            this.rjComboBox_Est.AutoCompleteCustomSource.AddRange(new string[] {
            "Compra",
            "Doação"});
            this.rjComboBox_Est.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_Est.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Est.BorderSize = 1;
            this.rjComboBox_Est.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_Est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_Est.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Est.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Est.Items.AddRange(new object[] {
            "<Estado>",
            "Disponível",
            "Indisponível",
            "Abatido",
            "Perdido",
            "Consulta local",
            "Exposição",
            "Depósito"});
            this.rjComboBox_Est.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_Est.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Est.Location = new System.Drawing.Point(128, 16);
            this.rjComboBox_Est.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_Est.Name = "rjComboBox_Est";
            this.rjComboBox_Est.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_Est.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_Est.TabIndex = 9;
            this.rjComboBox_Est.Texts = "<Estado>";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.DimGray;
            this.label11.Location = new System.Drawing.Point(56, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "Estado";
            // 
            // gpbAqi
            // 
            this.gpbAqi.Controls.Add(this.rjComboBox_Aqi);
            this.gpbAqi.Controls.Add(this.label8);
            this.gpbAqi.Controls.Add(this.txtEditora);
            this.gpbAqi.Controls.Add(this.label9);
            this.gpbAqi.Location = new System.Drawing.Point(288, 200);
            this.gpbAqi.Name = "gpbAqi";
            this.gpbAqi.Size = new System.Drawing.Size(568, 128);
            this.gpbAqi.TabIndex = 18;
            this.gpbAqi.TabStop = false;
            // 
            // rjComboBox_Aqi
            // 
            this.rjComboBox_Aqi.AutoCompleteCustomSource.AddRange(new string[] {
            "Compra",
            "Doação"});
            this.rjComboBox_Aqi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_Aqi.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Aqi.BorderSize = 1;
            this.rjComboBox_Aqi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_Aqi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_Aqi.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Aqi.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Aqi.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.rjComboBox_Aqi.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_Aqi.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Aqi.Location = new System.Drawing.Point(128, 24);
            this.rjComboBox_Aqi.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_Aqi.Name = "rjComboBox_Aqi";
            this.rjComboBox_Aqi.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_Aqi.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_Aqi.TabIndex = 8;
            this.rjComboBox_Aqi.Texts = "<Aquisição>";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(50, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Editora";
            // 
            // txtEditora
            // 
            this.txtEditora.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEditora.BorderSize = 2;
            this.txtEditora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora.Location = new System.Drawing.Point(128, 76);
            this.txtEditora.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora.Multiline = false;
            this.txtEditora.Name = "txtEditora";
            this.txtEditora.Padding = new System.Windows.Forms.Padding(9);
            this.txtEditora.PasswordChar = false;
            this.txtEditora.Size = new System.Drawing.Size(427, 35);
            this.txtEditora.TabIndex = 6;
            this.txtEditora.Texts = "";
            this.txtEditora.UnderlinedStyle = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(32, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 16);
            this.label9.TabIndex = 5;
            this.label9.Text = "Aquisição";
            // 
            // gpbCota
            // 
            this.gpbCota.Controls.Add(this.txtObservacoes);
            this.gpbCota.Controls.Add(this.label6);
            this.gpbCota.Controls.Add(this.label7);
            this.gpbCota.Controls.Add(this.txtCota);
            this.gpbCota.Controls.Add(this.label4);
            this.gpbCota.Controls.Add(this.txtNVolume);
            this.gpbCota.Location = new System.Drawing.Point(288, 328);
            this.gpbCota.Name = "gpbCota";
            this.gpbCota.Size = new System.Drawing.Size(568, 136);
            this.gpbCota.TabIndex = 18;
            this.gpbCota.TabStop = false;
            // 
            // txtObservacoes
            // 
            this.txtObservacoes.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacoes.BorderSize = 2;
            this.txtObservacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes.Location = new System.Drawing.Point(128, 80);
            this.txtObservacoes.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes.Multiline = false;
            this.txtObservacoes.Name = "txtObservacoes";
            this.txtObservacoes.Padding = new System.Windows.Forms.Padding(9);
            this.txtObservacoes.PasswordChar = false;
            this.txtObservacoes.Size = new System.Drawing.Size(427, 35);
            this.txtObservacoes.TabIndex = 9;
            this.txtObservacoes.Texts = "";
            this.txtObservacoes.UnderlinedStyle = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(8, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 13;
            this.label6.Text = "Observações";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(11, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 16);
            this.label7.TabIndex = 11;
            this.label7.Text = "Cota da CDU";
            // 
            // txtCota
            // 
            this.txtCota.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCota.BorderSize = 2;
            this.txtCota.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota.Location = new System.Drawing.Point(128, 16);
            this.txtCota.Margin = new System.Windows.Forms.Padding(4);
            this.txtCota.Multiline = false;
            this.txtCota.Name = "txtCota";
            this.txtCota.Padding = new System.Windows.Forms.Padding(9);
            this.txtCota.PasswordChar = false;
            this.txtCota.Size = new System.Drawing.Size(102, 35);
            this.txtCota.TabIndex = 10;
            this.txtCota.Texts = "";
            this.txtCota.UnderlinedStyle = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(316, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 16);
            this.label4.TabIndex = 9;
            this.label4.Text = "Nº Volume";
            // 
            // txtNVolume
            // 
            this.txtNVolume.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNVolume.BorderSize = 2;
            this.txtNVolume.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume.Location = new System.Drawing.Point(424, 16);
            this.txtNVolume.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume.Multiline = false;
            this.txtNVolume.Name = "txtNVolume";
            this.txtNVolume.Padding = new System.Windows.Forms.Padding(9);
            this.txtNVolume.PasswordChar = false;
            this.txtNVolume.Size = new System.Drawing.Size(63, 35);
            this.txtNVolume.TabIndex = 8;
            this.txtNVolume.Texts = "";
            this.txtNVolume.UnderlinedStyle = true;
            // 
            // gpbAuthor
            // 
            this.gpbAuthor.Controls.Add(this.label5);
            this.gpbAuthor.Controls.Add(this.txtTitulo);
            this.gpbAuthor.Controls.Add(this.label3);
            this.gpbAuthor.Controls.Add(this.txtAutor);
            this.gpbAuthor.Location = new System.Drawing.Point(288, 72);
            this.gpbAuthor.Name = "gpbAuthor";
            this.gpbAuthor.Size = new System.Drawing.Size(568, 128);
            this.gpbAuthor.TabIndex = 17;
            this.gpbAuthor.TabStop = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(62, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.TabIndex = 7;
            this.label5.Text = "Título";
            // 
            // txtTitulo
            // 
            this.txtTitulo.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo.BorderSize = 2;
            this.txtTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo.Location = new System.Drawing.Point(128, 76);
            this.txtTitulo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo.Multiline = false;
            this.txtTitulo.Name = "txtTitulo";
            this.txtTitulo.Padding = new System.Windows.Forms.Padding(9);
            this.txtTitulo.PasswordChar = false;
            this.txtTitulo.Size = new System.Drawing.Size(427, 35);
            this.txtTitulo.TabIndex = 6;
            this.txtTitulo.Texts = "";
            this.txtTitulo.UnderlinedStyle = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(65, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Autor";
            // 
            // txtAutor
            // 
            this.txtAutor.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAutor.BorderSize = 2;
            this.txtAutor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor.Location = new System.Drawing.Point(128, 16);
            this.txtAutor.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor.Multiline = false;
            this.txtAutor.Name = "txtAutor";
            this.txtAutor.Padding = new System.Windows.Forms.Padding(9);
            this.txtAutor.PasswordChar = false;
            this.txtAutor.Size = new System.Drawing.Size(427, 35);
            this.txtAutor.TabIndex = 4;
            this.txtAutor.Texts = "";
            this.txtAutor.UnderlinedStyle = true;
            // 
            // gpbNReg
            // 
            this.gpbNReg.Controls.Add(this.label2);
            this.gpbNReg.Controls.Add(this.txtDataEntrega);
            this.gpbNReg.Controls.Add(this.label1);
            this.gpbNReg.Controls.Add(this.txtNRegisto);
            this.gpbNReg.Location = new System.Drawing.Point(288, 8);
            this.gpbNReg.Name = "gpbNReg";
            this.gpbNReg.Size = new System.Drawing.Size(568, 64);
            this.gpbNReg.TabIndex = 16;
            this.gpbNReg.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(248, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Entrada";
            // 
            // txtDataEntrega
            // 
            this.txtDataEntrega.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDataEntrega.BorderSize = 2;
            this.txtDataEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega.Location = new System.Drawing.Point(376, 16);
            this.txtDataEntrega.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega.Multiline = false;
            this.txtDataEntrega.Name = "txtDataEntrega";
            this.txtDataEntrega.Padding = new System.Windows.Forms.Padding(9);
            this.txtDataEntrega.PasswordChar = false;
            this.txtDataEntrega.Size = new System.Drawing.Size(176, 35);
            this.txtDataEntrega.TabIndex = 2;
            this.txtDataEntrega.Texts = "";
            this.txtDataEntrega.UnderlinedStyle = true;
            this.txtDataEntrega.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDataEntrega_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(8, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Registo";
            // 
            // txtNRegisto
            // 
            this.txtNRegisto.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNRegisto.BorderSize = 2;
            this.txtNRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto.Location = new System.Drawing.Point(128, 16);
            this.txtNRegisto.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto.Multiline = false;
            this.txtNRegisto.Name = "txtNRegisto";
            this.txtNRegisto.Padding = new System.Windows.Forms.Padding(9);
            this.txtNRegisto.PasswordChar = false;
            this.txtNRegisto.Size = new System.Drawing.Size(61, 35);
            this.txtNRegisto.TabIndex = 0;
            this.txtNRegisto.Texts = "";
            this.txtNRegisto.UnderlinedStyle = true;
            this.txtNRegisto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNRegisto_KeyPress);
            // 
            // bttAdd
            // 
            this.bttAdd.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttAdd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttAdd.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttAdd.Location = new System.Drawing.Point(608, 552);
            this.bttAdd.Margin = new System.Windows.Forms.Padding(0);
            this.bttAdd.Name = "bttAdd";
            this.bttAdd.Size = new System.Drawing.Size(120, 32);
            this.bttAdd.TabIndex = 15;
            this.bttAdd.Text = "Adicionar";
            this.bttAdd.UseVisualStyleBackColor = false;
            this.bttAdd.Click += new System.EventHandler(this.bttAdd_Click);
            // 
            // bttClearText
            // 
            this.bttClearText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(94)))));
            this.bttClearText.BackgroundImage = global::LivroDeRegistos_v1.Properties.Resources.icons8_broom_28;
            this.bttClearText.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.bttClearText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttClearText.Location = new System.Drawing.Point(864, 24);
            this.bttClearText.Margin = new System.Windows.Forms.Padding(0);
            this.bttClearText.Name = "bttClearText";
            this.bttClearText.Size = new System.Drawing.Size(35, 35);
            this.bttClearText.TabIndex = 20;
            this.bttClearText.UseVisualStyleBackColor = false;
            this.bttClearText.Click += new System.EventHandler(this.bttClearText_Click);
            // 
            // PanelAddLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 685);
            this.Controls.Add(this.pnlAdd);
            this.Name = "PanelAddLivros";
            this.Text = "PanelAddLivros";
            this.pnlAdd.ResumeLayout(false);
            this.gpbEstado.ResumeLayout(false);
            this.gpbEstado.PerformLayout();
            this.gpbAqi.ResumeLayout(false);
            this.gpbAqi.PerformLayout();
            this.gpbCota.ResumeLayout(false);
            this.gpbCota.PerformLayout();
            this.gpbAuthor.ResumeLayout(false);
            this.gpbAuthor.PerformLayout();
            this.gpbNReg.ResumeLayout(false);
            this.gpbNReg.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.GroupBox gpbEstado;
        private RJControls.RJComboBox rjComboBox_Est;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbAqi;
        private RJControls.RJComboBox rjComboBox_Aqi;
        private System.Windows.Forms.Label label8;
        private txtTitulo txtEditora;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbCota;
        private txtTitulo txtObservacoes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private txtTitulo txtCota;
        private System.Windows.Forms.Label label4;
        private txtTitulo txtNVolume;
        private System.Windows.Forms.GroupBox gpbAuthor;
        private System.Windows.Forms.Label label5;
        private txtTitulo txtTitulo;
        private txtTitulo txtAutor;
        private System.Windows.Forms.GroupBox gpbNReg;
        private System.Windows.Forms.Label label2;
        private txtTitulo txtDataEntrega;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bttAdd;
        private System.Windows.Forms.Label label3;
        private txtTitulo txtNRegisto;
        private System.Windows.Forms.Button bttClearText;
    }
}
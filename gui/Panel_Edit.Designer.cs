using LivroDeRegistos_v1.RJControls;

namespace LivroDeRegistos_v1.gui
{
    partial class Panel_Edit
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
            this.pnlEdit = new System.Windows.Forms.Panel();
            this.gpbN_Edit = new System.Windows.Forms.GroupBox();
            this.bttEdit = new System.Windows.Forms.Button();
            this.txtNRegisto_Edit = new txtTitulo();
            this.label1 = new System.Windows.Forms.Label();
            this.gpbData_Edit = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDataEntrega_Edit = new txtTitulo();
            this.gpbEstado_Edit = new System.Windows.Forms.GroupBox();
            this.rjComboBox_Est = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.gpbAqi_Edit = new System.Windows.Forms.GroupBox();
            this.rjComboBox_Aqi_Edit = new LivroDeRegistos_v1.RJControls.RJComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEditora_Edit = new txtTitulo();
            this.label9 = new System.Windows.Forms.Label();
            this.gpbCota_Edit = new System.Windows.Forms.GroupBox();
            this.txtObservacoes_Edit = new txtTitulo();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCota_Edit = new txtTitulo();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNVolume_Edit = new txtTitulo();
            this.gpbAutor_Edit = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTitulo_Edit = new txtTitulo();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAutor_Edit = new txtTitulo();
            this.bttSave = new System.Windows.Forms.Button();
            this.pnlEdit.SuspendLayout();
            this.gpbN_Edit.SuspendLayout();
            this.gpbData_Edit.SuspendLayout();
            this.gpbEstado_Edit.SuspendLayout();
            this.gpbAqi_Edit.SuspendLayout();
            this.gpbCota_Edit.SuspendLayout();
            this.gpbAutor_Edit.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlEdit
            // 
            this.pnlEdit.BackColor = System.Drawing.Color.Silver;
            this.pnlEdit.Controls.Add(this.gpbN_Edit);
            this.pnlEdit.Controls.Add(this.gpbData_Edit);
            this.pnlEdit.Controls.Add(this.gpbEstado_Edit);
            this.pnlEdit.Controls.Add(this.gpbAqi_Edit);
            this.pnlEdit.Controls.Add(this.gpbCota_Edit);
            this.pnlEdit.Controls.Add(this.gpbAutor_Edit);
            this.pnlEdit.Controls.Add(this.bttSave);
            this.pnlEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlEdit.Location = new System.Drawing.Point(0, 0);
            this.pnlEdit.Name = "pnlEdit";
            this.pnlEdit.Size = new System.Drawing.Size(974, 647);
            this.pnlEdit.TabIndex = 13;
            // 
            // gpbN_Edit
            // 
            this.gpbN_Edit.Controls.Add(this.bttEdit);
            this.gpbN_Edit.Controls.Add(this.txtNRegisto_Edit);
            this.gpbN_Edit.Controls.Add(this.label1);
            this.gpbN_Edit.Location = new System.Drawing.Point(424, 8);
            this.gpbN_Edit.Name = "gpbN_Edit";
            this.gpbN_Edit.Size = new System.Drawing.Size(336, 64);
            this.gpbN_Edit.TabIndex = 20;
            this.gpbN_Edit.TabStop = false;
            // 
            // bttEdit
            // 
            this.bttEdit.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttEdit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttEdit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttEdit.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttEdit.Location = new System.Drawing.Point(208, 16);
            this.bttEdit.Margin = new System.Windows.Forms.Padding(0);
            this.bttEdit.Name = "bttEdit";
            this.bttEdit.Size = new System.Drawing.Size(104, 32);
            this.bttEdit.TabIndex = 17;
            this.bttEdit.Text = "Editar";
            this.bttEdit.UseVisualStyleBackColor = false;
            this.bttEdit.Click += new System.EventHandler(this.bttEdit_Click);
            // 
            // txtNRegisto_Edit
            // 
            this.txtNRegisto_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtNRegisto_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNRegisto_Edit.BorderSize = 2;
            this.txtNRegisto_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNRegisto_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtNRegisto_Edit.Location = new System.Drawing.Point(128, 16);
            this.txtNRegisto_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNRegisto_Edit.Multiline = false;
            this.txtNRegisto_Edit.Name = "txtNRegisto_Edit";
            this.txtNRegisto_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtNRegisto_Edit.PasswordChar = false;
            this.txtNRegisto_Edit.Size = new System.Drawing.Size(61, 35);
            this.txtNRegisto_Edit.TabIndex = 0;
            this.txtNRegisto_Edit.Texts = "";
            this.txtNRegisto_Edit.UnderlinedStyle = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(16, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº de Registo";
            // 
            // gpbData_Edit
            // 
            this.gpbData_Edit.Controls.Add(this.label2);
            this.gpbData_Edit.Controls.Add(this.txtDataEntrega_Edit);
            this.gpbData_Edit.Location = new System.Drawing.Point(296, 72);
            this.gpbData_Edit.Name = "gpbData_Edit";
            this.gpbData_Edit.Size = new System.Drawing.Size(568, 64);
            this.gpbData_Edit.TabIndex = 19;
            this.gpbData_Edit.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(240, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data de Entrada";
            // 
            // txtDataEntrega_Edit
            // 
            this.txtDataEntrega_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtDataEntrega_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtDataEntrega_Edit.BorderSize = 2;
            this.txtDataEntrega_Edit.Enabled = false;
            this.txtDataEntrega_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataEntrega_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtDataEntrega_Edit.Location = new System.Drawing.Point(376, 16);
            this.txtDataEntrega_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtDataEntrega_Edit.Multiline = false;
            this.txtDataEntrega_Edit.Name = "txtDataEntrega_Edit";
            this.txtDataEntrega_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtDataEntrega_Edit.PasswordChar = false;
            this.txtDataEntrega_Edit.Size = new System.Drawing.Size(176, 35);
            this.txtDataEntrega_Edit.TabIndex = 2;
            this.txtDataEntrega_Edit.Texts = "";
            this.txtDataEntrega_Edit.UnderlinedStyle = true;
            // 
            // gpbEstado_Edit
            // 
            this.gpbEstado_Edit.Controls.Add(this.rjComboBox_Est);
            this.gpbEstado_Edit.Controls.Add(this.label11);
            this.gpbEstado_Edit.Location = new System.Drawing.Point(296, 536);
            this.gpbEstado_Edit.Name = "gpbEstado_Edit";
            this.gpbEstado_Edit.Size = new System.Drawing.Size(416, 64);
            this.gpbEstado_Edit.TabIndex = 17;
            this.gpbEstado_Edit.TabStop = false;
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
            this.rjComboBox_Est.Enabled = false;
            this.rjComboBox_Est.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_Est.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Est.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Est.Items.AddRange(new object[] {
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
            this.rjComboBox_Est.Texts = "";
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
            // gpbAqi_Edit
            // 
            this.gpbAqi_Edit.Controls.Add(this.rjComboBox_Aqi_Edit);
            this.gpbAqi_Edit.Controls.Add(this.label8);
            this.gpbAqi_Edit.Controls.Add(this.txtEditora_Edit);
            this.gpbAqi_Edit.Controls.Add(this.label9);
            this.gpbAqi_Edit.Location = new System.Drawing.Point(296, 272);
            this.gpbAqi_Edit.Name = "gpbAqi_Edit";
            this.gpbAqi_Edit.Size = new System.Drawing.Size(568, 128);
            this.gpbAqi_Edit.TabIndex = 18;
            this.gpbAqi_Edit.TabStop = false;
            // 
            // rjComboBox_Aqi_Edit
            // 
            this.rjComboBox_Aqi_Edit.AutoCompleteCustomSource.AddRange(new string[] {
            "Compra",
            "Doação"});
            this.rjComboBox_Aqi_Edit.BackColor = System.Drawing.Color.WhiteSmoke;
            this.rjComboBox_Aqi_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Aqi_Edit.BorderSize = 1;
            this.rjComboBox_Aqi_Edit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;
            this.rjComboBox_Aqi_Edit.Enabled = false;
            this.rjComboBox_Aqi_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.rjComboBox_Aqi_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Aqi_Edit.IconColor = System.Drawing.Color.MediumSlateBlue;
            this.rjComboBox_Aqi_Edit.Items.AddRange(new object[] {
            "Compra",
            "Oferta"});
            this.rjComboBox_Aqi_Edit.ListBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(228)))), ((int)(((byte)(245)))));
            this.rjComboBox_Aqi_Edit.ListTextColor = System.Drawing.Color.DimGray;
            this.rjComboBox_Aqi_Edit.Location = new System.Drawing.Point(128, 24);
            this.rjComboBox_Aqi_Edit.MinimumSize = new System.Drawing.Size(200, 30);
            this.rjComboBox_Aqi_Edit.Name = "rjComboBox_Aqi_Edit";
            this.rjComboBox_Aqi_Edit.Padding = new System.Windows.Forms.Padding(1);
            this.rjComboBox_Aqi_Edit.Size = new System.Drawing.Size(200, 30);
            this.rjComboBox_Aqi_Edit.TabIndex = 8;
            this.rjComboBox_Aqi_Edit.Texts = "Tipo de aquisição";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(62, 88);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(57, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Editora";
            // 
            // txtEditora_Edit
            // 
            this.txtEditora_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtEditora_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtEditora_Edit.BorderSize = 2;
            this.txtEditora_Edit.Enabled = false;
            this.txtEditora_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEditora_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtEditora_Edit.Location = new System.Drawing.Point(128, 76);
            this.txtEditora_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtEditora_Edit.Multiline = false;
            this.txtEditora_Edit.Name = "txtEditora_Edit";
            this.txtEditora_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtEditora_Edit.PasswordChar = false;
            this.txtEditora_Edit.Size = new System.Drawing.Size(427, 35);
            this.txtEditora_Edit.TabIndex = 6;
            this.txtEditora_Edit.Texts = "";
            this.txtEditora_Edit.UnderlinedStyle = true;
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
            // gpbCota_Edit
            // 
            this.gpbCota_Edit.Controls.Add(this.txtObservacoes_Edit);
            this.gpbCota_Edit.Controls.Add(this.label6);
            this.gpbCota_Edit.Controls.Add(this.label7);
            this.gpbCota_Edit.Controls.Add(this.txtCota_Edit);
            this.gpbCota_Edit.Controls.Add(this.label4);
            this.gpbCota_Edit.Controls.Add(this.txtNVolume_Edit);
            this.gpbCota_Edit.Location = new System.Drawing.Point(296, 400);
            this.gpbCota_Edit.Name = "gpbCota_Edit";
            this.gpbCota_Edit.Size = new System.Drawing.Size(568, 136);
            this.gpbCota_Edit.TabIndex = 18;
            this.gpbCota_Edit.TabStop = false;
            // 
            // txtObservacoes_Edit
            // 
            this.txtObservacoes_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtObservacoes_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtObservacoes_Edit.BorderSize = 2;
            this.txtObservacoes_Edit.Enabled = false;
            this.txtObservacoes_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtObservacoes_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtObservacoes_Edit.Location = new System.Drawing.Point(128, 80);
            this.txtObservacoes_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtObservacoes_Edit.Multiline = false;
            this.txtObservacoes_Edit.Name = "txtObservacoes_Edit";
            this.txtObservacoes_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtObservacoes_Edit.PasswordChar = false;
            this.txtObservacoes_Edit.Size = new System.Drawing.Size(427, 35);
            this.txtObservacoes_Edit.TabIndex = 9;
            this.txtObservacoes_Edit.Texts = "";
            this.txtObservacoes_Edit.UnderlinedStyle = true;
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
            // txtCota_Edit
            // 
            this.txtCota_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtCota_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtCota_Edit.BorderSize = 2;
            this.txtCota_Edit.Enabled = false;
            this.txtCota_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCota_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtCota_Edit.Location = new System.Drawing.Point(128, 16);
            this.txtCota_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtCota_Edit.Multiline = false;
            this.txtCota_Edit.Name = "txtCota_Edit";
            this.txtCota_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtCota_Edit.PasswordChar = false;
            this.txtCota_Edit.Size = new System.Drawing.Size(102, 35);
            this.txtCota_Edit.TabIndex = 10;
            this.txtCota_Edit.Texts = "";
            this.txtCota_Edit.UnderlinedStyle = true;
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
            // txtNVolume_Edit
            // 
            this.txtNVolume_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtNVolume_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtNVolume_Edit.BorderSize = 2;
            this.txtNVolume_Edit.Enabled = false;
            this.txtNVolume_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNVolume_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtNVolume_Edit.Location = new System.Drawing.Point(424, 16);
            this.txtNVolume_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtNVolume_Edit.Multiline = false;
            this.txtNVolume_Edit.Name = "txtNVolume_Edit";
            this.txtNVolume_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtNVolume_Edit.PasswordChar = false;
            this.txtNVolume_Edit.Size = new System.Drawing.Size(63, 35);
            this.txtNVolume_Edit.TabIndex = 8;
            this.txtNVolume_Edit.Texts = "";
            this.txtNVolume_Edit.UnderlinedStyle = true;
            // 
            // gpbAutor_Edit
            // 
            this.gpbAutor_Edit.Controls.Add(this.label5);
            this.gpbAutor_Edit.Controls.Add(this.txtTitulo_Edit);
            this.gpbAutor_Edit.Controls.Add(this.label3);
            this.gpbAutor_Edit.Controls.Add(this.txtAutor_Edit);
            this.gpbAutor_Edit.Location = new System.Drawing.Point(296, 144);
            this.gpbAutor_Edit.Name = "gpbAutor_Edit";
            this.gpbAutor_Edit.Size = new System.Drawing.Size(568, 128);
            this.gpbAutor_Edit.TabIndex = 17;
            this.gpbAutor_Edit.TabStop = false;
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
            // txtTitulo_Edit
            // 
            this.txtTitulo_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtTitulo_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtTitulo_Edit.BorderSize = 2;
            this.txtTitulo_Edit.Enabled = false;
            this.txtTitulo_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTitulo_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtTitulo_Edit.Location = new System.Drawing.Point(128, 76);
            this.txtTitulo_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtTitulo_Edit.Multiline = false;
            this.txtTitulo_Edit.Name = "txtTitulo_Edit";
            this.txtTitulo_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtTitulo_Edit.PasswordChar = false;
            this.txtTitulo_Edit.Size = new System.Drawing.Size(427, 35);
            this.txtTitulo_Edit.TabIndex = 6;
            this.txtTitulo_Edit.Texts = "";
            this.txtTitulo_Edit.UnderlinedStyle = true;
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
            // txtAutor_Edit
            // 
            this.txtAutor_Edit.BackColor = System.Drawing.SystemColors.Window;
            this.txtAutor_Edit.BorderColor = System.Drawing.Color.MediumSlateBlue;
            this.txtAutor_Edit.BorderSize = 2;
            this.txtAutor_Edit.Enabled = false;
            this.txtAutor_Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAutor_Edit.ForeColor = System.Drawing.Color.DimGray;
            this.txtAutor_Edit.Location = new System.Drawing.Point(128, 16);
            this.txtAutor_Edit.Margin = new System.Windows.Forms.Padding(4);
            this.txtAutor_Edit.Multiline = false;
            this.txtAutor_Edit.Name = "txtAutor_Edit";
            this.txtAutor_Edit.Padding = new System.Windows.Forms.Padding(9);
            this.txtAutor_Edit.PasswordChar = false;
            this.txtAutor_Edit.Size = new System.Drawing.Size(427, 35);
            this.txtAutor_Edit.TabIndex = 4;
            this.txtAutor_Edit.Texts = "";
            this.txtAutor_Edit.UnderlinedStyle = true;
            // 
            // bttSave
            // 
            this.bttSave.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.bttSave.Enabled = false;
            this.bttSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bttSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttSave.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.bttSave.Location = new System.Drawing.Point(744, 560);
            this.bttSave.Margin = new System.Windows.Forms.Padding(0);
            this.bttSave.Name = "bttSave";
            this.bttSave.Size = new System.Drawing.Size(120, 32);
            this.bttSave.TabIndex = 15;
            this.bttSave.Text = "Guardar";
            this.bttSave.UseVisualStyleBackColor = false;
            this.bttSave.Click += new System.EventHandler(this.bttSave_Click);
            // 
            // Panel_Edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(974, 647);
            this.Controls.Add(this.pnlEdit);
            this.Name = "Panel_Edit";
            this.Text = "Panel_Edit";
            this.Load += new System.EventHandler(this.Panel_Edit_Load);
            this.pnlEdit.ResumeLayout(false);
            this.gpbN_Edit.ResumeLayout(false);
            this.gpbN_Edit.PerformLayout();
            this.gpbData_Edit.ResumeLayout(false);
            this.gpbData_Edit.PerformLayout();
            this.gpbEstado_Edit.ResumeLayout(false);
            this.gpbEstado_Edit.PerformLayout();
            this.gpbAqi_Edit.ResumeLayout(false);
            this.gpbAqi_Edit.PerformLayout();
            this.gpbCota_Edit.ResumeLayout(false);
            this.gpbCota_Edit.PerformLayout();
            this.gpbAutor_Edit.ResumeLayout(false);
            this.gpbAutor_Edit.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlEdit;
        private System.Windows.Forms.GroupBox gpbEstado_Edit;
        private RJControls.RJComboBox rjComboBox_Est;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.GroupBox gpbAqi_Edit;
        private RJControls.RJComboBox rjComboBox_Aqi_Edit;
        private System.Windows.Forms.Label label8;
        private txtTitulo txtEditora_Edit;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox gpbCota_Edit;
        private txtTitulo txtObservacoes_Edit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private txtTitulo txtCota_Edit;
        private System.Windows.Forms.Label label4;
        private txtTitulo txtNVolume_Edit;
        private System.Windows.Forms.GroupBox gpbAutor_Edit;
        private System.Windows.Forms.Label label5;
        private txtTitulo txtTitulo_Edit;
        private System.Windows.Forms.Label label3;
        private txtTitulo txtAutor_Edit;
        private System.Windows.Forms.Button bttSave;
        private System.Windows.Forms.GroupBox gpbData_Edit;
        private System.Windows.Forms.Label label2;
        private txtTitulo txtDataEntrega_Edit;
        private System.Windows.Forms.Label label1;
        private txtTitulo txtNRegisto_Edit;
        private System.Windows.Forms.Button bttEdit;
        private System.Windows.Forms.GroupBox gpbN_Edit;
    }
}
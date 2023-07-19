﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using LivroDeRegistos_v1.RJControls;

namespace LivroDeRegistos_v1.gui
{
    public partial class Panel_Edit : Form
    {
        public Panel_Edit()
        {
            this.InitializeComponent();
        }

        public Panel GetPanel_Edit()
        {
            return this.pnlEdit;
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar"))
                return;

            int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
            this.UnableText();
            this.FillTextBoxes(numeroRegistro);
            this.EnableText();
            this.txtNRegisto_Edit.Enabled = false;
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar") ||
                !this.ValidateTextBox(this.txtDataEntrega_Edit, "a data de entrada do exemplar") ||
                !this.ValidateTextBox(this.txtTitulo_Edit, "o título do exemplar") ||
                !this.ValidateTextBox(this.txtAutor_Edit, "o autor do exemplar") ||
                !this.ValidateTextBox(this.txtCota_Edit, "a cota do exemplar") ||
                !this.ValidateTextBox(this.txtNVolume_Edit, "o número de volume do exemplar") ||
                !this.ValidateTextBox(this.txtEditora_Edit, "a editora do exemplar") ||
                !this.ValidateTextBox(this.txtObservacoes_Edit, "as observações"))
                return;

            // Recuperar as informações atualizadas das textboxes
            int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
            DateTime dataEntrega = DateTime.ParseExact(this.txtDataEntrega_Edit.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string titulo = this.txtTitulo_Edit.Texts;
            string autor = this.txtAutor_Edit.Texts;
            string cota = this.txtCota_Edit.Texts;
            string aquisicao = this.rjComboBox_Aqi_Edit.Texts;
            string editora = this.txtEditora_Edit.Texts;
            string numeroVolume = this.txtNVolume_Edit.Texts;
            string observacoes = this.txtObservacoes_Edit.Texts;
            string estado = this.rjComboBox_Est.Texts;

            try
            {
                // Criar uma instância da classe Registo_Livro
                Registo_Livro registoLivro = new Registo_Livro();
                // Verificar se o autor existe na base de dados

                int autorID = registoLivro.GetAuthorID(autor);
                if (autorID == -1)
                    // Autor não existe, criar novo autor
                    autorID = registoLivro.CreateAuthor(autor);

                // Verificar se a cota existe na base de dados
                int cotaID = registoLivro.GetCotaID(cota);
                if (cotaID == -1)
                    // Cota não existe, criar nova cota
                    cotaID = registoLivro.CreateCota(cota);
                // Chamar o método de atualização passando as informações atualizadas e o número de registro
                registoLivro.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado);

                // Exibir uma mensagem de sucesso para o usuário
                MessageBox.Show("Registo atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar a exibição dos dados, se necessário
                // ...
                this.ClearText();
                this.UnableText();
                this.bttSave.Enabled = false;
                this.txtNRegisto_Edit.Enabled = true;
                
            }
            catch (Exception ex)
            {
                // Tratar a exceção e exibir uma mensagem de erro para o usuário
                MessageBox.Show("Ocorreu um erro ao atualizar o registro: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FillTextBoxes(int numeroRegistro)
        {
            Registo_Livro registoLivro = new Registo_Livro();
            List<Livro> livros = registoLivro.GetBooks_Edit();

            // Encontrar o livro com o número de registro especificado
            Livro livroSelecionado = livros.FirstOrDefault(livro => livro.NumeroRegistro == numeroRegistro);

            if (livroSelecionado != null)
            {
                // Preencher as textboxes com as informações do livro
                this.txtDataEntrega_Edit.Texts = livroSelecionado.DataEntrada.ToString("dd/MM/yyyy");
                this.txtTitulo_Edit.Texts = livroSelecionado.Titulo;
                this.txtAutor_Edit.Texts = livroSelecionado.Autor;
                this.txtCota_Edit.Texts = livroSelecionado.Cota;
                this.rjComboBox_Aqi_Edit.Texts = livroSelecionado.Aquisicao;
                this.txtEditora_Edit.Texts = livroSelecionado.Editora;
                this.txtNVolume_Edit.Texts = livroSelecionado.NumeroVolume;
                this.txtObservacoes_Edit.Texts = livroSelecionado.Observacoes;
                this.rjComboBox_Est.Texts = livroSelecionado.Estado;
                this.txtNRegisto_Edit.Enabled = false;
            }
            else
            {
                // Livro não encontrado
                MessageBox.Show("Livro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearText()
        {
            this.txtDataEntrega_Edit.Texts = "";
            this.txtAutor_Edit.Texts = "";
            this.txtTitulo_Edit.Texts = "";
            this.txtCota_Edit.Texts = "";
            this.txtEditora_Edit.Texts = "";
            this.rjComboBox_Est.Texts = "<Estado>";
            this.rjComboBox_Aqi_Edit.Texts = "<Aquisição>";
            this.txtNVolume_Edit.Texts = "";
            this.txtObservacoes_Edit.Texts = "";
        }
        private void EnableText()
        {
            this.gpbData_Edit.Enabled = true;
            this.gpbAutor_Edit.Enabled = true;
            this.gpbCota_Edit.Enabled = true;
            this.gpbEstado_Edit.Enabled = true;
            this.gpbAqi_Edit.Enabled = true;
            this.bttSave.Enabled = true;
            this.bttClear_Edit.Enabled = true;
        }
        private void UnableText()
        {
            this.gpbData_Edit.Enabled = false;
            this.gpbAutor_Edit.Enabled = false;
            this.gpbCota_Edit.Enabled = false;
            this.gpbEstado_Edit.Enabled = false;
            this.gpbAqi_Edit.Enabled = false;
            this.bttClear_Edit.Enabled = false;
        }
        private bool ValidateTextBox(txtTitulo textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == this.txtDataEntrega_Edit)
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }
        private void Panel_Edit_Load(object sender, EventArgs e)
        {
        }
        private void gpbAqi_Edit_Enter(object sender, EventArgs e)
        {

        }
        private void bttClear_Edit_Click(object sender, EventArgs e)
        {
            ClearText();
        }
        private void txtNRegisto_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
        private void txtDataEntrega_Edit_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }
    }
}
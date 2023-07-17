using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace LivroDeRegistos_v1
{
    public partial class Panel_Edit : Form
    {
        public Panel_Edit()
        {
            InitializeComponent();
        }

        public Panel GetPanel_Edit()
        {
            return this.pnlEdit;
        }

        private void bttEdit_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtNRegisto_Edit, "o número de registo do exemplar"))
                return;

            int numeroRegistro = int.Parse(txtNRegisto_Edit.Texts);
            FillTextBoxes(numeroRegistro);
            EnableText();
        }

        private void bttSave_Click(object sender, EventArgs e)
        {
            if (!ValidateTextBox(txtDataEntrega_Edit, "a data de entrada do exemplar") ||
                !ValidateTextBox(txtTitulo_Edit, "o título do exemplar") ||
                !ValidateTextBox(txtAutor_Edit, "o autor do exemplar") ||
                !ValidateTextBox(txtCota_Edit, "a cota do exemplar") ||
                !ValidateTextBox(txtNVolume_Edit, "o número de volume do exemplar") ||
                !ValidateTextBox(txtEditora_Edit, "a editora do exemplar") ||
                !ValidateTextBox(txtObservacoes_Edit, "as observações"))
            {
                return;
            }

            // Recuperar as informações atualizadas das textboxes
            int numeroRegistro = int.Parse(txtNRegisto_Edit.Texts);
            DateTime dataEntrega = DateTime.ParseExact(txtDataEntrega_Edit.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            string titulo = txtTitulo_Edit.Texts;
            string autor = txtAutor_Edit.Texts;
            string cota = txtCota_Edit.Texts;
            string aquisicao = rjComboBox_Aqi_Edit.Texts;
            string editora = txtEditora_Edit.Texts;
            string numeroVolume = txtNVolume_Edit.Texts;
            string observacoes = txtObservacoes_Edit.Texts;
            string estado = rjComboBox_Est.Texts;

            try
            {
                // Criar uma instância da classe Registo_Livro
                Registo_Livro registoLivro = new Registo_Livro();
                // Verificar se o autor existe na base de dados

                int autorID = registoLivro.GetAuthorID(autor);
                if (autorID == -1)
                {
                    // Autor não existe, criar novo autor
                    autorID = registoLivro.CreateAuthor(autor);
                }

                // Verificar se a cota existe na base de dados
                int cotaID = registoLivro.GetCotaID(cota);
                if (cotaID == -1)
                {
                    // Cota não existe, criar nova cota
                    cotaID = registoLivro.CreateCota(cota);
                }
                // Chamar o método de atualização passando as informações atualizadas e o número de registro
                registoLivro.UpdateBook(numeroRegistro, dataEntrega, titulo, autor, cota, aquisicao, editora, numeroVolume, observacoes, estado);

                // Exibir uma mensagem de sucesso para o usuário
                MessageBox.Show("Registo atualizado com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Atualizar a exibição dos dados, se necessário
                // ...
                ClearText();
                UnableText();

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
                txtDataEntrega_Edit.Texts = livroSelecionado.DataEntrada.ToString("dd/MM/yyyy");
                txtTitulo_Edit.Texts = livroSelecionado.Titulo;
                txtAutor_Edit.Texts = livroSelecionado.Autor;
                txtCota_Edit.Texts = livroSelecionado.Cota;
                rjComboBox_Aqi_Edit.Texts = livroSelecionado.Aquisicao;
                txtEditora_Edit.Texts = livroSelecionado.Editora;
                txtNVolume_Edit.Texts = livroSelecionado.NumeroVolume;
                txtObservacoes_Edit.Texts = livroSelecionado.Observacoes;
                rjComboBox_Est.Texts = livroSelecionado.Estado;
            }
            else
            {
                // Livro não encontrado
                MessageBox.Show("Livro não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearText()
        {
            txtNRegisto_Edit.Texts = "";
            txtDataEntrega_Edit.Texts = "";
            txtAutor_Edit.Texts = "";
            txtTitulo_Edit.Texts = "";
            txtCota_Edit.Texts = "";
            txtEditora_Edit.Texts = "";
            rjComboBox_Est.Texts = "";
            rjComboBox_Aqi_Edit.Texts = "";
            txtNVolume_Edit.Texts = "";
            txtObservacoes_Edit.Texts = "";
            bttSave.Enabled = false;
        }

        private void EnableText()
        {
            txtNRegisto_Edit.Enabled = true;
            txtDataEntrega_Edit.Enabled = true;
            txtAutor_Edit.Enabled = true;
            txtTitulo_Edit.Enabled = true;
            txtCota_Edit.Enabled = true;
            txtEditora_Edit.Enabled = true;
            rjComboBox_Aqi_Edit.Enabled = true;
            rjComboBox_Est.Enabled = true;
            txtNVolume_Edit.Enabled = true;
            txtObservacoes_Edit.Enabled = true;
            bttSave.Enabled = true;
        }

        private void UnableText()
        {
            gpbData_Edit.Enabled = false;
            gpbAutor_Edit.Enabled = false;
            gpbCota_Edit.Enabled = false;
            gpbEstado_Edit.Enabled = false;
            gpbAqi_Edit.Enabled = false;
        }

        private bool ValidateTextBox(txtTitulo textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == txtDataEntrega_Edit)
            {
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/yyyy.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }

            return true;
        }

        private void Panel_Edit_Load(object sender, EventArgs e)
        {

        }
    }
}

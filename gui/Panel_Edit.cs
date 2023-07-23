using LivroDeRegistos_v1.RJControls;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

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

        /// <summary>
        /// Handles the click event of the "Edit" button. Validates the "Número de Registo" (registration number) input in the <see cref="txtNRegisto_Edit"/> textbox.
        /// If the input is valid, disables textboxes and fills them with information about the book corresponding to the provided registration number.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void bttEdit_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtNRegisto_Edit, "o número de registo do exemplar"))
                return;

            int numeroRegistro = int.Parse(this.txtNRegisto_Edit.Texts);
            this.UnableText();
            this.FillTextBoxes(numeroRegistro);
        }

        /// <summary>
        /// Handles the click event of the "Save" button. Validates the inputs in various textboxes (registration number, data de entrega, title, author, cota, etc.).
        /// If all inputs are valid, retrieves the updated information from the textboxes, checks if the author and cota already exist in the database,
        /// and creates them if not. Then, updates the book record in the database with the new information.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
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

        /// <summary>
        /// Fills the textboxes with information about the book corresponding to the provided registration number.
        /// If the book is found, the textboxes are filled with the book information. Otherwise, an error message is displayed.
        /// </summary>
        /// <param name="numeroRegistro">The registration number of the book to be retrieved from the database.</param>
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
                this.EnableText();


            }
            else
            {
                // Livro não encontrado
                MessageBox.Show("Livro não encontrado.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtNRegisto_Edit.Enabled = true;
            }
        }

        /// <summary>
        /// Handles the click event of the "Delete" button. Validates the "Número de Registo" (registration number) input in the <see cref="txtNRegisto_Edit"/> textbox.
        /// If the input is valid and the book with the provided registration number exists, the book record is deleted from the database.
        /// Otherwise, appropriate error messages are displayed to the user.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">An <see cref="EventArgs"/> that contains the event data.</param>
        private void bttDel_Click(object sender, EventArgs e)
        {
            try
            {
                if (!ValidateTextBox(txtNRegisto_Edit, "o número de registo do exemplar"))
                    return;

                // Parse the registration number input
                int numeroRegistro = int.Parse(txtNRegisto_Edit.Texts);

                // Create an instance of the Registo_Livro class
                Registo_Livro registoLivro = new Registo_Livro();

                // Check if the book with the provided registration number exists before attempting to delete
                if (registoLivro.IsRegistrationNumberExists(numeroRegistro))
                {
                    // Call the method to delete the book record
                    registoLivro.DeleteBook(numeroRegistro);

                    // Display a success message to the user
                    MessageBox.Show("Registo excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Clear the textboxes, disable them, and enable the "Edit" button
                    ClearText();
                    UnableText();
                    bttSave.Enabled = false;
                    txtNRegisto_Edit.Enabled = true;
                }
                else
                {
                    // Display an error message indicating that the book with this registration number does not exist
                    MessageBox.Show("O livro com este número de registo não existe.", "Falha ao remover", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                // Handle the exception and display an error message to the user
                MessageBox.Show("Ocorreu um erro ao excluir o registro: " + ex.Message, "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
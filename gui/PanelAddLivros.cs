using LivroDeRegistos_v1.RJControls;
using System;
using System.Globalization;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class PanelAddLivros : Form
    {
        private string id;
        public PanelAddLivros()
        {
            this.InitializeComponent();
        }

        public Panel GetPanel_Add()
        {
            this.GetNRegisto();
            return this.pnlAdd;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            Registo_Livro registo_Livro = new Registo_Livro();

            if (registo_Livro.IsRegistrationNumberExists(int.Parse(txtNRegisto.Texts)))
            {
                MessageBox.Show("O número de registo já existe na base de dados.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else this.SaveData();

        }

        private void GetNRegisto()
        {
            try
            {
                Registo_Livro nReg = new Registo_Livro();

                this.txtNRegisto.Texts = nReg.GetId(this.id);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter o ID do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveData()
        {
            if (!this.ValidateTextBox(this.txtNRegisto, "o número de registo do exemplar") ||
                !this.ValidateTextBox(this.txtDataEntrega, "a data de entrada do exemplar") ||
                !this.ValidateTextBox(this.txtTitulo, "o título do exemplar") ||
                !this.ValidateTextBox(this.txtAutor, "o autor do exemplar") ||
                !this.ValidateTextBox(this.txtCota, "a cota do exemplar") ||
                !this.ValidateTextBox(this.txtNVolume, "o número de volume do exemplar") ||
                !this.ValidateTextBox(this.txtEditora, "a editora do exemplar") ||
                !this.ValidateTextBox(this.txtObservacoes, "as observações"))
                return;

            DateTime dataEntrega = DateTime.ParseExact(this.txtDataEntrega.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (this.rjComboBox_Aqi.Texts == "" || this.rjComboBox_Est.Texts == "")
            {
                MessageBox.Show("Campo(s) de escolha vazio(s).", "Falha ao registar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int nRegisto = int.Parse(this.txtNRegisto.Texts);
            string titulo = this.txtTitulo.Texts;
            string autor = this.txtAutor.Texts;
            string cota = this.txtCota.Texts;
            string nVolume = this.txtNVolume.Texts;
            string aquisicao = this.rjComboBox_Aqi.Texts;
            string editora = this.txtEditora.Texts;
            string observacoes = this.txtObservacoes.Texts;
            string estado = this.rjComboBox_Est.Texts;

            // Chamar o método SaveData apenas se a validação for bem-sucedida
            Registo_Livro save = new Registo_Livro();
            save.GetNextRegistrationNumber();

            save.SaveData(nRegisto, dataEntrega, titulo, autor, cota, nVolume, aquisicao, editora, observacoes, estado);

            MessageBox.Show("Exemplar adicionado com êxito", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            this.txtNRegisto.Texts = (nRegisto + 1).ToString();
        }

        private bool ValidateTextBox(txtTitulo textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar se a data está no formato correto
            if (textBox == this.txtDataEntrega)
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }

        private void txtNRegisto_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void txtDataEntrega_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private void ClearText()
        {
            this.txtDataEntrega.Texts = "";
            this.txtAutor.Texts = "";
            this.txtTitulo.Texts = "";
            this.txtCota.Texts = "";
            this.txtEditora.Texts = "";
            this.rjComboBox_Est.Texts = "";
            this.rjComboBox_Aqi.Texts = "";
            this.txtNVolume.Texts = "";
            this.txtObservacoes.Texts = "";
        }

        private void bttClearText_Click_1(object sender, EventArgs e)
        {
            ClearText();
        }

      
        

       
    }
}
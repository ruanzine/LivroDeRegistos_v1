using System;
using System.Globalization;
using System.Windows.Forms;

namespace LivroDeRegistos_v1
{
    public partial class PanelAddLivros : Form
    {
        private string id;
        public PanelAddLivros()
        {
            InitializeComponent();
        }

        public Panel GetPanel_Add()
        {
            GetNRegisto();
            return this.pnlAdd;
        }

        private void bttAdd_Click(object sender, EventArgs e)
        {
            SaveData();
        }

        void GetNRegisto()
        {
            try
            {

                Registo_Livro nReg = new Registo_Livro();

                txtNRegisto.Texts = nReg.GetId(id);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter o ID do banco de dados: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void SaveData()
        {
            if (!ValidateTextBox(txtNRegisto, "o número de registo do exemplar") ||
                !ValidateTextBox(txtDataEntrega, "a data de entrada do exemplar") ||
                !ValidateTextBox(txtTitulo, "o título do exemplar") ||
                !ValidateTextBox(txtAutor, "o autor do exemplar") ||
                !ValidateTextBox(txtCota, "a cota do exemplar") ||
                !ValidateTextBox(txtNVolume, "o número de volume do exemplar") ||
                !ValidateTextBox(txtEditora, "a editora do exemplar") ||
                !ValidateTextBox(txtObservacoes, "as observações"))
            {
                return;
            }

            
            DateTime dataEntrega = DateTime.ParseExact(txtDataEntrega.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            if (rjComboBox_Aqi.Texts == "" || rjComboBox_Est.Texts == "") MessageBox.Show("Campo(s) de escolha vazio(s).", "Falha ao registar", MessageBoxButtons.OK, MessageBoxIcon.Error);

            int nRegisto = int.Parse(txtNRegisto.Texts);
            string titulo = txtTitulo.Texts;
            string autor = txtAutor.Texts;
            string cota = txtCota.Texts;
            string nVolume = txtNVolume.Texts;
            string aquisicao = rjComboBox_Aqi.Texts;
            string editora = txtEditora.Texts;
            string observacoes = txtObservacoes.Texts;
            string estado = rjComboBox_Est.Text;

            // Chamar o método SaveData apenas se a validação for bem-sucedida
            Registo_Livro save = new Registo_Livro();
            save.GetNextRegistrationNumber();

            save.SaveData(nRegisto, dataEntrega, titulo, autor, cota, nVolume, aquisicao, editora, observacoes, estado);

            MessageBox.Show("Exemplar adicionado com êxito", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.None);
            txtNRegisto.Texts = (nRegisto + 1).ToString();
        }

        bool ValidateTextBox(txtTitulo textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Verificar se a data está no formato correto
            if (textBox == txtDataEntrega)
            {
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
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
    }
}

using ClosedXML.Excel;
using LivroDeRegistos_v1.RJControls;
using System;
using System.Data;
using System.Globalization;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class DateFromUntil : Form
    {
        private Registo_Livro registo_Livro;

        public DateFromUntil()
        {
            this.InitializeComponent();
        }

        public Panel GetFrame() => this.pnlDateListing;

        private void bttFiltrar_Click(object sender, EventArgs e)
        {
            if (!this.ValidateTextBox(this.txtAte, "a data de entrada do exemplar") ||
                !this.ValidateTextBox(this.txtDe, "a data de entrada do exemplar"))
                return;

            this.registo_Livro = new Registo_Livro();
            if (!DateTime.TryParse(txtDe.Texts, out DateTime dataDe) || !DateTime.TryParse(txtAte.Texts, out DateTime dataAte))
            {
                MessageBox.Show("Insira datas válidas nos campos De e Até.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dataDe > dataAte)
            {
                MessageBox.Show("A data inical não pode ser maior que a data final.", "Falha", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Realizar a consulta no banco de dados para obter os livros dentro do intervalo de datas
                DataTable livrosPorData = registo_Livro.GetBooksByDate_Listing(dataDe, dataAte);

                // Limpar as colunas existentes na DataGridView
                dgvListagemDate.Columns.Clear();

                dgvListagemDate.DataSource = null;

                // Limpar as linhas existentes na DataGridView
                dgvListagemDate.Rows.Clear();

                // Adicionar as colunas à DataGridView
                dgvListagemDate.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvListagemDate.Columns.Add("Data de Entrada", "Data de Entrada");
                dgvListagemDate.Columns.Add("Titulo", "Título");
                dgvListagemDate.Columns.Add("Autor", "Autor");
                dgvListagemDate.Columns.Add("Cota", "Cota");
                dgvListagemDate.Columns.Add("Aquisicao", "Aquisição");
                dgvListagemDate.Columns.Add("Editora", "Editora");
                dgvListagemDate.Columns.Add("NumVolume", "Nº de Volume");
                dgvListagemDate.Columns.Add("Observacoes", "Observações");
                dgvListagemDate.Columns.Add("Estado", "Estado");

                // Adicionar as informações dos livros à DataGridView
                foreach (DataRow row in livrosPorData.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();
                    string estado = row["Estado"].ToString();
                    string autor = row["Autor"].ToString();
                    DateTime data = Convert.ToDateTime(row["Data de Entrada"]);
                    string aquisicao = row["Aquisicao"].ToString();
                    string editora = row["Editora"].ToString();
                    string numeroVolume = row["Nº de Volume"].ToString();
                    string observacoes = row["Observações"].ToString();

                    dgvListagemDate.Rows.Add(numeroRegistro, data, autor, titulo, cota, aquisicao, editora, numeroVolume, observacoes, estado);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao buscar os livros por data: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void bttPrintDate_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Arquivo Excel|*.xlsx";
                    saveFileDialog.Title = "Salvar arquivo Excel";
                    saveFileDialog.FileName = "nome_do_arquivo";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        using (var workbook = new XLWorkbook())
                        {
                            var worksheet = workbook.Worksheets.Add("Planilha1");

                            // Adicionar o nome das colunas
                            for (int j = 0; j < dgvListagemDate.Columns.Count; j++)
                            {
                                worksheet.Cell(1, j + 1).Value = dgvListagemDate.Columns[j].HeaderText;
                            }

                            // Preencher a planilha com os dados da DataGridView
                            for (int i = 0; i < dgvListagemDate.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvListagemDate.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvListagemDate.Rows[i].Cells[j].Value.ToString();
                                }
                            }

                            // Salvar o arquivo do Excel
                            workbook.SaveAs(saveFileDialog.FileName);
                            MessageBox.Show("Arquivo exportado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao exportar o arquivo: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtDe_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;

        }

        private void txtAte_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Aceitar apenas números e "/" (barra) e teclas de controle (Backspace, Delete, etc.)
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '/' && !char.IsControl(e.KeyChar))
                e.Handled = true;
        }

        private bool ValidateTextBox(txtTitulo textBox, string fieldName)
        {
            if (string.IsNullOrEmpty(textBox.Texts))
            {
                MessageBox.Show($"Por favor, insira {fieldName}.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (textBox == this.txtDe)
                if (!DateTime.TryParseExact(textBox.Texts, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out _))
                {
                    MessageBox.Show($"Por favor, insira {fieldName} no formato dd/MM/aaaa.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

            return true;
        }
    }
}
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LivroDeRegistos_v1
{
    public partial class DGVBase : Form
    {
        private Registo_Livro registo_livro;
        public DGVBase()
        {
            InitializeComponent();
        }

        public Panel GetPanel_Search()
        {
            return this.pnlSearch;
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            registo_livro = new Registo_Livro();
            FillDGV();

        }

        public void FillDGV()
        {
            try
            {
                string selectedOption = rjComboBox_Search.Texts;
                string searchText = txtSearch.Texts;

                DataTable dt;

                switch (selectedOption)
                {
                    case "Número de Registo":
                        int numeroRegistro = int.TryParse(searchText, out int numReg) ? numReg : -1;
                        dt = registo_livro.GetBooksByNumeroRegistro(numeroRegistro);
                        break;
                    case "Autor":
                        dt = registo_livro.GetBooksByAutor(searchText);
                        break;
                    case "Título":
                        dt = registo_livro.GetBooksByTitulo(searchText);
                        break;
                    case "Cota":
                        dt = registo_livro.GetBooksByCota(searchText);
                        break;
                    case "Estado":
                        dt = registo_livro.GetBooksByEstado(searchText);
                        break;
                    default:
                        dt = registo_livro.GetBooks();
                        break;
                }

                dgvListagem.DataSource = dt;
                ResizeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResizeData()
        {
            //Header name resize
            dgvListagem.Columns["Nº"].Width = 50; // Define a largura da coluna
            dgvListagem.Columns["Data de Entrada"].Width = 90;
            dgvListagem.Columns["Título"].Width = 225;
            dgvListagem.Columns["Autor"].Width = 150;
            dgvListagem.Columns["Cota"].Width = 130;
            dgvListagem.Columns["Nº de Volume"].Width = 45;
            dgvListagem.Columns["Aquisição"].Width = 75;
            dgvListagem.Columns["Observações"].Width = 200;
            dgvListagem.Columns["Editora"].Width = 175;
            dgvListagem.Columns["Estado"].Width = 123;

            //Font
            dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            dgvListagem.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            dgvListagem.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagem.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagem.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagem.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvListagem.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            SetRowHeight(dgvListagem, 40);
            

        }

        private void dgvListagem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvListagem.Rows[e.RowIndex];
                string estado = row.Cells["Estado"].Value.ToString();

                if (estado == "Indisponível" || estado == "Abatido" || estado == "Perdido")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    // Define as cores padrão para as outras linhas
                    row.DefaultCellStyle.BackColor = dgvListagem.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = dgvListagem.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                row.Height = rowHeight;
            }
        }
    }
}

using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class DGVBase : Form
    {
        private Registo_Livro registo_livro;

        public DGVBase()
        {
            this.InitializeComponent();
        }

        public Panel GetPanel_Search()
        {
            return this.pnlSearch;
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            this.registo_livro = new Registo_Livro();
            this.FillDGV();
        }

        public void FillDGV()
        {
            try
            {
                string selectedOption = this.rjComboBox_Search.Texts;
                string searchText = this.txtSearch.Texts;

                DataTable dt;

                switch (selectedOption)
                {
                    case "Número de Registo":
                        int numeroRegistro = int.TryParse(searchText, out int numReg) ? numReg : -1;
                        dt = this.registo_livro.GetBooksByNumeroRegistro(numeroRegistro);
                        break;
                    case "Autor":
                        dt = this.registo_livro.GetBooksByAutor(searchText);
                        break;
                    case "Título":
                        dt = this.registo_livro.GetBooksByTitulo(searchText);
                        break;
                    case "Cota":
                        dt = this.registo_livro.GetBooksByCota(searchText);
                        break;
                    case "Estado":
                        dt = this.registo_livro.GetBooksByEstado(searchText);
                        break;
                    default:
                        dt = this.registo_livro.GetBooks();
                        break;
                }

                this.dgvListagem.DataSource = dt;
                this.ResizeData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResizeData()
        {
            //Header name resize
            this.dgvListagem.Columns["Nº"].Width = 50; // Define a largura da coluna
            this.dgvListagem.Columns["Data de Entrada"].Width = 90;
            this.dgvListagem.Columns["Título"].Width = 225;
            this.dgvListagem.Columns["Autor"].Width = 150;
            this.dgvListagem.Columns["Cota"].Width = 130;
            this.dgvListagem.Columns["Nº de Volume"].Width = 45;
            this.dgvListagem.Columns["Aquisição"].Width = 75;
            this.dgvListagem.Columns["Observações"].Width = 200;
            this.dgvListagem.Columns["Editora"].Width = 175;
            this.dgvListagem.Columns["Estado"].Width = 123;

            //Font
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagem.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.dgvListagem.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvListagem, 40);
        }

        private void dgvListagem_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvListagem.Rows[e.RowIndex];
                string estado = row.Cells["Estado"].Value.ToString();

                if (estado == "Indisponível" || estado == "Abatido" || estado == "Perdido")
                {
                    row.DefaultCellStyle.BackColor = Color.DarkRed;
                    row.DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    // Define as cores padrão para as outras linhas
                    row.DefaultCellStyle.BackColor = this.dgvListagem.DefaultCellStyle.BackColor;
                    row.DefaultCellStyle.ForeColor = this.dgvListagem.DefaultCellStyle.ForeColor;
                }
            }
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows) row.Height = rowHeight;
        }
    }
}
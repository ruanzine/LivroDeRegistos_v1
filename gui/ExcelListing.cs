using ClosedXML.Excel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class ExcelListing : Form
    {
        private Registo_Livro registo_Livro;

        public ExcelListing()
        {
            this.InitializeComponent();
            
            this.rjComboBox_SelectAll.OnSelectedIndexChanged += rjComboBox_SelectAll_OnSelectedIndexChanged;

        }

        public Panel GetFrame()
        {
            return this.pnlNormalListing;
        }

        /// <summary>
        /// Event handler for the "Print" button click. Exports the data from the DataGridView to an Excel file.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void bttPrint_Click(object sender, EventArgs e)
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
                            for (int j = 0; j < dgvListagemListing.Columns.Count; j++)
                            {
                                worksheet.Cell(1, j + 1).Value = dgvListagemListing.Columns[j].HeaderText;
                            }

                            // Preencher a planilha com os dados da DataGridView
                            for (int i = 0; i < dgvListagemListing.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvListagemListing.Columns.Count; j++)
                                {
                                    worksheet.Cell(i + 2, j + 1).Value = dgvListagemListing.Rows[i].Cells[j].Value.ToString();
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

        /// <summary>
        /// Event handler for the "Search" button click. Searches the database and fills the DataGridView with the results.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void bttSearch_Click(object sender, EventArgs e)
        {
            this.registo_Livro = new Registo_Livro();
            FillDGV();


        }

        private void bttBackMode_Click(object sender, EventArgs e)
        {
            // Limpar as colunas existentes no DataGridView
            this.dgvListagemListing.Columns.Clear();

            // Definir o DataSource como null para permitir a limpeza das linhas
            this.dgvListagemListing.DataSource = null;

            this.rjComboBox_SelectFilter.Enabled = true;
            this.rjComboBox_SelectAll.Texts = "<Filtro Avançado>";
            this.bttSearchListing.Visible = true;
            this.bttSearchListing.Enabled = true;


        }

        /// <summary>
        /// Event handler for the "SelectedIndexChanged" event of the rjComboBox_SelectFilter.
        /// Handles the behavior when the selected filter is changed.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void rjComboBox_SelectFilter_OnSelectedIndexChanged(object sender, EventArgs e)
        {

            if (rjComboBox_SelectFilter.Texts == "Nº de Registo")
            {
                this.rjComboBox_SelectAll.Visible = false;
            }
            if (rjComboBox_SelectFilter.Texts == "Autor")
            {
                this.registo_Livro = new Registo_Livro();

                // Buscar os autores na base de dados
                List<string> autores = registo_Livro.GetAuthors_List();

                // Limpar os itens da combobox
                rjComboBox_SelectAll.Items.Clear();

                // Adicionar os autores à combobox
                rjComboBox_SelectAll.Items.AddRange(autores.ToArray());
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;


            }
            if (rjComboBox_SelectFilter.Texts == "Cota")
            {
                this.registo_Livro = new Registo_Livro();

                // Buscar os autores na base de dados
                List<string> cotas = registo_Livro.GetCotas_List();

                // Limpar os itens da combobox
                rjComboBox_SelectAll.Items.Clear();

                // Adicionar os autores à combobox
                rjComboBox_SelectAll.Items.AddRange(cotas.ToArray());
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;

            }
            if (rjComboBox_SelectFilter.Texts == "Estado")
            {
                // Preencher a combobox rjComboBox_SelectAll com a lista de estados possíveis
                rjComboBox_SelectAll.Items.Clear();
                rjComboBox_SelectAll.Items.AddRange(new string[] { "Disponível", "Indisponível", "Abatido", "Perdido", "Consulta local", "Exposição", "Depósito" });
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;
            }

            if (rjComboBox_SelectFilter.Texts == "Título")
            {
                this.registo_Livro = new Registo_Livro();
                // Buscar os autores na base de dados
                List<string> titulos = registo_Livro.GetTitles_List();

                // Limpar os itens da combobox
                rjComboBox_SelectAll.Items.Clear();

                // Adicionar os autores à combobox
                rjComboBox_SelectAll.Items.AddRange(titulos.ToArray());
                this.rjComboBox_SelectAll.Visible = true;
                this.bttBackMode.Visible = true;
                this.bttPrint.Visible = true;
            }
        }

        /// <summary>
        /// Event handler for the "SelectedIndexChanged" event of the rjComboBox_SelectAll.
        /// Handles the behavior when the selected item in rjComboBox_SelectAll is changed.
        /// </summary>
        /// <param name="sender">The sender of the event.</param>
        /// <param name="e">The event arguments.</param>
        private void rjComboBox_SelectAll_OnSelectedIndexChanged(object sender, EventArgs e)
        {


            if (rjComboBox_SelectFilter.Texts == "<Filtro Avançado>")
            {
                this.bttSearchListing.Visible = true;

            }
            else if (rjComboBox_SelectFilter.Texts == "Título")
            {
                this.bttSearchListing.Visible = true;
                this.bttSearchListing.Enabled = false;
                this.rjComboBox_SelectFilter.Enabled = false;

                this.registo_Livro = new Registo_Livro();
                string tituloSelecionado = rjComboBox_SelectAll.Texts;
                // Realizar a consulta no banco de dados para obter os livros do estado selecionado
                DataTable livrosDoTitulo = registo_Livro.GetBooksByTitle_Listing(tituloSelecionado);

                // Limpar as colunas existentes no DataGridView
                dgvListagemListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvListagemListing.DataSource = null;
                // Limpar as linhas existentes no DataGridView
                dgvListagemListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvListagemListing.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvListagemListing.Columns.Add("Titulo", "Título");
                dgvListagemListing.Columns.Add("Cota", "Cota");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosDoTitulo.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();

                    dgvListagemListing.Rows.Add(numeroRegistro, titulo, cota);
                }
            }
            else if (rjComboBox_SelectFilter.Texts == "Estado")
            {
                this.bttSearchListing.Enabled = false;
                this.rjComboBox_SelectFilter.Enabled = false;
                string estadoSelecionado = rjComboBox_SelectAll.Texts;
                this.registo_Livro = new Registo_Livro();
                // Realizar a consulta no banco de dados para obter os livros do estado selecionado
                DataTable livrosDoEstado = registo_Livro.GetBooksByEstado_L(estadoSelecionado);

                // Limpar as colunas existentes no DataGridView
                dgvListagemListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvListagemListing.DataSource = null;

                // Limpar as linhas existentes no DataGridView
                dgvListagemListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvListagemListing.Columns.Add("NumeroRegistro", "Nº");
                dgvListagemListing.Columns.Add("Titulo", "Título");
                dgvListagemListing.Columns.Add("Cota", "Cota");
                dgvListagemListing.Columns.Add("Estado", "Estado");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosDoEstado.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();
                    string estado = row["Estado"].ToString();

                    dgvListagemListing.Rows.Add(numeroRegistro, titulo, cota, estado);
                }
            }
            else if (rjComboBox_SelectFilter.Texts == "Cota")
            {
                this.rjComboBox_SelectFilter.Enabled = false;
                this.bttSearchListing.Enabled = false;
                string cotaSelecionada = rjComboBox_SelectAll.Texts;

                // Realizar a consulta no banco de dados para obter os livros do autor selecionado
                DataTable livrosCota = registo_Livro.GetBooksByCota_Listing(cotaSelecionada);

                // Limpar as colunas existentes no DataGridView
                dgvListagemListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvListagemListing.DataSource = null;

                // Limpar as linhas existentes no DataGridView
                dgvListagemListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvListagemListing.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvListagemListing.Columns.Add("Titulo", "Título");
                dgvListagemListing.Columns.Add("Cota", "Cota");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosCota.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();

                    dgvListagemListing.Rows.Add(numeroRegistro, titulo, cota);
                }
            }
            else if (rjComboBox_SelectFilter.Texts == "Autor")
            {
                this.bttSearchListing.Enabled = false;
                this.rjComboBox_SelectFilter.Enabled = false;
                string autorSelecionado = rjComboBox_SelectAll.Texts;

                // Realizar a consulta no banco de dados para obter os livros do autor selecionado
                DataTable livrosDoAutor = registo_Livro.GetBooksByAuthor_Listing(autorSelecionado);

                // Limpar as colunas existentes no DataGridView
                dgvListagemListing.Columns.Clear();

                // Definir o DataSource como null para permitir a limpeza das linhas
                dgvListagemListing.DataSource = null;

                // Limpar as linhas existentes no DataGridView
                dgvListagemListing.Rows.Clear();

                // Adicionar as colunas ao DataGridView
                dgvListagemListing.Columns.Add("NumeroRegistro", "Nº de Registo");
                dgvListagemListing.Columns.Add("Titulo", "Título");
                dgvListagemListing.Columns.Add("Cota", "Cota");
                dgvListagemListing.Columns.Add("Estado", "Estado");

                // Adicionar as informações dos livros ao DataGridView
                foreach (DataRow row in livrosDoAutor.Rows)
                {
                    int numeroRegistro = Convert.ToInt32(row["Nº de Registo"]);
                    string titulo = row["Título"].ToString();
                    string cota = row["Cota"].ToString();
                    string estado = row["Estado"].ToString();

                    dgvListagemListing.Rows.Add(numeroRegistro, titulo, cota, estado);
                }

            }
            else
            {
                this.bttSearchListing.Visible = true;

            }


        }

        /// <summary>
        /// Fills the DataGridView (dgvListagemListing) based on the selected filter option (rjComboBox_SelectFilter.Texts).
        /// </summary>
        public void FillDGV()
        {
            try
            {
                string selectedOption = this.rjComboBox_SelectFilter.Texts;
                dgvListagemListing.DataSource = null;

                DataTable dt = new DataTable();

                switch (selectedOption)
                {
                    case "Nº de Registo":
                        dt = this.registo_Livro.GetAllNRegs();
                        break;
                    case "Autor":
                        dt = this.registo_Livro.GetAllAuthors();
                        break;
                    case "Título":
                        dt = this.registo_Livro.GetAllTitles();
                        break;
                    case "Cota":
                        dt = this.registo_Livro.GetAllCotas();
                        break;
                    case "Estado":
                        dt = this.registo_Livro.GetAllLost();
                        break;
                    default:
                        MessageBox.Show("Filtro inválido", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;

                }

                this.dgvListagemListing.DataSource = dt;

                if (this.rjComboBox_SelectFilter.Texts == "Nº de Registo") // Verifica se o índice selecionado é igual a 1
                {
                    ResizeNReg();
                }
                else if (this.rjComboBox_SelectFilter.Texts == "Título")
                {
                    ResizeTitle();
                }
                else if (this.rjComboBox_SelectFilter.Texts == "Autor")
                {
                    ResizeAuthor();
                }
                else if (this.rjComboBox_SelectFilter.Texts == "Cota")
                {
                    ResizeCota();
                }
                else if (this.rjComboBox_SelectFilter.Texts == "Estado")
                {
                    ResizeState();
                }
                else
                {
                    ResizeData();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro ao obter os livros: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ResizeNReg()
        {
            //Column width
            this.dgvListagemListing.Columns["Nº de Registo"].Width = 50;
            this.dgvListagemListing.Columns["Título"].Width = 250;

            //Font size
            this.dgvListagemListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagemListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Text Allignment
            this.dgvListagemListing.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna

        }

        public void ResizeAuthor()
        {

            //Header name resize
            this.dgvListagemListing.Columns["Autor"].Width = 250;

            //Font size and colour
            this.dgvListagemListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagemListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagemListing.Columns["Autor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvListagemListing, 40);
        }

        public void ResizeTitle()
        {
            //Header name resize
            this.dgvListagemListing.Columns["Título"].Width = 250;


            //Font size and colour
            this.dgvListagemListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagemListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.SetRowHeight(this.dgvListagemListing, 40);
        }

        public void ResizeCota()
        {
            this.dgvListagemListing.Columns["Cota"].Width = 130;

            //Font size and colour
            this.dgvListagemListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagemListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagemListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.SetRowHeight(this.dgvListagemListing, 40);

        }

        public void ResizeState()
        {
            //Header name resize
            this.dgvListagemListing.Columns["Nº de Registo"].Width = 50; // Define a largura da coluna
            this.dgvListagemListing.Columns["Título"].Width = 250;
            this.dgvListagemListing.Columns["Estado"].Width = 150;

            //Font size and colour
            this.dgvListagemListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagemListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagemListing.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna

            this.SetRowHeight(this.dgvListagemListing, 40);
        }

        public void ResizeData()
        {
            //Header name resize
            this.dgvListagemListing.Columns["Nº"].Width = 50; // Define a largura da coluna
            this.dgvListagemListing.Columns["Data de Entrada"].Width = 90;
            this.dgvListagemListing.Columns["Título"].Width = 225;
            this.dgvListagemListing.Columns["Autor"].Width = 150;
            this.dgvListagemListing.Columns["Cota"].Width = 130;
            this.dgvListagemListing.Columns["Nº de Volume"].Width = 45;
            this.dgvListagemListing.Columns["Aquisição"].Width = 75;
            this.dgvListagemListing.Columns["Observações"].Width = 200;
            this.dgvListagemListing.Columns["Editora"].Width = 175;
            this.dgvListagemListing.Columns["Estado"].Width = 123;

            //Font size and colour
            this.dgvListagemListing.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagemListing.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagemListing.Columns["Nº"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.dgvListagemListing.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagemListing.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagemListing.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagemListing.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagemListing.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvListagemListing, 40);
        }

        /// <summary>
        /// Sets the height of all rows in the given DataGridView to the specified value.
        /// </summary>
        /// <param name="dataGridView">The DataGridView to adjust row heights for.</param>
        /// <param name="rowHeight">The height value to set for all rows.</param>
        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows) row.Height = rowHeight;
        }

       
    }
}
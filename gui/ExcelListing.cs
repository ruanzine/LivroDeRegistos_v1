using Corale.Colore.Annotations;
using System;
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
        }


        public Panel GetFrame()
        {
            return this.pnlNormalListing;
        }


        private void bttPrint_Click(object sender, EventArgs e)
        {
            //// Criar a conexão com o banco de dados
            //using (SqlConnection connection = new SqlConnection("DatabaseConnectionString"))
            //{
            //    // Abrir a conexão
            //    connection.Open();

            //    // Criar o comando SQL e o adaptador de dados
            //    string sqlQuery = "SELECT * FROM Livros";
            //    SqlCommand command = new SqlCommand(sqlQuery, connection);
            //    SqlDataAdapter adapter = new SqlDataAdapter(command);

            //    // Preencher a DataTable com os dados da consulta
            //    DataTable dataTable = new DataTable();
            //    adapter.Fill(dataTable);

            //    // Fechar a conexão
            //    connection.Close();

            //    // Exportar a DataTable para o Excel usando o ClosedXML
            //    var workbook = new XLWorkbook();
            //    var worksheet = workbook.Worksheets.Add("Planilha1");

            //    // Preencher a planilha com os dados da DataTable (código anterior)

            //    // Salvar o arquivo do Excel
            //    string caminhoArquivo = "This PC/Downloads.xlsx";
            //    workbook.SaveAs(caminhoArquivo);
            //}
        }

        private void bttSearch_Click(object sender, EventArgs e)
        {
            this.registo_Livro = new Registo_Livro();
            FillDGV();
            

        }

        public void FillDGV()
        {
            try
            {
                string selectedOption = this.rjComboBox_SelectFilter.Texts;
                string searchText = this.txtPesquisa.Texts;

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
                    case "Todos":
                        dt = this.registo_Livro.GetBooks();
                        break;
                }

                this.dgvListagem.DataSource = dt;

                if (this.rjComboBox_SelectFilter.Texts == "Nº de Registo") // Verifica se o índice selecionado é igual a 1
                {
                    ResizeNReg();
                }
                else if (this.rjComboBox_SelectFilter.Texts == "Título")
                {
                    ResizeTitle();
                }
                else if(this.rjComboBox_SelectFilter.Texts == "Autor")
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

        private void rjComboBox_SelectFilter_TabIndexChanged(object sender, EventArgs e)
        {

            
        }



        public void ResizeNReg()
        {
            //Column width
            this.dgvListagem.Columns["Nº de Registo"].Width = 50;
            this.dgvListagem.Columns["Título"].Width = 250;

            //Font size
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Text Allignment
            this.dgvListagem.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna

        }
        public void ResizeAuthor()
        {

            //Header name resize
            this.dgvListagem.Columns["Autor"].Width = 250;

            //Font size and colour
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagem.Columns["Autor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvListagem, 40);
        }
        public void ResizeTitle()
        {
            //Header name resize
            this.dgvListagem.Columns["Título"].Width = 250;
            

            //Font size and colour
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.SetRowHeight(this.dgvListagem, 40);
        }
        public void ResizeCota()
        {
            this.dgvListagem.Columns["Cota"].Width = 130; 

            //Font size and colour
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagem.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.SetRowHeight(this.dgvListagem, 40);

        }
        public void ResizeState()
        {
            //Header name resize
            this.dgvListagem.Columns["Nº de Registo"].Width = 50; // Define a largura da coluna
            this.dgvListagem.Columns["Título"].Width = 250;
            this.dgvListagem.Columns["Estado"].Width = 150;

            //Font size and colour
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagem.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna

            this.SetRowHeight(this.dgvListagem, 40);
        }
        public void ResizeData()
        {
            //Header name resize
            this.dgvListagem.Columns["Nº de Registo"].Width = 50; // Define a largura da coluna
            this.dgvListagem.Columns["Data de Entrada"].Width = 90;
            this.dgvListagem.Columns["Título"].Width = 225;
            this.dgvListagem.Columns["Autor"].Width = 150;
            this.dgvListagem.Columns["Cota"].Width = 130;
            this.dgvListagem.Columns["Nº de Volume"].Width = 45;
            this.dgvListagem.Columns["Aquisição"].Width = 75;
            this.dgvListagem.Columns["Observações"].Width = 200;
            this.dgvListagem.Columns["Editora"].Width = 175;
            this.dgvListagem.Columns["Estado"].Width = 123;

            //Font size and colour
            this.dgvListagem.DefaultCellStyle.Font = new Font("Century Gothic", 11);
            this.dgvListagem.DefaultCellStyle.ForeColor = Color.FromArgb(30, 30, 32);

            //Row alignment and Height
            this.dgvListagem.Columns["Nº de Registo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter; // Centraliza o conteúdo da coluna
            this.dgvListagem.Columns["Data de Entrada"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Nº de Volume"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Cota"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Aquisição"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.dgvListagem.Columns["Estado"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            this.SetRowHeight(this.dgvListagem, 40);
        }

        private void SetRowHeight(DataGridView dataGridView, int rowHeight)
        {
            foreach (DataGridViewRow row in dataGridView.Rows) row.Height = rowHeight;
        }
    }
}
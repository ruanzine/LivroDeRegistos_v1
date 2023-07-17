using System;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class ExcelListing : Form
    {
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
    }
}
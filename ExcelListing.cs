using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using LivroDeRegistos_v1.Classes;
using PgpsUtilsAEFC.forms.extensions;

namespace LivroDeRegistos_v1
{
    public partial class ExcelListing : Form
    {

        public ExcelListing()
        {
            InitializeComponent();
        }


        public Panel GetPanel_ForPrinting()
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

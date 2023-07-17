using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace LivroDeRegistos_v1
{
    public class ExcelExporter : Form
    {
        public void ExportToExcel(DataTable dataTable, string filePath)
        {
            using (ExcelPackage package = new ExcelPackage())
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("Livros");

                // Escrever os cabeçalhos das colunas
                for (int i = 0; i < dataTable.Columns.Count; i++)
                {
                    worksheet.Cells[1, i + 1].Value = dataTable.Columns[i].ColumnName;
                }

                // Preencher os dados
                for (int row = 0; row < dataTable.Rows.Count; row++)
                {
                    for (int col = 0; col < dataTable.Columns.Count; col++)
                    {
                        worksheet.Cells[row + 2, col + 1].Value = dataTable.Rows[row][col];
                    }
                }

                // AutoAjustar as colunas para caber no conteúdo
                worksheet.Cells.AutoFitColumns();

                // Salvar o arquivo do Excel
                FileInfo excelFile = new FileInfo(filePath);
                package.SaveAs(excelFile);
            }

            MessageBox.Show("Exportação concluída com sucesso!", "Exportar para Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}

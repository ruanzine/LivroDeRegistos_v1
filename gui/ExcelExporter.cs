using System.Data;
using System.IO;
using System.Windows.Forms;
using OfficeOpenXml;

namespace LivroDeRegistos_v1.gui
{
    //It's actually a Manual
    public class ExcelExporter : Form
    {
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // ExcelExporter
            // 
            this.ClientSize = new System.Drawing.Size(1157, 667);
            this.Name = "ExcelExporter";
            this.ResumeLayout(false);

        }
    }
}
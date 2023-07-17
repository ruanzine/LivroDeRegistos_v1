using PgpsUtilsAEFC.forms.extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroDeRegistos_v1
{
    public partial class SelectListing : Form
    {
        ExcelListing getExcelListing = new ExcelListing();
        DateFromUntil getDateUntil = new DateFromUntil();
        public SelectListing()
        {
            InitializeComponent();
        }

        public Panel get_ChooseListing()
        {
            return this.pnlChooseListing;
        }
          
        private void bttNormalListing_Click(object sender, EventArgs e)
        {
            this.pnlChooseListing.SetAllFrom(getExcelListing.GetPanel_ForPrinting());
        }

        private void bttDateListing_Click(object sender, EventArgs e)
        {
            this.pnlChooseListing.SetAllFrom(getDateUntil.GetPanel_DateUntil());
        }
    }


}

using System.Windows.Forms;
using LivroDeRegistos_v1.RJControls;

namespace LivroDeRegistos_v1.gui
{
    public partial class DateFromUntil : Form
    {
        public DateFromUntil()
        {
            this.InitializeComponent();
        }

        public Panel GetFrame() => this.pnlPickDate;

        private void bttShowDate_Click(object sender, System.EventArgs e)
        {

        }
    }
}
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class ChooseDate : Form
    {
        public ChooseDate()
        {
            this.InitializeComponent();
        }

        public Panel GetPanel_PickDate()
        {
            return this.pnlPickDate;
        }
    }
}
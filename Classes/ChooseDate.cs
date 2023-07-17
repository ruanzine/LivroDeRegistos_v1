using System.Windows.Forms;

namespace LivroDeRegistos_v1.Classes
{
    public partial class ChooseDate : Form
    {
        public ChooseDate()
        {
            InitializeComponent();
        }

        public Panel GetPanel_PickDate()
        {
            return this.pnlPickDate;
        }
    }
}

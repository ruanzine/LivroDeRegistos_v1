using System;
using System.Windows.Forms;
using PgpsUtilsAEFC.forms.extensions;

namespace LivroDeRegistos_v1.gui
{
    public partial class MainForm : Form
    {
        private PanelAddLivros getAdd = new PanelAddLivros();
        private DGVBase getDGV = new DGVBase();
        private Panel_Edit getPanelEdit = new Panel_Edit();
        private Panel_Help GetPanel_Help= new Panel_Help();
        private Statistics getStatistics = new Statistics();
        private SelectionList SelectListing { get; set; }
        
        public MainForm()
        {
            this.InitializeComponent();
            SelectListing = new SelectionList(this);
        }

        public Panel GetFrame() => this.pnlMainFrame;

        
        private void bttNew_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.getAdd.GetPanel_Add());
        }

        private void bttPesquisar_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.getDGV.GetPanel_Search());
        }
        private void bttEdidBook_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.getPanelEdit.GetPanel_Edit());
        }

        private void bttListing_Click(object sender, EventArgs e)
        {
            SelectListing.GetFrame().Size = this.pnlMainFrame.Size;
            SelectListing.GetFrame().Location = this.pnlMainFrame.Location;
            this.pnlMainFrame.SetAllFrom(SelectListing.GetFrame());
        }
        private void picLogo_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.pnlMainFrame);
        }



        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bttHelp_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.GetPanel_Help.GetPanel_Manual());
        }

        private void bttStatistics_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.getStatistics.Get_StatistcsPan());
        }
    }
}
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
        private ExcelExporter getPanListing = new ExcelExporter();

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
            //this.pnlMainFrame.SetAllFrom(getPanListing.GetPanel_Listing());
            SelectListing.GetFrame().Size = this.pnlMainFrame.Size;
            this.pnlMainFrame.SetAllFrom(SelectListing.GetFrame());
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void pnlMainFrame_Paint(object sender, PaintEventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {
        }

        private void picLogo_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(this.pnlMainFrame);
        }

        //public Panel getSentBack()
        //{
        //    return this.pnlMainFrame;
        //}
    }
}
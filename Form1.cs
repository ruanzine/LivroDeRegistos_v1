using PgpsUtilsAEFC.forms.extensions;
using System;
using System.Windows.Forms;


namespace LivroDeRegistos_v1
{
    public partial class MainForm : Form
    {
        PanelAddLivros getAdd = new PanelAddLivros();
        DGVBase getDGV = new DGVBase();
        Panel_Edit getPanelEdit = new Panel_Edit();
        ExcelExporter getPanListing = new ExcelExporter();
        SelectListing getChooseListing = new SelectListing();


        public MainForm()
        {
            InitializeComponent();
        }

        private void bttNew_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(getAdd.GetPanel_Add());
        }
        private void bttPesquisar_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(getDGV.GetPanel_Search());
        }
        private void bttEdidBook_Click(object sender, EventArgs e)
        {
            this.pnlMainFrame.SetAllFrom(getPanelEdit.GetPanel_Edit());
        }

        private void bttListing_Click(object sender, EventArgs e)
        {
            //this.pnlMainFrame.SetAllFrom(getPanListing.GetPanel_Listing());
            this.pnlMainFrame.SetAllFrom(getChooseListing.get_ChooseListing()); 

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
            this.pnlMainFrame.SetAllFrom(pnlMainFrame);
        }

        //public Panel getSentBack()
        //{
        //    return this.pnlMainFrame;
        //}
    }
}

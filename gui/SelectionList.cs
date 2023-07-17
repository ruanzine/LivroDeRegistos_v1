using System;
using System.Windows.Forms;
using PgpsUtilsAEFC.forms.extensions;

namespace LivroDeRegistos_v1.gui
{
    public partial class SelectionList : Form
    {
        /// <summary>
        /// A reference to the main form
        /// </summary>
        private MainForm MainForm { get; set; }

        /// <summary>
        /// A reference to the date selection form
        /// </summary>
        private DateFromUntil DateUntil { get; set; } = new DateFromUntil();
        
        /// <summary>
        /// A reference to the Excel listing form
        /// </summary>
        private ExcelListing ExcelList { get; set; } = new ExcelListing();
        
        public SelectionList(MainForm mainForm)
        {
            InitializeComponent();
            this.MainForm = mainForm;
        }

        /// <summary>
        /// Returns the frame from the form
        /// </summary>
        /// <returns>The Panel acting as a frame</returns>
        public Panel GetFrame() => this.ListingFrame;
        
        private void bttNormalListing_Click(object sender, EventArgs e)
        {
            this.MainForm.GetFrame().SetAllFrom(ExcelList.GetFrame());
        }

        private void bttDateListing_Click(object sender, EventArgs e)
        {
            this.MainForm.GetFrame().SetAllFrom(DateUntil.GetFrame());
        }
    }
}
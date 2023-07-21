using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.gui
{
    public partial class Panel_Help : Form
    {
        public Panel_Help()
        {
            InitializeComponent();
        }

        public Panel GetPanel_Manual()
        {
            return this.pnlManual;
        }


    }
}

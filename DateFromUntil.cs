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
    public partial class DateFromUntil : Form
    {
        public DateFromUntil()
        {
            InitializeComponent();
        }

        public Panel GetPanel_DateUntil()
        {
            return this.pnlPickDate;
        }
    }
}

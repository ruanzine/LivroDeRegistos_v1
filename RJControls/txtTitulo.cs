using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace LivroDeRegistos_v1.RJControls
{
    public partial class txtTitulo : UserControl
    {
        //[DefaultEvent ("_TextChanged")]
        //Fields 
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;

        //Constructor 
        public txtTitulo()
        {
            this.InitializeComponent();
        }


        [Category("TextBox Coding")]
        public Color BorderColor
        {
            get => this.borderColor;
            set
            {
                this.borderColor = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Coding")]
        public int BorderSize
        {
            get => this.borderSize;
            set
            {
                this.borderSize = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Coding")]
        public bool UnderlinedStyle
        {
            get => this.underlinedStyle;
            set
            {
                this.underlinedStyle = value;
                this.Invalidate();
            }
        }

        [Category("TextBox Coding")]
        public string Texts
        {
            get => this.textBox1.Text;
            set => this.textBox1.Text = value;
        }


        [Category("TextBox Coding")]
        public bool PasswordChar
        {
            get => this.textBox1.UseSystemPasswordChar;
            set => this.textBox1.UseSystemPasswordChar = value;
        }

        [Category("TextBox Coding")]
        public bool Multiline
        {
            get => this.textBox1.Multiline;
            set => this.textBox1.Multiline = value;
        }

        [Category("TextBox Coding")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                this.textBox1.ForeColor = value;
            }
        }

        [Category("TextBox Coding")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                this.textBox1.Font = value;
                if (this.DesignMode) this.UpdateControlHeight();
            }
        }

        //Overriden method
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            //Draw border
            using (Pen penBorder = new Pen(this.borderColor, this.borderSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (this.underlinedStyle)
                    graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                else
                    graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode) this.UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            this.UpdateControlHeight();
        }

        //Events
        //public event EventHandler _TextChanged; 
        //Private Methods 
        private void UpdateControlHeight()
        {
            if (this.textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                this.textBox1.Multiline = true;
                this.textBox1.MinimumSize = new Size(0, txtHeight);
                this.textBox1.Multiline = false;

                this.Height = this.textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
    }
}
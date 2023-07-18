using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;
using System.Drawing.Design;

namespace LivroDeRegistos_v1.RJControls
{
    [DefaultEvent("OnSelectedIndexChanged")]
    public class RJComboBox : UserControl
    {
        //Fields
        private Color backColor = Color.WhiteSmoke;
        private Color iconColor = Color.MediumSlateBlue;
        private Color listBackColor = Color.FromArgb(230, 228, 245);
        private Color listTextColor = Color.DimGray;
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 1;

        //Items
        private ComboBox cmbList;
        private Label lblText;
        private Button btnIcon;

        //Events
        public event EventHandler OnSelectedIndexChanged; //Default event

        //Constructor
        public RJComboBox()
        {
            this.cmbList = new ComboBox();
            this.lblText = new Label();
            this.btnIcon = new Button();
            this.SuspendLayout();

            //ComboBox: Dropdown list
            this.cmbList.BackColor = this.listBackColor;
            this.cmbList.Font = new Font(this.Font.Name, 10F);
            this.cmbList.ForeColor = this.listTextColor;
            this.cmbList.SelectedIndexChanged += new EventHandler(this.ComboBox_SelectedIndexChanged); //Default event
            this.cmbList.TextChanged += new EventHandler(this.ComboBox_TextChanged); //Refresh text

            //Button: Icon
            this.btnIcon.Dock = DockStyle.Right;
            this.btnIcon.FlatStyle = FlatStyle.Flat;
            this.btnIcon.FlatAppearance.BorderSize = 0;
            this.btnIcon.BackColor = this.backColor;
            this.btnIcon.Size = new Size(30, 30);
            this.btnIcon.Cursor = Cursors.Hand;
            this.btnIcon.Click += new EventHandler(this.Icon_Click); //Open dropdown list
            this.btnIcon.Paint += new PaintEventHandler(this.Icon_Paint); //Draw icon

            //Label: Text
            this.lblText.Dock = DockStyle.Fill;
            this.lblText.AutoSize = false;
            this.lblText.BackColor = this.backColor;
            this.lblText.TextAlign = ContentAlignment.MiddleLeft;
            this.lblText.Padding = new Padding(8, 0, 0, 0);
            this.lblText.Font = new Font(this.Font.Name, 10F);
            //->Attach label events to user control event
            this.lblText.Click += new EventHandler(this.Surface_Click); //Select combo box
            this.lblText.MouseEnter += new EventHandler(this.Surface_MouseEnter);
            this.lblText.MouseLeave += new EventHandler(this.Surface_MouseLeave);

            //User Control
            this.Controls.Add(this.lblText); //2
            this.Controls.Add(this.btnIcon); //1
            this.Controls.Add(this.cmbList); //0
            this.MinimumSize = new Size(200, 30);
            this.Size = new Size(200, 30);
            this.ForeColor = Color.DimGray;
            this.Padding = new Padding(this.borderSize); //Border Size
            this.Font = new Font(this.Font.Name, 10F);
            base.BackColor = this.borderColor; //Border Color
            this.ResumeLayout();
            this.AdjustComboBoxDimensions();
        }

        //Properties
        //-> Appearance
        [Category("RJ Code - Appearance")]
        public new Color BackColor
        {
            get => this.backColor;
            set
            {
                this.backColor = value;
                this.lblText.BackColor = this.backColor;
                this.btnIcon.BackColor = this.backColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color IconColor
        {
            get => this.iconColor;
            set
            {
                this.iconColor = value;
                this.btnIcon.Invalidate(); //Redraw icon
            }
        }

        [Category("RJ Code - Appearance")]
        public Color ListBackColor
        {
            get => this.listBackColor;
            set
            {
                this.listBackColor = value;
                this.cmbList.BackColor = this.listBackColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color ListTextColor
        {
            get => this.listTextColor;
            set
            {
                this.listTextColor = value;
                this.cmbList.ForeColor = this.listTextColor;
            }
        }

        [Category("RJ Code - Appearance")]
        public Color BorderColor
        {
            get => this.borderColor;
            set
            {
                this.borderColor = value;
                base.BackColor = this.borderColor; //Border Color
            }
        }

        [Category("RJ Code - Appearance")]
        public int BorderSize
        {
            get => this.borderSize;
            set
            {
                this.borderSize = value;
                this.Padding = new Padding(this.borderSize); //Border Size
                this.AdjustComboBoxDimensions();
            }
        }

        [Category("RJ Code - Appearance")]
        public override Color ForeColor
        {
            get => base.ForeColor;
            set
            {
                base.ForeColor = value;
                this.lblText.ForeColor = value;
            }
        }

        [Category("RJ Code - Appearance")]
        public override Font Font
        {
            get => base.Font;
            set
            {
                base.Font = value;
                this.lblText.Font = value;
                this.cmbList.Font = value; //Optional
            }
        }

        [Category("RJ Code - Appearance")]
        public string Texts
        {
            get => this.lblText.Text;
            set => this.lblText.Text = value;
        }

        [Category("RJ Code - Appearance")]
        public ComboBoxStyle DropDownStyle
        {
            get => this.cmbList.DropDownStyle;
            set
            {
                if (this.cmbList.DropDownStyle != ComboBoxStyle.Simple) this.cmbList.DropDownStyle = value;
            }
        }

        //Properties
        //-> Data
        [Category("RJ Code - Data")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [Localizable(true)]
        [MergableProperty(false)]
        public ComboBox.ObjectCollection Items => this.cmbList.Items;

        [Category("RJ Code - Data")]
        [AttributeProvider(typeof(IListSource))]
        [DefaultValue(null)]
        public object DataSource
        {
            get => this.cmbList.DataSource;
            set => this.cmbList.DataSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor("System.Windows.Forms.Design.ListControlStringCollectionEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [EditorBrowsable(EditorBrowsableState.Always)]
        [Localizable(true)]
        public AutoCompleteStringCollection AutoCompleteCustomSource
        {
            get => this.cmbList.AutoCompleteCustomSource;
            set => this.cmbList.AutoCompleteCustomSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteSource.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteSource AutoCompleteSource
        {
            get => this.cmbList.AutoCompleteSource;
            set => this.cmbList.AutoCompleteSource = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(true)]
        [DefaultValue(AutoCompleteMode.None)]
        [EditorBrowsable(EditorBrowsableState.Always)]
        public AutoCompleteMode AutoCompleteMode
        {
            get => this.cmbList.AutoCompleteMode;
            set => this.cmbList.AutoCompleteMode = value;
        }

        [Category("RJ Code - Data")]
        [Bindable(true)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public object SelectedItem
        {
            get => this.cmbList.SelectedItem;
            set => this.cmbList.SelectedItem = value;
        }

        [Category("RJ Code - Data")]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int SelectedIndex
        {
            get => this.cmbList.SelectedIndex;
            set => this.cmbList.SelectedIndex = value;
        }

        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        [TypeConverter("System.Windows.Forms.Design.DataMemberFieldConverter, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
        public string DisplayMember
        {
            get => this.cmbList.DisplayMember;
            set => this.cmbList.DisplayMember = value;
        }

        [Category("RJ Code - Data")]
        [DefaultValue("")]
        [Editor("System.Windows.Forms.Design.DataMemberFieldEditor, System.Design, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", typeof(UITypeEditor))]
        public string ValueMember
        {
            get => this.cmbList.ValueMember;
            set => this.cmbList.ValueMember = value;
        }

        //Private methods
        private void AdjustComboBoxDimensions()
        {
            this.cmbList.Width = this.lblText.Width;
            this.cmbList.Location = new Point()
            {
                X = this.Width - this.Padding.Right - this.cmbList.Width,
                Y = this.lblText.Bottom - this.cmbList.Height
            };
        }

        //Event methods

        //-> Default event
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (OnSelectedIndexChanged != null)
                OnSelectedIndexChanged.Invoke(sender, e);
            //Refresh text
            this.lblText.Text = this.cmbList.Text;
        }

        //-> Draw icon
        private void Icon_Paint(object sender, PaintEventArgs e)
        {
            //Fields
            int iconWidht = 14;
            int iconHeight = 6;
            Rectangle rectIcon = new Rectangle((this.btnIcon.Width - iconWidht) / 2, (this.btnIcon.Height - iconHeight) / 2, iconWidht, iconHeight);
            Graphics graph = e.Graphics;

            //Draw arrow down icon
            using (GraphicsPath path = new GraphicsPath())
            using (Pen pen = new Pen(this.iconColor, 2))
            {
                graph.SmoothingMode = SmoothingMode.AntiAlias;
                path.AddLine(rectIcon.X, rectIcon.Y, rectIcon.X + iconWidht / 2, rectIcon.Bottom);
                path.AddLine(rectIcon.X + iconWidht / 2, rectIcon.Bottom, rectIcon.Right, rectIcon.Y);
                graph.DrawPath(pen, path);
            }
        }

        //-> Items actions
        private void Icon_Click(object sender, EventArgs e)
        {
            //Open dropdown list
            this.cmbList.Select();
            this.cmbList.DroppedDown = true;
        }

        private void Surface_Click(object sender, EventArgs e)
        {
            //Attach label click to user control click
            this.OnClick(e);
            //Select combo box
            this.cmbList.Select();
            if (this.cmbList.DropDownStyle == ComboBoxStyle.DropDownList) this.cmbList.DroppedDown = true; //Open dropdown list
        }

        private void ComboBox_TextChanged(object sender, EventArgs e)
        {
            //Refresh text
            this.lblText.Text = this.cmbList.Text;
        }


        //->Attach label events to user control event
        private void Surface_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void Surface_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        //::::+

        //Overridden methods
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.AdjustComboBoxDimensions();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // RJComboBox
            // 
            this.Name = "RJComboBox";
            this.TabIndexChanged += new System.EventHandler(this.RJComboBox_TabIndexChanged);
            this.ResumeLayout(false);

        }

        private void RJComboBox_TabIndexChanged(object sender, EventArgs e)
        {
            this.OnTabIndexChanged(e);

        }

        
    }
}
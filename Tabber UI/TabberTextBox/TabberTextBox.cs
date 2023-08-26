using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tabber_UI.TabberTextBox
{
    public partial class TabberTextBox : UserControl
    {
        public TabberTextBox()
        {
            InitializeComponent();
            TextBox.BackColor = BackgroundColor;
            TextBoxMuntiline = false;
        }

        [Category("Fluency")]
        public string TextBoxText
        {
            get { return TextBox.Text.ToString(); }
            set { TextBox.Text = value; }
        }

        [Category("Fluency")]
        public Color TextColor
        {
            get { return TextBox.ForeColor; }
            set { TextBox.ForeColor = value; }
        }

        [Category("Fluency")]
        public bool TextBoxMuntiline
        {
            get { return TextBox.Multiline; }
            set { TextBox.Multiline = value; }
        }

        [Category("Fluency")]
        public Color BorderColor
        {
            get { return TabberPanel.BorderColor; }
            set
            {
                TabberPanel.BorderColor = value;
                this.Invalidate();
            }
        }

        [Category("Fluency")]
        public int BorderSize
        {
            get { return TabberPanel.BorderSize; }
            set { TabberPanel.BorderSize = value; }
        }

        [Category("Fluency")]
        public Color BackgroundColor
        {
            get { return TabberPanel.BackColor; }
            set { TabberPanel.BackColor = value; }
        }
    }
}

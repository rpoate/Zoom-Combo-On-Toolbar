using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zoom_Toolbar
{
    public partial class Form1 : Form
    {
        readonly ToolStripComboBox oZoom;

        public Form1()
        {
            InitializeComponent();

            oZoom = new ToolStripComboBox
            {
                Padding = new Padding(3)
            };
            oZoom.Items.AddRange(new string[] { "200%", "100%", "75%", "50%" });
            oZoom.SelectedIndexChanged += OZoom_TextUpdate;

            this.htmlEditControl1.ToolStripItems.Add(oZoom);

            this.htmlEditControl1.ZoomLevelChanged += HtmlEditControl1_ZoomLevelChanged;
            this.htmlEditControl1.HideDOMToolbar = true;
        }

        private void OZoom_TextUpdate(object sender, EventArgs e)
        {
            this.htmlEditControl1.ZoomLevel = int.Parse(oZoom.Text.Replace("%", ""));
            this.htmlEditControl1.SetFocus();
        }

        private void HtmlEditControl1_ZoomLevelChanged(object sender, EventArgs e)
        {
            oZoom.Text = this.htmlEditControl1.ZoomLevel.ToString() + "%";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

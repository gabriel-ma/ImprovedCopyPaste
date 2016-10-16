using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImprovedCopyPaste.view
{
    public partial class Visualizer : Form
    {
        public Visualizer()
        {
            InitializeComponent();
        }

        private void getCopy() {
            //Image a = Clipboard.

            //this.BackgroundImage = a;

            if (lbl1.Text == "'") {
                lbl1.Text = Clipboard.GetText();
            }
            else if (lbl2.Text == "'"){
                lbl2.Text = Clipboard.GetText();
            }
            else if (lbl3.Text == "'"){
                lbl3.Text = Clipboard.GetText();
            }

        }
        //hmmmmmmm
        private void Visualizer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ControlKey)
                getCopy();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl2.Text);
        }

        private void lbl1_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl1.Text);
        }

        private void lbl3_DoubleClick(object sender, EventArgs e)
        {
            Clipboard.SetText(lbl3.Text);
        }
    }
}

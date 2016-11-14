using System;
using System.Windows.Forms;
using ImprovedCopyPaste.auxi;
namespace ImprovedCopyPaste.view
{
    public partial class Visualizer : Form
    {
        KeyboardHook hook = new KeyboardHook();
        int i = 0;
        public Visualizer()
        {
            InitializeComponent();

            // register the event that is fired after the key press.
            hook.KeyPressed +=
                new EventHandler<KeyPressedEventArgs>(hook_KeyPressed);
            // register the control + alt + F12 combination as hot key.
            hook.RegisterHotKey(auxi.ModifierKeys.Control, Keys.F12);
            

        }

        void hook_KeyPressed(object sender, KeyPressedEventArgs e)
        {
            // show the keys pressed in a label.
            if (this.Visible)
                Hide();
            else {
                i++;
                getCopy();

                if (i == 3) {
                    Show();
                }
            }
         
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

        private void Visualizer_Load(object sender, EventArgs e)
        {
            Hide();
        }
    }

}

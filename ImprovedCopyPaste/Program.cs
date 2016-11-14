using System;
using System.Windows.Forms;
using ImprovedCopyPaste.view;

namespace ImprovedCopyPaste
{

    static class Program
    {
        [STAThread]
        static void Main()
        {
                Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Visualizer vi = new Visualizer();
            vi.Visible = false;
            
            Application.Run(vi);
            
            
            // DLL libraries used to manage hotkeys



        }
    }
}

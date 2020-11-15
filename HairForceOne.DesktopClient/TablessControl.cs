using System;
using System.Windows.Forms;

namespace HairForceOne.DesktopClient
{
    class TablessControl : TabControl
    {
        protected override void WndProc(ref Message m)
        {
            //Tillader os at bruge TabControl uden synlige tabs (CardLayout)
            if (m.Msg == 0x1328 && !DesignMode) m.Result = (IntPtr)1;
            else base.WndProc(ref m);
            // Brug SelectedTab eller SelectedIndex til at skifte tab i kode
        }
    }
}

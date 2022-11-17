using System.Runtime.InteropServices;

namespace Cyrus
{
    public partial class mainForm : Form
    {
        [DllImport("User32.dll")]
        protected static extern int SetClipboardViewer(int hWndNewViewer);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern bool ChangeClipboardChain(IntPtr hWndRemove, IntPtr hWndNewNext);

        [DllImport("user32.dll", CharSet = CharSet.Auto)]
        public static extern int SendMessage(IntPtr hwnd, int wMsg, IntPtr wParam, IntPtr lParam);


        IntPtr nextClipboardViewer;

        public mainForm()
        {
            InitializeComponent();
            this.nextClipboardViewer = (IntPtr)SetClipboardViewer((int)this.Handle);
        }

        protected override void WndProc(ref Message m)
        {
            //  defined in winuser.h
            const int WM_DRAWCLIPBOARD = 0x308;
            const int WM_CHANGECBCHAIN = 0x030D;

            switch (m.Msg)
            {
                case WM_DRAWCLIPBOARD:
                    string text = Clipboard.GetText();
                    Console.WriteLine(text);
                    SendMessage(this.nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    break;
                case WM_CHANGECBCHAIN:
                    if (m.WParam == this.nextClipboardViewer)
                    {
                        this.nextClipboardViewer = m.LParam;
                    }
                    else
                    {
                        SendMessage(this.nextClipboardViewer, m.Msg, m.WParam, m.LParam);
                    }
                    break;
                default:
                    base.WndProc(ref m);
                    break;
            }
            
        }

    }
}
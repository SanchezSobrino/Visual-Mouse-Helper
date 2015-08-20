using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using Microsoft;

namespace VisualMouseHelper
{
    public partial class MainForm : Form
    {
        private SolidBrush brush1;
        private SolidBrush brush2;
        private Point coords;
        private bool in_settings;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams baseParams = base.CreateParams;
                baseParams.ExStyle |= (int)(0x00080000 | 0x08000000 | 0x00000080 | 0x00000020);
                return baseParams;
            }
        }

        public MainForm()
        {
            InitializeComponent();

            this.BackColor = Color.White;
            this.TransparencyKey = this.BackColor;
            this.WindowState = FormWindowState.Maximized;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Bounds = Screen.PrimaryScreen.Bounds;
            this.TopMost = true;
            this.DoubleBuffered = true;

            this.brush1 = new SolidBrush(Properties.Settings.Default.Color1);
            this.brush2 = new SolidBrush(Properties.Settings.Default.Color2);
            this.in_settings = false;

            MouseHook.Start();
            MouseHook.MouseAction += new EventHandler(MainForm_MouseMove);

            this.Paint += new PaintEventHandler(this.MainForm_Paint);
            this.KeyPress += new KeyPressEventHandler(this.MainForm_KeyPress);

            this.Execute(this.swapColors, Properties.Settings.Default.Frequency);
        }

        private void MainForm_MouseMove(object sender, EventArgs e) {
            MouseHook.MSLLHOOKSTRUCT mouse = (MouseHook.MSLLHOOKSTRUCT)sender;
            this.coords.X = mouse.pt.x;
            this.coords.Y = mouse.pt.y;
            this.Invalidate();
        }

        void MainForm_KeyPress(object sender, KeyPressEventArgs e) {
            switch(e.KeyChar) {
                case '\r':
                    this.in_settings = true;
                    SettingsForm f = new SettingsForm(this.brush1, this.brush2);
                    f.ShowDialog(this);
                    if(f.DialogResult == DialogResult.Cancel)
                        this.in_settings = false;
                    e.Handled = true;
                    break;
            }
        }

        private void MainForm_Paint(object sender, PaintEventArgs e) {
            Graphics g = e.Graphics;

            int x = this.coords.X + Properties.Settings.Default.PosX;
            int y = this.coords.Y + Properties.Settings.Default.PosY;

            g.FillEllipse(this.brush1, 
                x, 
                y, 
                Properties.Settings.Default.Size, 
                Properties.Settings.Default.Size);
            g.FillEllipse(this.brush2, 
                x + Properties.Settings.Default.OffsetX, 
                y + Properties.Settings.Default.OffsetY, 
                Properties.Settings.Default.Size, 
                Properties.Settings.Default.Size);

            if(!this.in_settings)
                this.recoverFullScreen();
        }

        public async void Execute(Action action, int timeoutInMilliseconds) {
            await Task.Delay(timeoutInMilliseconds);
            action();
            this.Execute(this.swapColors, Properties.Settings.Default.Frequency);
        }

        private void swapColors() {
            Color aux = this.brush1.Color;
            this.brush1.Color = this.brush2.Color;
            this.brush2.Color = aux;
            this.Invalidate();
        }

        /// <summary>
        /// Asserts the ghost window is ALWAYS at top, i.e. over the taskbar and other stuff
        /// </summary>
        private void recoverFullScreen() {
            this.WindowState = FormWindowState.Normal;
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
        }
    }

    public static class MouseHook
    {
        public static event EventHandler MouseAction = delegate { };

        public static void Start() {
            _hookID = SetHook(_proc);
        }
        public static void Stop() {
            UnhookWindowsHookEx(_hookID);
        }

        private static LowLevelMouseProc _proc = HookCallback;
        private static IntPtr _hookID = IntPtr.Zero;

        private static IntPtr SetHook(LowLevelMouseProc proc) {
            using (Process curProcess = Process.GetCurrentProcess())
            using (ProcessModule curModule = curProcess.MainModule) {
                return SetWindowsHookEx(WH_MOUSE_LL, proc,
                  GetModuleHandle(curModule.ModuleName), 0);
            }
        }

        private delegate IntPtr LowLevelMouseProc(int nCode, IntPtr wParam, IntPtr lParam);

        private static IntPtr HookCallback(int nCode, IntPtr wParam, IntPtr lParam) {
            if (nCode >= 0 && MouseMessages.WM_MOUSEMOVE == (MouseMessages)wParam) {
                MSLLHOOKSTRUCT hookStruct = (MSLLHOOKSTRUCT)Marshal.PtrToStructure(lParam, typeof(MSLLHOOKSTRUCT));
                MouseAction(hookStruct, new EventArgs());
            }
            return CallNextHookEx(_hookID, nCode, wParam, lParam);
        }

        private const int WH_MOUSE_LL = 14;
        private enum MouseMessages {
            WM_LBUTTONDOWN = 0x0201,
            WM_LBUTTONUP = 0x0202,
            WM_MOUSEMOVE = 0x0200,
            WM_MOUSEWHEEL = 0x020A,
            WM_RBUTTONDOWN = 0x0204,
            WM_RBUTTONUP = 0x0205
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct POINT {
            public int x;
            public int y;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MSLLHOOKSTRUCT {
            public POINT pt;
            public uint mouseData;
            public uint flags;
            public uint time;
            public IntPtr dwExtraInfo;
        }

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr SetWindowsHookEx(int idHook,
          LowLevelMouseProc lpfn, IntPtr hMod, uint dwThreadId);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool UnhookWindowsHookEx(IntPtr hhk);

        [DllImport("user32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr CallNextHookEx(IntPtr hhk, int nCode,
          IntPtr wParam, IntPtr lParam);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
        private static extern IntPtr GetModuleHandle(string lpModuleName);
    }
}

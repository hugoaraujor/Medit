using System;
using System.Drawing;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Diagnostics;
namespace Medit
{
    

   
    public partial class Usuarios : Form
    {
        public Usuarios()
        {
            InitializeComponent();
        }
        [DllImport("user32.dll", CharSet = CharSet.Auto, CallingConvention = CallingConvention.StdCall)]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint cButtons, uint dwExtraInfo);

        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        private const int MOUSEEVENTF_RIGHTDOWN = 0x08;
        private const int MOUSEEVENTF_RIGHTUP = 0x10;
        private const int WM_MOUSEHWHEEL = 0x020E;
        private Button button1 = new Button();
      // Get a handle to an application window.
        [DllImport("USER32.DLL", CharSet = CharSet.Unicode)]
        public static extern IntPtr FindWindow(string lpClassName,
            string lpWindowName);
    

       

        [DllImport("USER32.DLL")]
        private static extern int GetWindowTextLength(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        private static extern bool IsWindowVisible(IntPtr hWnd);

        [DllImport("USER32.DLL")]
        private static extern IntPtr GetShellWindow();

        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        // Activate an application window.
        [DllImport("USER32.DLL")]
        public static extern bool SetForegroundWindow(IntPtr hWnd);

        // Send a series of key presses to the Calculator application.
        private void button1_Click(object sender, EventArgs e)
        {
            // Get a handle to the Calculator application. The window class
            // and window name were obtained using the Spy++ tool.
            IntPtr calculatorHandle = FindWindow(null, "Calculadora");

            // Verify that Calculator is a running process.
            if (calculatorHandle == IntPtr.Zero)
            {
                MessageBox.Show("Calculator is not running.");
                return;
            }

            // Make Calculator the foreground application and send it 
            // a set of calculations.
            SetForegroundWindow(calculatorHandle);
            SendKeys.SendWait("111");
            SendKeys.SendWait("*");
            SendKeys.SendWait("11");
            SendKeys.SendWait("=");
        }

        // Send a key to the button when the user double-clicks anywhere 
        // on the form.
      

   

        private void Usuarios_Load_1(object sender, EventArgs e)
        {
            button2.Location = new Point(10, 10);
            button2.TabIndex = 0;
            button2.Text = "Click to automate Calculator";
            button2.AutoSize = true;
            button2.Click += new EventHandler(button1_Click);

          
            this.Controls.Add(button1);
            Process[] processlist = Process.GetProcesses();

            foreach (Process process in processlist)
            {
                if (!String.IsNullOrEmpty(process.MainWindowTitle))
                {
                    Console.WriteLine("Process: {0} ID: {1} Window title: {2} handle {3}", process.ProcessName, process.Id, process.MainWindowTitle,process.Handle.ToString());
                }
            }
        }

        [Flags]
        public enum MouseEventFlags
        {
            LeftDown = 0x00000002,
            LeftUp = 0x00000004,
            MiddleDown = 0x00000020,
            MiddleUp = 0x00000040,
            Move = 0x00000001,
            Absolute = 0x00008000,
            RightDown = 0x00000008,
            RightUp = 0x00000010,
            Rueda= 0x00000800
        }
      
        [DllImport("user32.dll", EntryPoint = "SetCursorPos")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool SetCursorPos(int X, int Y);
        [DllImport("Kernel32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern void Sleep(long Milliseconds);

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool GetCursorPos(out MousePoint lpMousePoint);

        [DllImport("user32.dll")]
        private static extern void mouse_event(int dwFlags, int dx, int dy, int dwData, int dwExtraInfo);

        public static void SetCursorPosition(int X, int Y)
        {
            SetCursorPos(X, Y);
        }

        public static void SetCursorPosition(MousePoint point)
        {
            SetCursorPos(point.X, point.Y);
        }

        public static MousePoint GetCursorPosition()
        {
            MousePoint currentMousePoint;
            var gotPoint = GetCursorPos(out currentMousePoint);
            if (!gotPoint) { currentMousePoint = new MousePoint(0, 0); }
            return currentMousePoint;
        }

        public static void MouseEvent(MouseEventFlags value)
        {
            MousePoint position = GetCursorPosition();

            mouse_event
                ((int)value,
                 position.X,
                 position.Y,
                 0,
                 0)
                ;
        }

        [StructLayout(LayoutKind.Sequential)]
        public struct MousePoint
        {
            public int X;
            public int Y;

            public MousePoint(int x, int y)
            {
                X = x;
                Y = y;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IntPtr calculatorHandle = FindWindow(null,"chrome");
            SetCursorPos(1156,114);
            // mouse_event(0, 400,410, 4, 0);
            System.Threading.Thread.Sleep(400);
            mouse_event(MOUSEEVENTF_LEFTDOWN,1156,114,0, 0);
            mouse_event(MOUSEEVENTF_LEFTUP, 1156,114, 0, 0);
            System.Threading.Thread.Sleep(400);
            //   SendKeys.Send("mozart");
            // SendKeys.Send("{ENTER}");
            //  mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
               mouse_event(WM_MOUSEHWHEEL, 0, 0, 0, 0);

            //mouse_event((uint)MouseEventFlags.Rueda,0,0, 0, 0);
            //SendKeys.Send("{PGDN}");
            //SendKeys.Send("{PGDN}");
            //SendKeys.Send("{PGDN}");
            //System.Threading.Thread.Sleep(400);
            //SendKeys.Send("{PGDN}");
            //SendKeys.Send("{PGDN}");
            //SendKeys.Send("{PGUP}");
            //SendKeys.Send("{PGUP}");
            //SendKeys.Send("{PGUP}");
  
            // mouse_event((uint)MouseEventFlags.Rueda, 0, 0, 120, 0);
            //

        }

        private void Usuarios_MouseMove(object sender, MouseEventArgs e)
        {
     //       this.label1.Text = e.X.ToString();
     //     this.label2.Text = e.Y.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            IntPtr calculatorHandle = FindWindow(null, null);
         
            this.Close();
          
        }
    }
}
